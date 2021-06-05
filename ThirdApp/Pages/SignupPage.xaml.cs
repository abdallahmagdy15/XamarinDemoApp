using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ThirdApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignupPage : ContentPage
    {
        public SignupPage()
        {
            InitializeComponent();
            if (Device.RuntimePlatform.ToLower() == "android")
            {
                registerImg.Source = ImageSource.FromFile("android_register.png");
            }
            else if (Device.RuntimePlatform.ToLower() == "uwp")
            {
                registerImg.Source = ImageSource.FromFile("ThirdApp.Img.uwp_logo.png");
            }
            else if (Device.RuntimePlatform.ToLower() == "ios")
            {
                registerImg.Source = ImageSource.FromFile("ThirdApp.Img.ios_logo.jpg");
            }

            bgImg.Source= ImageSource.FromFile("bgg.jpg");
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(user_phone.Text) || String.IsNullOrEmpty(user_email.Text))
                DisplayAlert("Validation Error", "Please fill the required fields", "Ok");
            else
                DisplayAlert("User Details", $"Email :  {user_email.Text}\nPhone : {user_phone.Text}", "Ok");
        }
        private void nextbtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NewsPage());
        }
    }
}