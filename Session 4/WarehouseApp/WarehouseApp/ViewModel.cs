using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using GalaSoft.MvvmLight.Command;

namespace WarehouseApp
{
    public class AuthViewModel : INotifyPropertyChanged
    {
        private string _login;
        private string _password;
        private string _role;
        private int _employeeID; // Новое свойство
        private string _firstname; // Новое свойство
        private string _lastName; // Новое свойство
        private readonly AuthService _authService;

        public string Login
        {
            get => _login;
            set
            {
                _login = value;
                OnPropertyChanged(nameof(Login));
            }
        }

        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                OnPropertyChanged(nameof(Password));
            }
        }

        public string Role
        {
            get => _role;
            set
            {
                _role = value;
                OnPropertyChanged(nameof(Role));
            }
        }

        public int EmployeeID // Новое свойство
        {
            get => _employeeID;
            set
            {
                _employeeID = value;
                OnPropertyChanged(nameof(EmployeeID));
            }
        }

        public string Firstname // Новое свойство
        {
            get => _firstname;
            set
            {
                _firstname = value;
                OnPropertyChanged(nameof(Firstname));
            }
        }

        public string LastName // Новое свойство
        {
            get => _lastName;
            set
            {
                _lastName = value;
                OnPropertyChanged(nameof(LastName));
            }
        }

        public ICommand LoginCommand { get; }

        public AuthViewModel()
        {
            _authService = new AuthService();
            LoginCommand = new RelayCommand(async () => await LoginAsync());
        }

        private async Task LoginAsync()
        {
            // Теперь передаем все необходимые параметры
            var result = await _authService.LoginAsync(EmployeeID, Firstname, LastName, Login, Password, Login, Role);

            if (result != null)
            {
                Role = await _authService.GetUserRoleAsync(Login);
                MessageBox.Show("Вы успешно авторизованы!");
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль.");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
