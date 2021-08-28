using LoginMVVM.Models;
using LoginMVVM.Views;
using System.Windows.Input;
using Xamarin.Forms;

namespace LoginMVVM.ViewModels
{
    public class LoginViewModel
    {
        public User User { get; set; } = new User();
        public ICommand LoginCommand { get; }
        public ICommand RegisterCommand { get; }
        public LoginViewModel()
        {
            LoginCommand = new Command(OnLogin);
            RegisterCommand = new Command(OnRegister);
        }

        private async void OnLogin()
        {
            if (!string.IsNullOrEmpty(User.Email) && !string.IsNullOrEmpty(User.Password))
            {

                await App.Current.MainPage.DisplayAlert("", $"Bienvenido, {User.Email}!", "Ok");

                await App.Current.MainPage.Navigation.PushAsync(new HomePage());
            }
            else
            {
                await App.Current.MainPage.DisplayAlert("", "Campo Email y/o contraseña no puede estar vacío", "Ok");
            }
        }

        private async void OnRegister()
        {
            await App.Current.MainPage.Navigation.PushAsync(new SignUpPage());
        }
    }
}
