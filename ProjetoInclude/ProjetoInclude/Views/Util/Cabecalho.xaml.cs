using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjetoInclude.Views.Util
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Cabecalho : ContentView
    {
        public Cabecalho()
        {
            InitializeComponent();
            BindingContext = new ViewModels.CabecalhoViewModel();
        }

        public void SairEvento(object sender, EventArgs args)
        {
            var viewModel = (ViewModels.CabecalhoViewModel)this.BindingContext;

            if (viewModel.Sair.CanExecute(null))
            {
                viewModel.Sair.Execute(null);
            }
        }

    }
}