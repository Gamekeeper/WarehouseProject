using System;
using System.Collections.ObjectModel;
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
    public class MerchendiseWindowViewModel : INotifyPropertyChanged
    {
        private Card addItem;

        public Card AddItem
        {
            get {
                return addItem; 
            }

            set { addItem = value; }
        }
      
        public Card AddItem1(MerchendiseWindowViewModel merch)
        {
            if (addItem == null)
            {
                addItem = new Card(merch);
            }
            return addItem;
        }

        public ICommand CreateCard
        {
            get { return new DelegateCommand(createCard); }
        }

        private void createCard()
        {

            if (addItem == null)
            {
                addItem = new Card();
                addItem.Show();
            }
            
        }

        private static List<Merchandise> _merchandise;

        public List<Merchandise> Merchandises
        {
            get {
                _merchandise = merchandises();
                return _merchandise; 
            }
            set {
                _merchandise = value;
                RaisePropertyChangedEvent("Merchandises");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChangedEvent(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

        private static List<Merchandise> merchandises()
        {
            var context = new WarehouseEntities();
            var listOfMerchandise = context.Merchandise.ToList();
            return listOfMerchandise;
        }

    }
}
