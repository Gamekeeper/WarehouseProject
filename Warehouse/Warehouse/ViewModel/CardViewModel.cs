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
    public class CardViewModel
    {
        private MerchendiseWindowViewModel _merchendiseWindow;

        public CardViewModel()
        {

        }
        public CardViewModel(MerchendiseWindowViewModel merch)
        {
            _merchendiseWindow = merch;
        }
        public ICommand AddItem
        {
            get
            {
                return new DelegateCommand(addItem);
            }
        }

        public ICommand Exit
        {
            get 
            {
                return new DelegateCommand(exit);
            }
        }

        private void addItem()
        {
            var merchTable = (MerchendiseWindowViewModel)Application.Current.Resources["MerchendiseWindowViewModel"];
            if(
                Inspection.CheckString(merchTable.AddItem.Name.Text, 50) &&
                Inspection.CheckNumeric(merchTable.AddItem.txtConsignment.Text, 18, 0) &&
                Inspection.CheckNumeric(merchTable.AddItem.txtCountBooked.Text, 18, 0) &&
                Inspection.CheckNumeric(merchTable.AddItem.txtCountStored.Text, 18, 0) &&
                Inspection.CheckNumeric(merchTable.AddItem.txtCountOrder.Text, 18, 0) &&
                Inspection.CheckNumeric(merchTable.AddItem.txtCost.Text, 18, 2) &&
                Inspection.CheckNumeric(merchTable.AddItem.txtMargin.Text, 18, 2)
                )
            {

                var context = new WarehouseEntities();
                Merchandise n = new Merchandise()
               {
                   brand = merchTable.AddItem.Name.Text,
                   consignment = decimal.Parse(merchTable.AddItem.txtConsignment.Text),
                   arrived = merchTable.AddItem.chkArrived.IsEnabled,
                   count_booked = decimal.Parse(merchTable.AddItem.txtCountBooked.Text),
                   count_stored = decimal.Parse(merchTable.AddItem.txtCountStored.Text),
                   count_order = decimal.Parse(merchTable.AddItem.txtCountOrder.Text),
                   count_send = decimal.Parse(merchTable.AddItem.txtCountSend.Text),
                   specif_n = merchTable.AddItem.Descr.Text,
                   cost = decimal.Parse(merchTable.AddItem.txtCost.Text),
                   id_type = ((Types)merchTable.AddItem.comboType.SelectedValue).id_type,
                   margin = decimal.Parse(merchTable.AddItem.txtMargin.Text)
                };
               context.Merchandise.Add(n);            
               context.SaveChanges();   
               merchTable.Merchandises = context.Merchandise.ToList();
               MessageBox.Show("запись создана");
            }
            else 
            {
                MessageBox.Show("Некорректные данные!");
            }
        }

        private void exit() {
            var merchTable = (MerchendiseWindowViewModel)Application.Current.Resources["MerchendiseWindowViewModel"];
            merchTable.AddItem.Close();
        }

        public static List<Types> Types
        {
            get { return getTypes(); }
        }

        private static List<Types> getTypes()
        {
            var context = new WarehouseEntities();
            var listOfTypes = context.Types.ToList();
            return listOfTypes;
        }

    }
}
