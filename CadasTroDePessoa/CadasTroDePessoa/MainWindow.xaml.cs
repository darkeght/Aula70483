using CadasTroDePessoa.Model;
using CadasTroDePessoa.View;
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

namespace CadasTroDePessoa
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
            dataGrid.ItemsSource = Context.Pessoas.ToList<Pessoa>();
        }

        CadastroContext Context = new CadastroContext();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CadastroPessoa cadastroPessoa = new CadastroPessoa();

            cadastroPessoa.ShowDialog();

            Context.Pessoas.Add(cadastroPessoa.Pessoa);
            Context.SaveChanges();

            dataGrid.ItemsSource = null;
            dataGrid.ItemsSource = Context.Pessoas.ToList<Pessoa>();
        }
    }
}
