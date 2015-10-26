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
    /// Interaction logic for MakeOrder.xaml
    /// </summary>
    public partial class MakeOrder : Window
    {
        public MakeOrder()
        {
            MakeOrderViewModel makeOrderView = new MakeOrderViewModel();
            this.DataContext = makeOrderView;

            InitializeComponent();
        }

        private void MakeOrder_OnClosed(object sender, EventArgs e)
        {
            var makeorder_window = (OrderWindowViewModel)Application.Current.Resources["OrderWindowViewModel"];
            makeorder_window.exit();
        }
    }
}
