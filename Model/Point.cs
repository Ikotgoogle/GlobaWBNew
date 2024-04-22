using System.Collections.ObjectModel;

namespace GlobaWBNew.Model {
    public class Point : PropChange {
        private int id;
        public int Id {
            get { return id; }
            set { id = value; OnPropertyChanged(nameof(Id)); }
        }

        private string address;
        public string Address {
            get { return address; }
            set { address = value; OnPropertyChanged(nameof(Address)); }
        }

        private double rate;
        public double Rate {
            get { return rate; }
            set { rate = value; OnPropertyChanged(nameof(Rate)); }
        }

        private ObservableCollection<Staff> staff;
        public ObservableCollection<Staff> Staff {
            get { return staff; }
            set { staff = value; OnPropertyChanged(nameof(Staff)); }
        }

        private ObservableCollection<Order> orders;
        public ObservableCollection<Order>? Orders {
            get { return orders; }
            set { orders = value; OnPropertyChanged(nameof(Orders)); }
        }
    }
}
