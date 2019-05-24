using System;
using System.Collections.Generic;
using System.Text;

using System.ComponentModel;
using ProjetoInclude.Models;
using Xamarin.Forms;

namespace ProjetoInclude.ViewModels
{
    public class ResultadoViewModel : INotifyPropertyChanged
    {
        public Jogo Jogo { get; set; }
        public Command JogarNovamente { get; set; }

        public ResultadoViewModel()
        {
            Jogo = Armazenamento.Armazenamento.Jogo;
            JogarNovamente = new Command(JogarNovamenteAction);
        }
        private void JogarNovamenteAction()
        {
            App.Current.MainPage = new Views.Inicio();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string NameProperty)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(NameProperty));
            }
        }
    }
}
