using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using DevExpress.Xpf.Bars;
using DevExpress.Xpf.Mvvm;
using DevExpress.XtraPrinting.Native;
using Warehouse.Model;
using Warehouse.View;
using Inspection_methods;

namespace Warehouse.ViewModel
{
    class MakeOrderViewModel
    {
        public ICommand AddItem
        {
            get
            {
                return new DelegateCommand(addItem);
            }
        }

        private void addItem()
        {
            if (
                Inspection.CheckNumeric( OrderWindowViewModel.AddItem.txtIdContractor.Text,18,0) &&
                Inspection.CheckNumeric(OrderWindowViewModel.AddItem.txtSumm.Text,18,2) &&
                Inspection.CheckDateTime(OrderWindowViewModel.AddItem.txtDateOrder.Text) &&
                Inspection.CheckDateTime(OrderWindowViewModel.AddItem.txtDateImport.Text)
                )
            {
                Order n = new Order()
                {
                    id_contractor = decimal.Parse(OrderWindowViewModel.AddItem.txtIdContractor.Text),
                    summ = decimal.Parse(OrderWindowViewModel.AddItem.txtSumm.Text),
                    date_order = DateTime.Parse(OrderWindowViewModel.AddItem.txtDateOrder.Text),
                    date_import = DateTime.Parse(OrderWindowViewModel.AddItem.txtDateImport.Text),
                    id_user = AdministratorWindowViewModel.Current_User.id
                };
                Order m;
                using (var context = new WarehouseEntities()) {
                    context.Order.Add(n);
                    context.SaveChanges();
                    m = context.Order.ToList().Last();
                    var orderTable = (OrderWindowViewModel)Application.Current.Resources["OrderWindowViewModel"];
                    orderTable.Orders = context.Order.ToList();
                }
                MessageBox.Show("Запись создана успешно.");

                MerchendiseWindowViewModel f = (MerchendiseWindowViewModel)Application.Current.Resources["MerchendiseWindowViewModel"];
                var carMerch = f.AddItem1(f);
                carMerch.txtConsignment.Text = m.consigment.ToString();
                carMerch.txtConsignment.IsEnabled = false;

                Card addmerch = carMerch;
                addmerch.Show();
            }
            else
            {
                MessageBox.Show("Некорректные данные!");
            }
        }

        public string CurrentUser
        {
            get { return getCurrentUser(); }
        }

        private static string getCurrentUser()
        {
            return AdministratorWindowViewModel.GetCurrentUser_fullname();
        }

        public ICommand Exit
        {
            get
            {
                return new DelegateCommand(exit);
            }
        }

        private void exit()
        {
            OrderWindowViewModel.AddItem.Close();
        }

    }
}
