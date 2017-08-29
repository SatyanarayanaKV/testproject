using EducationalApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EducationalApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EnrollPage : ContentPage
    {
        public EnrollPage()
        {
            InitializeComponent();

            EnrollViewModel vm =new EnrollViewModel(Navigation);
            BindingContext = vm;

            vm.DisplayAleartPromt += (string Message) => DisplayAlert("Alert", Message, "Ok");


        }
    }
}