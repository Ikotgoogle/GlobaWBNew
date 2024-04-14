using GlobaWBNew.ViewModel;
using System.Windows;

namespace GlobaWBNew {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            DataContext = new LoginVM();
        }
    }
}