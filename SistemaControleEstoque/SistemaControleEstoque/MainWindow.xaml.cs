using SistemaControleEstoque.Controller;
using SistemaControleEstoque.View;
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

namespace SistemaControleEstoque
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        UsuarioController usuario = new UsuarioController();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (usuario.VerificaUsuarioExiste(tbxUsuario.Text, tbxSenha.Password))
            {
                MessageBox.Show("Usuario logado com sucesso!");

                new VisualizarEstoque().Show();

                this.Close();
            }
            else
                if (MessageBox.Show("Usuário inválido, deseja cadastrar um novo usuário?"
                    , "Usuário"
                    , MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                new CadastrarUsuario().ShowDialog();
            }
        }
    }
}
