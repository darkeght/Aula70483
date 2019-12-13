using CrudCompletoRegistroPessoa.Model;
using CrudCompletoRegistroPessoa.View;
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

namespace CrudCompletoRegistroPessoa
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            dataGrid.ItemsSource = context.Pessoas.ToList<Pessoa>();
        }

        public RegistroContext context = new RegistroContext();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DadosPessoa dados = new DadosPessoa();

            dados.ShowDialog();

            if (dados.DialogResult == true)
            {
                context.Pessoas.Add(dados.Pessoa);

                context.SaveChanges();
            }

            dataGrid.ItemsSource = null;
            dataGrid.ItemsSource = context.Pessoas.ToList<Pessoa>();
        }

        private void DataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //Obtemos a posição do item dentro do nosso data grid
            var index = ((System.Windows.Controls.Primitives.Selector)sender).SelectedIndex;

            DadosPessoa dados = new DadosPessoa();
            //Informamos nossa pessoa para ser editada em dadosPessoa
            dados.Pessoa = (Pessoa)dataGrid.Items[index];

            dados.ShowDialog();

            if (dados.DialogResult == true)
            {
                var pessoa = context.
                    Pessoas.
                    //Selecionamos a pessoa do nosso banco de dados 
                    FirstOrDefault(x => x.Id == dados.Pessoa.Id); 

                pessoa = dados.Pessoa;

                context.SaveChanges();
            }

            dataGrid.ItemsSource = null;
            dataGrid.ItemsSource = context.Pessoas.ToList<Pessoa>();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                var pessoa = (Pessoa)((System.Windows.FrameworkElement)sender).DataContext;
                var pessoaremover = context.Pessoas.FirstOrDefault(x => x.Id == pessoa.Id);

                context.Pessoas.Remove(pessoaremover);

                context.SaveChanges();

                dataGrid.ItemsSource = null;
                dataGrid.ItemsSource = context.Pessoas.ToList<Pessoa>();
            }
            catch
            {
                MessageBox.Show("Item não pode ser excluido");
            }
        }

        private void Grid_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

    }
}
