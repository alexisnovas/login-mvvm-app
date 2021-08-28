using LoginMVVM.Models;
using LoginMVVM.Views;
using System.Windows.Input;
using Xamarin.Forms;

namespace LoginMVVM.ViewModels
{
    class SignUpViewModel
    {
        public User User { get; set; } = new User();
        public string ConfirmPassword { get; set; }
        public ICommand SignUpCommand { get; }
        public SignUpViewModel()
        {
            SignUpCommand = new Command(OnSignUp);
        }

        private async void OnSignUp()
        {
            if (!string.IsNullOrEmpty(User.Name) && !string.IsNullOrEmpty(User.Email)
                 && !string.IsNullOrEmpty(User.Password) && !string.IsNullOrEmpty(ConfirmPassword))
            {

                if (User.Password== ConfirmPassword)
                {
                    await App.Current.MainPage.DisplayAlert("Hola", $"Bienvenido, {User.Name}!", "Ok");

                    await App.Current.MainPage.Navigation.PushAsync(new HomePage());
                }
                else
                {
                    await App.Current.MainPage.DisplayAlert("Error", "Las contraseñas ingresadas no son iguales, favor introducirlas nuevamente", "Ok");
                }
            }
            else
            {
                await App.Current.MainPage.DisplayAlert("Error", "Faltan campos por llenar, favor compruebe y vuelva a intentar", "Ok");
            }
        }
    }
}
