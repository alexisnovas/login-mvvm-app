using LoginMVVM.Models;
using System.Windows.Input;
using Xamarin.Forms;

namespace LoginMVVM.ViewModels
{
    public class HomeViewModel
    {
        public MenuOption MenuOption1 { get;} = new MenuOption { Image = "https://d1nhio0ox7pgb.cloudfront.net/_img/g_collection_png/standard/256x256/hamburger.png", Title = "Bars & Hotels" };
        public MenuOption MenuOption2 { get;} = new MenuOption{Image = "https://d1nhio0ox7pgb.cloudfront.net/_img/g_collection_png/standard/256x256/hamburger.png", Title = "Fine Dining"}; 
        public MenuOption MenuOption3 { get; } = new MenuOption{Image = "https://d1nhio0ox7pgb.cloudfront.net/_img/g_collection_png/standard/256x256/hamburger.png", Title = "Cafes" };
        public MenuOption MenuOption4 { get; } = new MenuOption { Image = "https://d1nhio0ox7pgb.cloudfront.net/_img/g_collection_png/standard/256x256/hamburger.png", Title = "Nearby" };
        public MenuOption MenuOption5 { get; } = new MenuOption{Image = "https://d1nhio0ox7pgb.cloudfront.net/_img/g_collection_png/standard/256x256/hamburger.png", Title = "Fast Foods" };
        public MenuOption MenuOption6 { get; } = new MenuOption{Image = "https://d1nhio0ox7pgb.cloudfront.net/_img/g_collection_png/standard/256x256/hamburger.png", Title = "Featured Foods"};
    }
}
