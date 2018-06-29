using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Sales
{
    public partial class Login : MaterialSkin.Controls.MaterialForm
    {
        public Login()
        {
            InitializeComponent();
            // Criando um material theme manager e adicionando o formulário.
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            // Definindo um esquema de Cor para formulário com tom Azul:
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
            );

            //ALTURA INICIAL DO FORMULÁRIO DE LOGIN DEVE SER 244:             
        }

        //Variável para verificar se algum usuário foi selecionado e assim expandir o form:
        bool selecionado;
        string UsuarioSelecionado = "";

        //Marca o usuário selecionado de azul:
        private void imgAdmin_Click(object sender, EventArgs e)
        {          
            selecionado = true;
            UsuarioSelecionado = "Administrador";
            lblSelecionado.Text = "Usuário Selecionado: " + "Administrador";
            lblAdmin.ForeColor = System.Drawing.Color.DeepSkyBlue;
            lblGuest.ForeColor = System.Drawing.Color.White;

            //Exibe:
            txtSenha.Enabled = true;
            chkLembrar.Enabled = true;
        }

        private void imgGuest_Click(object sender, EventArgs e)
        {
            selecionado = true;
            UsuarioSelecionado = "Convidado";
            lblSelecionado.Text = "Usuário Selecionado: " + "Convidado";
            lblGuest.ForeColor = System.Drawing.Color.DeepSkyBlue;
            lblAdmin.ForeColor = System.Drawing.Color.White;

            //Esconde:
            txtSenha.Enabled = false;
            chkLembrar.Enabled = false;
        }

        //Timer para expandir form:
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (selecionado == true)
            {
                timer1.Start();
                try
                {
                    ActiveForm.Height += 5;
                    if (ActiveForm.Height >= 432)
                    {
                        //Parar Timer e Abrir Form de Login:
                        timer1.Stop();
                    }
                }
                catch (Exception)
                {
                    return;
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Se lblSelecionado for igual a "Administrador", exibirá o frm de Administrador:
            if (UsuarioSelecionado == "Administrador")
            {
                this.Hide();
                (new Painel_Admin()).Show();
            }
            else if (UsuarioSelecionado == "Convidado")
            {
                this.Hide();
                (new Painel_Convidado()).Show();
            }   
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
