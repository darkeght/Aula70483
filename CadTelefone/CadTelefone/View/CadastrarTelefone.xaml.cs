using CadTelefone.Model;
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

namespace CadTelefone.View
{
    /// <summary>
    /// Lógica interna para CadastrarTelefone.xaml
    /// </summary>
    public partial class CadastrarTelefone : Window
    {
        public CadastrarTelefone()
        {
            InitializeComponent();
        }

        public Telefone tel { get; set; }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            tel = new Telefone()
            {
                Numero = tbxNumero.Text
            };

            DialogResult = true;
        }
    }
}
