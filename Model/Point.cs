using System.Collections.ObjectModel;

namespace GlobaWBNew.Model {
    public class Point : PropChange {
        private int _id;
        public int Id {
            get { return _id; }
            set { _id = value; OnPropertyChanged(nameof(Id)); }
        }

        private string _address;
        public string Address {
            get { return _address; }
            set { _address = value; OnPropertyChanged(nameof(Address)); }
        }

        private double _rate {
            get { return _rate; }
            set { _rate = value; OnPropertyChanged(nameof(_rate)); }
        }

        private ObservableCollection<Staff> _staff;
        public ObservableCollection<Staff> Staff {
            get { return _staff; }
            set { _staff = value; OnPropertyChanged(nameof(Staff)); }
        }

        private ObservableCollection<Order> _orders;
        public ObservableCollection<Order>? Orders {
            get { return _orders; }
            set { _orders = value; OnPropertyChanged(nameof(Orders)); }
        }
    }
}
