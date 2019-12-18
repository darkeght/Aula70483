using SistemaControleEstoque.Controller;
using SistemaControleEstoque.Model;
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

namespace SistemaControleEstoque.View
{
    /// <summary>
    /// Lógica interna para CadastrarUsuario.xaml
    /// </summary>
    public partial class CadastrarUsuario : Window
    {
        public CadastrarUsuario()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(tbxSenha.Password != tbxConfirmar.Password)
            {
                MessageBox.Show("As senhas não conferem!");
                return;
            }

            new UsuarioController().CadastrarUsuario(new Usuario()
            {
                Login = tbxLogin.Text,
                Senha = tbxSenha.Password
            });

            DialogResult = true;
        }
    }
}
