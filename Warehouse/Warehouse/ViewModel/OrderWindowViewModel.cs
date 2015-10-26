using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using DevExpress.Xpf.Mvvm;
using Warehouse.Model;
using Warehouse.View;
using System.ComponentModel;

namespace Warehouse.ViewModel
{
    public class OrderWindowViewModel : INotifyPropertyChanged//public
    {
        private static MakeOrder addItem;

        public static MakeOrder AddItem
        {
            get { return addItem; }
        }

        public ICommand CreateOrder
        {
            get { return new DelegateCommand(createOrder); }
        }

        public ICommand Exit
        {
            get { return new DelegateCommand(exit); }
        }

        public   void exit()
        {
            addItem = null;
        }
        private void createOrder()
        {
            if (addItem == null)
            {
                addItem = new MakeOrder();
                addItem.Show();
            }
            
        }

        private static List<Order> _orders;

        public List<Order> Orders
        {
            get
            {
                _orders = orders();
                return _orders;
            }
            set
            {
                _orders = value;
                RaisePropertyChangedEvent("Orders");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChangedEvent(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

        private static List<Order> orders()
        {
            var context = new WarehouseEntities();
            return context.Order.ToList();
        }
    }
}
