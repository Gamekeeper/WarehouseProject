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
    
    public partial class View_margin: System.ComponentModel.INotifyPropertyChanged
    
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
     
        private string _Наименование;
     public string Наименование 
     { 
      get
      {
       return _Наименование;
      } 
      set
      {
       if(_Наименование != value)
       {
        _Наименование = value;
        OnPropertyChanged("Наименование");
       }
      }
     }
     
        private decimal _Кол_во_заказано;
     public decimal Кол_во_заказано 
     { 
      get
      {
       return _Кол_во_заказано;
      } 
      set
      {
       if(_Кол_во_заказано != value)
       {
        _Кол_во_заказано = value;
        OnPropertyChanged("Кол_во_заказано");
       }
      }
     }
     
        private decimal _Кол_во_хранится;
     public decimal Кол_во_хранится 
     { 
      get
      {
       return _Кол_во_хранится;
      } 
      set
      {
       if(_Кол_во_хранится != value)
       {
        _Кол_во_хранится = value;
        OnPropertyChanged("Кол_во_хранится");
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
     
        private decimal _Маржа;
     public decimal Маржа 
     { 
      get
      {
       return _Маржа;
      } 
      set
      {
       if(_Маржа != value)
       {
        _Маржа = value;
        OnPropertyChanged("Маржа");
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
     
        private bool _Прибыл____;
     public bool Прибыл____ 
     { 
      get
      {
       return _Прибыл____;
      } 
      set
      {
       if(_Прибыл____ != value)
       {
        _Прибыл____ = value;
        OnPropertyChanged("Прибыл____");
       }
      }
     }
     
        private decimal _C__партии;
     public decimal C__партии 
     { 
      get
      {
       return _C__партии;
      } 
      set
      {
       if(_C__партии != value)
       {
        _C__партии = value;
        OnPropertyChanged("C__партии");
       }
      }
     }
     
    }
}