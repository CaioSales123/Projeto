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
            ClienteBLL bll = new ClienteBLL();
            bll.LimparCampos(//Parametros
                             txtCliente, txtEndereco, txtMarca, txtOrcamento,
                             txtProduto, txtSearchId, txtSerie, txtTelefone);
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {


        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

        }

        //Status Trip:
        private void Painel_Admin_KeyDown(object sender, KeyEventArgs e)
        {
            lblStatus.Text = "Processando...";
        }

<<<<<<< HEAD
        //Painel de Logado:
        private void painelAdm_MouseEnter(object sender, EventArgs e)
        {
            panelLogado.Visible = true;
        }

        private void panelLogado_MouseLeave(object sender, EventArgs e)
        {
            
            panelLogado.Visible = false;
        }

        private void lblSobre_Click(object sender, EventArgs e)
        {

        }

        
=======
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            int rowindex = dataGridViewRecentes.CurrentCell.RowIndex;
            dataGridViewRecentes.Rows.RemoveAt(rowindex);
        }

        private void dataGridViewRecentes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridViewRecentes.Rows[e.RowIndex];

            txtCliente.Text = row.Cells[1].Value.ToString();
            txtEndereco.Text = row.Cells[2].Value.ToString();
            txtProduto.Text = row.Cells[3].Value.ToString();
            txtMarca.Text = row.Cells[4].Value.ToString();
            txtSerie.Text = row.Cells[5].Value.ToString();
            txtTelefone.Text = row.Cells[6].Value.ToString();
            richTextBoxDescricao.Text = row.Cells[8].Value.ToString();
        }
>>>>>>> 2dc43f556e1b69e65170f6359516d953863dd727
    }
}
