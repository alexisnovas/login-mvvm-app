using LoginMVVM.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LoginMVVM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : TabbedPage
    {
        public LoginPage()
        {
            InitializeComponent();
            BindingContext = new LoginViewModel();
        }
    }
}