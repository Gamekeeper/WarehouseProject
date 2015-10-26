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
    /// Interaction logic for AdministratorWindow.xaml
    /// </summary>
    public partial class AdministratorWindow : Window
    {
        public AdministratorWindow()
        {
            InitializeComponent();
        }
        public AdministratorWindow(decimal x, string log, string f, string name, string p)
        {
            
            AdministratorWindowViewModel.Current_User.id = x;
            AdministratorWindowViewModel.Current_User.login = log.Trim();
            AdministratorWindowViewModel.Current_User.name = name.Trim();
            AdministratorWindowViewModel.Current_User.family = f.Trim();
            AdministratorWindowViewModel.Current_User.patronymic = p.Trim();
            InitializeComponent();
        }
        private void AdministratorWindow_OnClosed(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
