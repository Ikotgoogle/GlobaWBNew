using System.Collections.ObjectModel;

namespace GlobaWBNew.Model {
    public class Book : PropChange {
        private int id;
        public int Id {
            get { return id; }
            set { id = value; OnPropertyChanged(nameof(Id)); }
        }

        private string title;
        public string Title {
            get { return title; }
            set { title = value; OnPropertyChanged(nameof(Title)); }
        }

        private string description;
        public string Description {
            get { return description; }
            set { description = value; OnPropertyChanged(nameof(Description)); }
        }

        private int price;
        public int Price {
            get { return price; }
            set {
                if(value >= 0) {
                    price = value; OnPropertyChanged(nameof(Price));
                }
            }
        }

        private int amount;
        public int Amount {
            get { return amount; }
            set { amount = value; OnPropertyChanged(nameof(Amount)); }
        }

        private double rate;
        public double Rate {
            get { return rate; }
            set {
                if(value >= 0 || value <= 5) {
                    rate = value; OnPropertyChanged(nameof(Rate));
                }
            }
        }

        private Seller? seller;
        public Seller? Seller {
            get { return seller; }
            set { seller = value; OnPropertyChanged(nameof(Seller)); }
        }

        private ObservableCollection<Basket> basket;
        public ObservableCollection<Basket> Basket {
            get { return basket; }
            set { basket = value; OnPropertyChanged(nameof(Basket)); }
        }

        public override string ToString() {
            return $"{Title}";
        }
    }
}
