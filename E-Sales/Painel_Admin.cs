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
using E_Sales.Code.ClienteBLL;

namespace E_Sales
{
    public partial class Painel_Admin : MaterialSkin.Controls.MaterialForm
    {
        public Painel_Admin()
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

        //Ao abrir:
        private void Painel_Admin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbsalesDataSet.dbsales' table. You can move, or remove it, as needed.
            this.dbsalesTableAdapter.Fill(this.dbsalesDataSet.dbsales);
           
            //Define fonte:
            groupBoxStatus.Font = new Font("Roboto", 12, FontStyle.Regular);
            
        }

        //Painel Adm:
        private void lblSair_MouseHover(object sender, EventArgs e)
        {
            lblSair.ForeColor = System.Drawing.Color.Black;
        }

        private void lblSair_MouseLeave(object sender, EventArgs e)
        {
            lblSair.ForeColor = System.Drawing.Color.White;
        }

        //ToolStrip - Sair:
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Exibe o formulário Sobre:
        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new Sobre()).Show();
        }

        //Limpa Campos:
        public void btnLimpar_Click(object sender, EventArgs e)
        {
            txtTelefone.Text = "";
            txtOrcamento.Text = "";
            txtProduto.Text = "";
            txtMarca.Text = "";
            txtSerie.Text = "";
            txtEndereco.Text = "";
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {


        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

        }
    }
}
