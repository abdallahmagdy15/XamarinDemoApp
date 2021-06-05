using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ThirdApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrientationLayoutsPage : ContentPage
    {
        public OrientationLayoutsPage()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PopToRootAsync();
        }
    }
}