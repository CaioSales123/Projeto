using E_Sales.Code.ClienteBLL;
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
    public partial class Painel_Convidado : MaterialSkin.Controls.MaterialForm
    {
        public Painel_Convidado()
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
        }

        bool PanelOn;

        private void Painel_Convidado_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbsalesDataSet.dbsales' table. You can move, or remove it, as needed.
            this.dbsalesTableAdapter.Fill(this.dbsalesDataSet.dbsales);

            panelLogado.Enabled = false;
            panelLogado.Visible = false;

        }

        //Botões:
        private void btnPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            
        }

        //Painel Guest:
        private void lblSair_MouseHover(object sender, EventArgs e)
        {
            lblSair.ForeColor = System.Drawing.Color.Black;
        }

        private void lblSair_MouseLeave(object sender, EventArgs e)
        {
            lblSair.ForeColor = System.Drawing.Color.White;
        }

        //Sobre:
        private void lblSobre_MouseHover(object sender, EventArgs e)
        {
            lblSobre.ForeColor = System.Drawing.Color.Black;
        }

        private void lblSobre_Click(object sender, EventArgs e)
        {
            //Ação click
            (new Sobre()).Show();
        }

        private void lblSobre_MouseLeave(object sender, EventArgs e)
        {
            lblSobre.ForeColor = System.Drawing.Color.White;
        }

        //Calculadora:
        private void lblCalc_MouseHover(object sender, EventArgs e)
        {
            lblCalc.ForeColor = System.Drawing.Color.Black;
        }

        private void lblCalc_Click(object sender, EventArgs e)
        {
            //Ação click
            System.Diagnostics.Process p = System.Diagnostics.Process.Start("calc.exe");
            p.WaitForInputIdle();
        }

        private void lblCalc_MouseLeave(object sender, EventArgs e)
        {
            lblCalc.ForeColor = System.Drawing.Color.White;
        }

        //Painel:
        private void picConv_Click_1(object sender, EventArgs e)
        {
            //Se a variável for true:
            if (PanelOn == true)
            {
                panelLogado.Enabled = false;
                panelLogado.Visible = false;
                panelLogado.Size = new Size(330, 180);
                PanelOn = false;
            }
            else
            {
                panelLogado.Enabled = true;
                panelLogado.Visible = true;
                lblSobre.ForeColor = System.Drawing.Color.White;
                lblCalc.ForeColor = System.Drawing.Color.White;
                PanelOn = true;
            }
        }      
    }
}
