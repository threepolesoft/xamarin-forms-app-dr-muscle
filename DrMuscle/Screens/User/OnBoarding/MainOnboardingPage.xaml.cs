using DrMuscle.Screens.User.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DrMuscle.Screens.User.OnBoarding
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainOnboardingPage : CarouselPage
	{
		public MainOnboardingPage ()
		{
			InitializeComponent ();
            Children.Add(new Registration());
		}
	}
}