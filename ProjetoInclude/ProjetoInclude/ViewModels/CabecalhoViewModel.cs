﻿using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ProjetoInclude.ViewModels
{
    public class CabecalhoViewModel
    {
        public Command Sair { get; set; }

        public CabecalhoViewModel()
        {
            Sair = new Command(SairAction);
        }
        private void SairAction()
        {
            App.Current.MainPage = new Views.Inicio();
        }
    }
}
