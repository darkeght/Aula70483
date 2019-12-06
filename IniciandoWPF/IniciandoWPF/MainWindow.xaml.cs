using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace IniciandoWPF
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            dataGrid.ItemsSource = ListaDenomes;
        }

        List<String> ListaDenomes = new List<String>
        {
            "Chael",
            "Rocneth",
            "Liamcyn",
            "Dicjohn",
            "Dahe",
            "Chellren",
            "Kimni",
            "Hadod",
            "Garnyahildi",
            "Reginisen",
            "Danmax",
            "Leysig",
            "Hesfastnath",
            "Jenba",
            "Marmaand",
            "Gorma",
            "Helm",
            "Isumlin",
            "Jenann",
            "Doegar"
        };
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            dataGrid.ItemsSource = null;

            switch (cbxFiltro.SelectedIndex)
            {
                case 0:
                    OrdernarLista();
                    break;
                case 1:
                    FiltraPorLetras(tbxFiltro.Text);
                    break;
                case 2:
                    OrdernarMaiorParaMenor();
                    break;
            }

        }

        private void OrdernarLista()
        {
            //Ordenamos de forma ascendente
            dataGrid.ItemsSource = ListaDenomes.OrderBy(x => x);
        }

        private void OrdernarMaiorParaMenor()
        {
            dataGrid.ItemsSource = ListaDenomes.OrderByDescending(x => x.Length);
        }

        private void FiltraPorLetras(string parametro)
        {
            dataGrid.ItemsSource = ListaDenomes.Where(x => x.Contains(parametro));
        }
    }
}
