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
    public partial class LatestNews : ContentView
    {
        public LatestNews()
        {
            InitializeComponent();
            title.Text = "United Airlines plans to add 15 Boom Supersonic jets to its fleet";
            subtitle.Text = "The carrier could end up buying a total of 35 planes from the startup.";
            desc.Text = "Boom Supersonic can now add United Airlines to its list of supporters. The carrier plans to purchase 15 of Boom's Overture planes once the aircraft meets its 'demanding safety, operating and requirements.' The agreement includes an option for United to buy an additional 35 craft for a total order of 50 jets. While Boom recently unveiled its XB-1 test plane and plans to fly it for the first time later this year, the company has yet to build a working passenger jet.";
        }
    }
}