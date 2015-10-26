//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Warehouse.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Contractor: System.ComponentModel.INotifyPropertyChanged
    
    {
    #region Implement INotifyPropertyChanged
     
     public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
     
     protected virtual void OnPropertyChanged(string propertyName)
     {
      if (PropertyChanged != null)
      {
       PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
      }
     }
     
     #endregion
        public Contractor()
        {
            this.Invoice = new HashSet<Invoice>();
            this.Order = new HashSet<Order>();
        }
    
        private decimal _id_contractor;
     public decimal id_contractor 
     { 
      get
      {
       return _id_contractor;
      } 
      set
      {
       if(_id_contractor != value)
       {
        _id_contractor = value;
        OnPropertyChanged("id_contractor");
       }
      }
     }
     
        private string _leg_adress;
     public string leg_adress 
     { 
      get
      {
       return _leg_adress;
      } 
      set
      {
       if(_leg_adress != value)
       {
        _leg_adress = value;
        OnPropertyChanged("leg_adress");
       }
      }
     }
     
        private string _actual_adress;
     public string actual_adress 
     { 
      get
      {
       return _actual_adress;
      } 
      set
      {
       if(_actual_adress != value)
       {
        _actual_adress = value;
        OnPropertyChanged("actual_adress");
       }
      }
     }
     
        private string _phones;
     public string phones 
     { 
      get
      {
       return _phones;
      } 
      set
      {
       if(_phones != value)
       {
        _phones = value;
        OnPropertyChanged("phones");
       }
      }
     }
     
        private decimal _inn;
     public decimal inn 
     { 
      get
      {
       return _inn;
      } 
      set
      {
       if(_inn != value)
       {
        _inn = value;
        OnPropertyChanged("inn");
       }
      }
     }
     
        private string _family;
     public string family 
     { 
      get
      {
       return _family;
      } 
      set
      {
       if(_family != value)
       {
        _family = value;
        OnPropertyChanged("family");
       }
      }
     }
     
        private string _name;
     public string name 
     { 
      get
      {
       return _name;
      } 
      set
      {
       if(_name != value)
       {
        _name = value;
        OnPropertyChanged("name");
       }
      }
     }
     
        private string _patronymic;
     public string patronymic 
     { 
      get
      {
       return _patronymic;
      } 
      set
      {
       if(_patronymic != value)
       {
        _patronymic = value;
        OnPropertyChanged("patronymic");
       }
      }
     }
     
        private Nullable<decimal> _bank_ac;
     public Nullable<decimal> bank_ac 
     { 
      get
      {
       return _bank_ac;
      } 
      set
      {
       if(_bank_ac != value)
       {
        _bank_ac = value;
        OnPropertyChanged("bank_ac");
       }
      }
     }
     
        private Nullable<decimal> _id_firm;
     public Nullable<decimal> id_firm 
     { 
      get
      {
       return _id_firm;
      } 
      set
      {
       if(_id_firm != value)
       {
        _id_firm = value;
        OnPropertyChanged("id_firm");
       }
      }
     }
     
    
        private Firm _Firm;
     public virtual Firm Firm 
     { 
      get
      {
       return _Firm;
      } 
      set
      {
       if(_Firm != value)
       {
        _Firm = value;
        OnPropertyChanged("Firm");
       }
      }
     }
     
        private ICollection<Invoice> _Invoice;
     public virtual ICollection<Invoice> Invoice 
     { 
      get
      {
       return _Invoice;
      } 
      set
      {
       if(_Invoice != value)
       {
        _Invoice = value;
        OnPropertyChanged("Invoice");
       }
      }
     }
     
        private ICollection<Order> _Order;
     public virtual ICollection<Order> Order 
     { 
      get
      {
       return _Order;
      } 
      set
      {
       if(_Order != value)
       {
        _Order = value;
        OnPropertyChanged("Order");
       }
      }
     }
     
    }
}