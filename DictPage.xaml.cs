using EducationalApp.Model;
using EducationalApp.SQLite;
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
    public partial class DictPage : ContentPage
    {
        public DictPage()
        {
            InitializeComponent();

            DictViewModel dictVM = new DictViewModel();
            dictVM.DisplayAleartPromt += (string logInMessage) => DisplayAlert("Alert", logInMessage, "Ok");

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var deleteButton = sender as Button;
            var deleteItemList = deleteButton?.BindingContext as DictDataAccess;
            var vm = BindingContext as DictViewModel;
            vm?.RemoveItemCommand.Execute(deleteItemList);
        }

       
        
    }
}