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
    
    public partial class View_send_goods: System.ComponentModel.INotifyPropertyChanged
    
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
        private decimal _Код_товара;
     public decimal Код_товара 
     { 
      get
      {
       return _Код_товара;
      } 
      set
      {
       if(_Код_товара != value)
       {
        _Код_товара = value;
        OnPropertyChanged("Код_товара");
       }
      }
     }
     
        private decimal _Кол_во_продано;
     public decimal Кол_во_продано 
     { 
      get
      {
       return _Кол_во_продано;
      } 
      set
      {
       if(_Кол_во_продано != value)
       {
        _Кол_во_продано = value;
        OnPropertyChanged("Кол_во_продано");
       }
      }
     }
     
        private decimal _Себестоимость;
     public decimal Себестоимость 
     { 
      get
      {
       return _Себестоимость;
      } 
      set
      {
       if(_Себестоимость != value)
       {
        _Себестоимость = value;
        OnPropertyChanged("Себестоимость");
       }
      }
     }
     
        private decimal _Наценка;
     public decimal Наценка 
     { 
      get
      {
       return _Наценка;
      } 
      set
      {
       if(_Наценка != value)
       {
        _Наценка = value;
        OnPropertyChanged("Наценка");
       }
      }
     }
     
        private Nullable<decimal> _Цена;
     public Nullable<decimal> Цена 
     { 
      get
      {
       return _Цена;
      } 
      set
      {
       if(_Цена != value)
       {
        _Цена = value;
        OnPropertyChanged("Цена");
       }
      }
     }
     
        private Nullable<System.DateTime> _Дата_продажи;
     public Nullable<System.DateTime> Дата_продажи 
     { 
      get
      {
       return _Дата_продажи;
      } 
      set
      {
       if(_Дата_продажи != value)
       {
        _Дата_продажи = value;
        OnPropertyChanged("Дата_продажи");
       }
      }
     }
     
        private decimal _Код_накладной;
     public decimal Код_накладной 
     { 
      get
      {
       return _Код_накладной;
      } 
      set
      {
       if(_Код_накладной != value)
       {
        _Код_накладной = value;
        OnPropertyChanged("Код_накладной");
       }
      }
     }
     
    }
}