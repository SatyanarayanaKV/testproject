﻿using EducationalApp.ViewModel;
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
    public partial class LogInPage : ContentPage
    {
        public LogInPage()
        {
            InitializeComponent();

            LogInViewModel vm = new LogInViewModel(Navigation);
            BindingContext = vm;

            vm.DisplayAleartPromt += (string Message) => DisplayAlert("Alert", Message, "Ok");

        }
    }
}