using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Warehouse.ViewModel;

namespace Warehouse.View
{
    /// <summary>
    /// Interaction logic for Card.xaml
    /// </summary>
    public partial class Card : Window
    {

        private MerchendiseWindowViewModel merchendise;
        public Card()
        {
            merchendise = (MerchendiseWindowViewModel)Application.Current.Resources["MerchendiseWindowViewModel"];
            CardViewModel cardViewModel = new CardViewModel();
            this.DataContext = cardViewModel;
            InitializeComponent();
        }
        public Card(MerchendiseWindowViewModel merchendiseWindow)
        {
            merchendise = merchendiseWindow;
            merchendiseWindow.AddItem = this;
            CardViewModel cardViewModel = new CardViewModel(merchendiseWindow);
            this.DataContext = cardViewModel;
            InitializeComponent();
        }

        private void Card_OnClosed(object sender, EventArgs e)
        {
            merchendise.AddItem = null;
        }
    }
}
