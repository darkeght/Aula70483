using ListaDeCarrosClasse.Classes;
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

namespace ListaDeCarrosClasse
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            dataGrid.ItemsSource = Carros;
        }

        List<Carro> Carros = new List<Carro>
        {
            new Carro()
            {
                Modelo = "Gol Bola",
                Marca = "volkswagen",
                Ano = 1996
            },
            new Carro()
            {
                Modelo = "Gol Chaleira",
                Marca = "volkswagen",
                Ano = 1986
            },
            new Carro()
            {
                Modelo = "Fiat mobi",
                Marca = "Fiat",
                Ano = 2016
            }

        };
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Carros.Add(new Carro()
            {
                Modelo = tbxModelo.Text,
                Marca = tbxMarca.Text,
                Ano = int.Parse(tbxAno.Text)
            });

            dataGrid.ItemsSource = null;
            dataGrid.ItemsSource = Carros;
        }
    }
}
