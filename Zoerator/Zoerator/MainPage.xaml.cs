using System.Collections.Generic;
using Xamarin.Forms;

namespace Zoerator
{
    public partial class MainPage : ContentPage
	{
        List<ListViewCategoria> Categorias;

		public MainPage()
		{
			InitializeComponent();
            InitialiseList();
		}

        private void InitialiseList()
        {
            Categorias = new List<ListViewCategoria>();

            Categorias.Add(new ListViewCategoria {
                Nome = "Corno",
                Conteudo = "O conor é bixo doido"
            });
            Categorias.Add(new ListViewCategoria
            {
                Nome = "bebados",
                Conteudo = "O bebado é bixo doido"
            });
            Categorias.Add(new ListViewCategoria
            {
                Nome = "Papagaio",
                Conteudo = "O papagaio é bixo doido"
            });
            Categorias.Add(new ListViewCategoria
            {
                Nome = "Português",
                Conteudo = "O português é bixo doido"
            });

            listaCategorias.ItemsSource = Categorias;
            listaCategorias.ItemTapped += listaCategoriasSelecionado;
        }

        private void listaCategoriasSelecionado(object sender, ItemTappedEventArgs e)
        {
            ListViewCategoria categoria = (ListViewCategoria)e.Item;
            Navigation.PushAsync(new PiadaConteudo(categoria));
        }
    }

    public class ListViewCategoria
    {
        public string Nome { get; set; }
        public string Conteudo { get; set; }
    }
}
