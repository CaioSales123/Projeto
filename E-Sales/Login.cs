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
        
        //Efeitos Hover e Leave:
        private void lblSenha_MouseHover(object sender, EventArgs e)
        {
            lblSenha.ForeColor = System.Drawing.Color.DeepSkyBlue;
        }

        private void lblSenha_MouseLeave(object sender, EventArgs e)
        {
            lblSenha.ForeColor = System.Drawing.Color.White;
        }

        //Marca o usuário selecionado de azul:
        private void imgAdmin_Click(object sender, EventArgs e)
        {          
            selecionado = true;      
            lblSelecionado.Text = "Administrador";
            lblAdmin.ForeColor = System.Drawing.Color.DeepSkyBlue;
            lblGuest.ForeColor = System.Drawing.Color.White;
        }

        private void imgGuest_Click(object sender, EventArgs e)
        {
            selecionado = true;      
            lblSelecionado.Text = "Convidado";
            lblGuest.ForeColor = System.Drawing.Color.DeepSkyBlue;
            lblAdmin.ForeColor = System.Drawing.Color.White;

            txtSenha.Hide();
            chkLembrar.Hide();
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
                    if (ActiveForm.Height >= 477)
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
            this.Hide();
            (new Painel_Admin()).Show();
            
        }



        
    }
}
