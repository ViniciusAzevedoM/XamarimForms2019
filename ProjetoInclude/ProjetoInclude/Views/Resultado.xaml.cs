﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjetoInclude.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Resultado : ContentPage
    {
        public Resultado()
        {
            InitializeComponent();

            BindingContext = new ViewModels.ResultadoViewModel();
        }
    }
}