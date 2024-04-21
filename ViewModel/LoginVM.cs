using GlobaWBNew.Model;
using GlobaWBNew.View;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;

namespace GlobaWBNew.ViewModel {
    public class LoginVM : PropChange {
        private ApplicationContext db = new ApplicationContext();

        public ObservableCollection<Staff> Staff { get; set; }

        public LoginVM() {
            db.Database.EnsureDeleted();
            db.Database.EnsureCreated();

            Point point1 = new Point { Address = "Ленина, 90"};
            Point point2 = new Point { Address = "Сталелитейная, 44/2"};
            Point point3 = new Point { Address = "Станиславского, 7"};
            Point point4 = new Point { Address = "Новогодняя, 142" };
            Point point5 = new Point { Address = "Планировочная, 16" };
            Point point6 = new Point { Address = "Станционная, 58" };
            Point point7 = new Point { Address = "Шекспира, 7" };
            Point point8 = new Point { Address = "Каменская, 82" };

            Staff staff1 = new Staff { FullName = "Лыско Иван Евгеньевич", Login = "IvanLE", Password = "12345", Role = "ADM", Post = "Admin", Salary = 90000 };
            Staff staff2 = new Staff { FullName = "Вахрушева Анна Сергеевна", Login = "AnnaVS", Password = "54321", Role = "STF", Post = "Worker", Salary = 45000 };

            Seller sel1 = new Seller() { Name = "JOYCITY", ContactInformation = "JoyCiti@gmail.com", Books = new ObservableCollection<Book>() };
            Seller sel2 = new Seller() { Name = "Samy", ContactInformation = "Samy@gmail.com", Books = new ObservableCollection<Book>() };
            Seller sel3 = new Seller() { Name = "Deiratex", ContactInformation = "Deiratex@gmail.com", Books = new ObservableCollection<Book>() };
            Seller sel4 = new Seller() { Name = "KROMLAND", ContactInformation = "KROMLAND@gmail.com", Books = new ObservableCollection<Book>() };
            Seller sel5 = new Seller() { Name = "Infindini", ContactInformation = "Infindini@gmail.com", Books = new ObservableCollection<Book>() };
            Seller sel6 = new Seller() { Name = "Barinoff", ContactInformation = "Barinoff@gmail.com", Books = new ObservableCollection<Book>() };

            db.Points.AddRange(point1, point2, point3, point4, point5, point6, point7, point8);
            db.Sellers.AddRange(sel1, sel2, sel3, sel4, sel5, sel6);

            db.SaveChanges();

            db.Staff.Add(staff1);
            db.Staff.Add(staff2);
            db.Staff.Load();
            Staff = db.Staff.Local.ToObservableCollection();
        }

        private string login;
        public string Login {
            get { return login; }
            set { login = value; OnPropertyChanged(nameof(Login)); }
        }

        private string password;
        public string Password {
            get { return password; }
            set { password = value; OnPropertyChanged(nameof(Password)); }
        }

        /// <summary>
        /// Функция поиска сотрудника в БД.
        /// </summary>
        Staff? CorrectInformation(string login, string password) {
            if(login == null || password == null) { return null; }
            return Staff.FirstOrDefault(staff => staff.Login == login &&
                    staff.Password == password);
        }

        RelayCommand getAuth;
        public RelayCommand GetAuth {
            get {
                return getAuth ?? (getAuth = new RelayCommand(obj => {
                    Staff? foundedStaff = CorrectInformation(this.Login, this.Password);
                    if(foundedStaff == null) {
                        System.Windows.MessageBox.Show("Неверный логин или пароль!", "Внимание!", System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Warning);
                        return;
                    }
                    string role = foundedStaff.Role;
                    switch(role) {
                        case "ADM":
                            admWindow admWindow = new admWindow();
                            admWindow.Owner = System.Windows.Application.Current.MainWindow;
                            admWindow.ShowDialog();
                            break;
                        case "STF":
                            empWindow empWindow = new empWindow();
                            empWindow.Owner = System.Windows.Application.Current.MainWindow;
                            empWindow.ShowDialog();
                            break;
                    }

                }));
            }
        }
    }
}
