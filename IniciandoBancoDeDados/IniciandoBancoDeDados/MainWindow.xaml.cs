using IniciandoBancoDeDados.Model;
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

namespace IniciandoBancoDeDados
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            dataGrid.ItemsSource = null;
            dataGrid.ItemsSource = Context.Bebidas.ToList<Bebida>();
        }

        IniciandoContext Context = new IniciandoContext();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Context.Bebidas.Add(new Bebida()
            {
                Nome = "Skol",
                Teor = 4.5M,
                Ml = 250,
                Valor = 2.45M
            });

            Context.SaveChanges();

            dataGrid.ItemsSource = null;
            dataGrid.ItemsSource = Context.Bebidas.ToList<Bebida>();
        }
    }
}
