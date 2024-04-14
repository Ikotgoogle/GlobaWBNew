using System.Collections.ObjectModel;

namespace GlobaWBNew.Model {
    public class Order : PropChange {
        private int _id;
        public int Id {
            get { return _id; }
            set { _id = value; OnPropertyChanged(nameof(Id)); }
        }
        /// <summary>
        /// Дата и время заказа
        /// </summary>
        private DateTime _orderDay;
        public DateTime OrderDay {
            get { return _orderDay; }
            set { _orderDay = value; OnPropertyChanged(nameof(OrderDay)); }
        }

        private Client _client;
        public Client Client {
            get { return _client; }
            set { _client = value; OnPropertyChanged(nameof(Client)); }
        }

        private Point _point;
        public Point Point {
            get { return _point; }
            set { _point = value; OnPropertyChanged(nameof(Point)); }
        }

        private ObservableCollection<Basket> _baskets;
        public ObservableCollection<Basket> Baskets {
            get { return _baskets; }
            set { _baskets = value; OnPropertyChanged(nameof(Baskets)); }
        }
    }
}
