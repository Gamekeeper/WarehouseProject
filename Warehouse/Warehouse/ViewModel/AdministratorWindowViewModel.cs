using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Warehouse.Model;
using Warehouse.View;


namespace Warehouse.ViewModel
{
    public class AdministratorWindowViewModel
    {      
          
        public static string CurrentUser
        {
            get { return ("Пользователь: " + GetCurrentUser_log()); }
            
        }     

        public struct Current_User
        {
            public static decimal id;
            public static string login;
            public static string name;
            public static string family;
            public static string patronymic;
        }

        public static void SetCurrentUser(decimal x, string log, string f, string name, string p)
        {
            Current_User.id=x;
            Current_User.login = log.Trim();
            Current_User.name = name.Trim();
            Current_User.family = f.Trim();
            Current_User.patronymic = p.Trim();
        }


        public static decimal GetCurrentUser_id()
        {
            return Current_User.id;
        }

        public static string GetCurrentUser_fullname()
        {
            return (Current_User.family + " " + Current_User.name + " " + Current_User.patronymic);
        }

        public static string GetCurrentUser_log()
        {
            return (Current_User.login);
        }
    }
}
