using System.Collections.ObjectModel;

namespace GlobaWBNew.Model {
    public class Seller : PropChange {
        private int id;
        public int Id {
            get { return id; }
            set { id = value; OnPropertyChanged(nameof(Id)); }
        }

        private string name;
        public string Name {
            get { return name; }
            set { name = value; OnPropertyChanged(nameof(Name)); }
        }

        private string contactInformation;
        public string ContactInformation {
            get { return contactInformation; }
            set { contactInformation = value; OnPropertyChanged(nameof(ContactInformation)); }
        }

        private ObservableCollection<Book> books;
        public ObservableCollection<Book> Books {
            get { return books; }
            set { books = value; OnPropertyChanged(nameof(Books)); }
        }
    }
}
