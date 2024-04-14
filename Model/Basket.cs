namespace GlobaWBNew.Model {
    public class Basket : PropChange {
        private int _id;
        public int Id {
            get { return _id; }
            set { _id = value; OnPropertyChanged(nameof(Id)); }
        }

        private int _orderNum;
        public int OrderNum {
            get { return _orderNum; }
            set { _orderNum = value; OnPropertyChanged(nameof(OrderNum)); }
        }

        private Book _bookId;
        public Book BookId {
            get { return _bookId; }
            set { _bookId = value; OnPropertyChanged(nameof(BookId)); }
        }

        private Order _orders;
        public Order Orders {
            get { return _orders; }
            set { _orders = value; OnPropertyChanged(nameof(Orders)); }
        }
    }
}
