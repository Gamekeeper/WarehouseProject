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
    
    public partial class Invoice: System.ComponentModel.INotifyPropertyChanged
    
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
        public Invoice()
        {
            this.Send = new HashSet<Send>();
            this.Users_inv = new HashSet<Users_inv>();
        }
    
        private decimal _id_invoice;
     public decimal id_invoice 
     { 
      get
      {
       return _id_invoice;
      } 
      set
      {
       if(_id_invoice != value)
       {
        _id_invoice = value;
        OnPropertyChanged("id_invoice");
       }
      }
     }
     
        private System.DateTime _data_get;
     public System.DateTime data_get 
     { 
      get
      {
       return _data_get;
      } 
      set
      {
       if(_data_get != value)
       {
        _data_get = value;
        OnPropertyChanged("data_get");
       }
      }
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
     
        private decimal _summ;
     public decimal summ 
     { 
      get
      {
       return _summ;
      } 
      set
      {
       if(_summ != value)
       {
        _summ = value;
        OnPropertyChanged("summ");
       }
      }
     }
     
        private bool _paid;
     public bool paid 
     { 
      get
      {
       return _paid;
      } 
      set
      {
       if(_paid != value)
       {
        _paid = value;
        OnPropertyChanged("paid");
       }
      }
     }
     
        private Nullable<System.DateTime> _data_paid;
     public Nullable<System.DateTime> data_paid 
     { 
      get
      {
       return _data_paid;
      } 
      set
      {
       if(_data_paid != value)
       {
        _data_paid = value;
        OnPropertyChanged("data_paid");
       }
      }
     }
     
        private bool _good_issue;
     public bool good_issue 
     { 
      get
      {
       return _good_issue;
      } 
      set
      {
       if(_good_issue != value)
       {
        _good_issue = value;
        OnPropertyChanged("good_issue");
       }
      }
     }
     
        private Nullable<System.DateTime> _data_issue;
     public Nullable<System.DateTime> data_issue 
     { 
      get
      {
       return _data_issue;
      } 
      set
      {
       if(_data_issue != value)
       {
        _data_issue = value;
        OnPropertyChanged("data_issue");
       }
      }
     }
     
    
        private Contractor _Contractor;
     public virtual Contractor Contractor 
     { 
      get
      {
       return _Contractor;
      } 
      set
      {
       if(_Contractor != value)
       {
        _Contractor = value;
        OnPropertyChanged("Contractor");
       }
      }
     }
     
        private ICollection<Send> _Send;
     public virtual ICollection<Send> Send 
     { 
      get
      {
       return _Send;
      } 
      set
      {
       if(_Send != value)
       {
        _Send = value;
        OnPropertyChanged("Send");
       }
      }
     }
     
        private ICollection<Users_inv> _Users_inv;
     public virtual ICollection<Users_inv> Users_inv 
     { 
      get
      {
       return _Users_inv;
      } 
      set
      {
       if(_Users_inv != value)
       {
        _Users_inv = value;
        OnPropertyChanged("Users_inv");
       }
      }
     }
     
    }
}
