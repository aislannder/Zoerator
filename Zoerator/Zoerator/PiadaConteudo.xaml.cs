using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Zoerator
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PiadaConteudo : ContentPage
	{
		public PiadaConteudo (ListViewCategoria conteudo)
		{
			InitializeComponent ();
            conteudoPiada.Text = conteudo.Conteudo;

		}
	}
}