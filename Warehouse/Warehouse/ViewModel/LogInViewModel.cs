using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using Warehouse.Model;
using Warehouse.View;

namespace Warehouse.ViewModel
{
    class LogInViewModel
    {
        public ICommand LogIn
        {
            get
            {
                return new DelegateCommand(logIn);
            }
        }
        public ICommand Exit
        {
            get
            {
                return new DelegateCommand(Application.Current.MainWindow.Close);
            }
        }

        private static List<User_Inf> getUsers()
        {

            var contex = new WarehouseEntities();
            var users = contex.User_Inf.ToList();
            return users;
        }

        private void logIn()
        {        
            var users = getUsers();
            var user = users.SingleOrDefault(x => x.login == ((LogIn)Application.Current.MainWindow).txtLogIn.Text
                && x.password == ((LogIn)Application.Current.MainWindow).txtPass.Password);
            if (user != null)
            {
                MessageBox.Show
                    ("Логин: " + user.login + "\nИмя: " + user.Users.family.Trim() + " " + user.Users.name.Trim() + " " + user.Users.patronymic.Trim() + " " + "\nДолжность: " + user.Users.Role.name);
                AdministratorWindow adm = new AdministratorWindow(user.id_user, user.login, user.Users.family, user.Users.name, user.Users.patronymic); 
                Application.Current.MainWindow.Close();
                adm.Show();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль."); 
            }
        }

    }
}
