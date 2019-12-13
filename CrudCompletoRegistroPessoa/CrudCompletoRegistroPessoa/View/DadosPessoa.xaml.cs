using CrudCompletoRegistroPessoa.Model;
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
using System.Windows.Shapes;

namespace CrudCompletoRegistroPessoa.View
{
    /// <summary>
    /// Lógica interna para DadosPessoa.xaml
    /// </summary>
    public partial class DadosPessoa : Window
    {
        public DadosPessoa()
        {
            InitializeComponent();
        }

        public Pessoa Pessoa { get; set; }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Pessoa == null)
                Pessoa = new Pessoa();

            Pessoa.Nome = tbxNome.Text;
            Pessoa.Idade = int.Parse(tbxIdade.Text);
            Pessoa.DataNascimento = tbxNascimento.DisplayDate;

            DialogResult = true;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (Pessoa != null)
            {
                tbxNome.Text = Pessoa.Nome;
                tbxIdade.Text = Pessoa.Idade.ToString();
                tbxNascimento.SelectedDate = Pessoa.DataNascimento;
            }
        }
    }
}
