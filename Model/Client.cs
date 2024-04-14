using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace GlobaWBNew.Model {
    public class Client : PropChange {
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

        private string _contactInfo;
        public string ContactInfo {
            get { return _contactInfo; }
            set { _contactInfo = value; OnPropertyChanged(nameof(ContactInfo)); }
        }

        private ObservableCollection<Order> _orders;
        public ObservableCollection<Order> Orders {
            get { return _orders; }
            set { _orders = value; OnPropertyChanged(nameof(Orders)); }
        }
    }
}
