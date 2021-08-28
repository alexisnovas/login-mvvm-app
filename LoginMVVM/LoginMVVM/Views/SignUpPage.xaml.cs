using LoginMVVM.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LoginMVVM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignUpPage : ContentPage
    {
        public SignUpPage()
        {
            InitializeComponent();
            BindingContext = new SignUpViewModel();
        }
    }
}