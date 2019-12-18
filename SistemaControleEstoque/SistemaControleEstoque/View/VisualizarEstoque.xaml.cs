using SistemaControleEstoque.Controller;
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
    /// Lógica interna para VisualizarEstoque.xaml
    /// </summary>
    public partial class VisualizarEstoque : Window
    {
        public VisualizarEstoque()
        {
            InitializeComponent();

            var estoque = Estoque.GetEstoques();
            var ususarios = Usuario.GetUsuarios();


            dataGrid.ItemsSource = 
                  //from indica que vamos criar uma variavel que neste caso "est"
                  //a palavra "in" indica de onde vem as informações que vai ficar gravadas em 
                  //estoque
                (from est in estoque
                                   //A palavra join indica que vamos juntar os dados 
                                   //logo após criamos a variavel usu que ira conter 
                                   //as informações de usuarios 
                                   join usu in ususarios 
                                   //A palavra on indica como vamos estar ligando essas duas 
                                   //informações,
                                   on 
                                   //Aqui realizamos o teste de DNA do ratinho e identificamos 
                                   //que o estoque é filho do usuario
                                   est.UsuarioCriacao equals usu.Id
                                   join usualt in ususarios on est.UsuarioAlteracao equals usualt.Id
                                   //Aqui definimos os campos que vamos mostrar em nosso datagrid
                                    select new
                                   {
                                       Produto = est.Produto,
                                       Quantidade = est.Quantidade,
                                       Valor = est.Valor.ToString("C"),
                                       UsuarioInc = usu.Login,
                                       UsuarioAlt = usualt.Login
                                       //o To List nos ajuda a mostrar as informações dentro do datagrid
                                    }).ToList();
        }

        EstoqueController Estoque = new EstoqueController();
        UsuarioController Usuario = new UsuarioController();
        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
