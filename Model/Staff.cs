namespace GlobaWBNew.Model {
    public class Staff : PropChange {
        private int _id;
        public int Id {
            get { return _id; }
            set { _id = value; OnPropertyChanged(nameof(Id)); }
        }

        private string _fullName;
        public string FullName {
            get { return _fullName; }
            set { _fullName = value; OnPropertyChanged(nameof(FullName)); }
        }

        private string _post;
        public string Post {
            get { return _post; }
            set { _post = value; OnPropertyChanged(nameof(Post)); }
        }

        private int _salary;
        public int Salary {
            get { return _salary; }
            set { _salary = value; OnPropertyChanged(nameof(Salary)); }
        }

        private Point _point;
        public Point Point {
            get { return _point; }
            set { _point = value; OnPropertyChanged(nameof(Point)); }
        }

        private string _login;
        public string Login {
            get { return _login; }
            set { _login = value; OnPropertyChanged(nameof(Login)); }
        }
        private string _password;
        public string Password {
            get { return _password; }
            set { _password = value; OnPropertyChanged(nameof(Password)); }
        }
        private string _role;
        public string Role {
            get { return _role; }
            set { _role = value; OnPropertyChanged(nameof(Role)); }
        }
    }
}
