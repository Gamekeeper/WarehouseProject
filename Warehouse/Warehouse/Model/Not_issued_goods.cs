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
    
    public partial class Not_issued_goods: System.ComponentModel.INotifyPropertyChanged
    
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
     
        private decimal _id_merch;
     public decimal id_merch 
     { 
      get
      {
       return _id_merch;
      } 
      set
      {
       if(_id_merch != value)
       {
        _id_merch = value;
        OnPropertyChanged("id_merch");
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
     
        private string _brand;
     public string brand 
     { 
      get
      {
       return _brand;
      } 
      set
      {
       if(_brand != value)
       {
        _brand = value;
        OnPropertyChanged("brand");
       }
      }
     }
     
        private decimal _count;
     public decimal count 
     { 
      get
      {
       return _count;
      } 
      set
      {
       if(_count != value)
       {
        _count = value;
        OnPropertyChanged("count");
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
     
    }
}
