using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Form.Resx;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Nendoroid
{
    /// <summary>
    /// mainPage : display want to search which part
    /// </summary>
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            //測試語系
            //https://developer.xamarin.com/guides/xamarin-forms/application-fundamentals/localization/
            TestLabel.Text = "Hello" + AppResources.test;
		}
	}
}
