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

        private void Painel_Convidado_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbsalesDataSet.dbsales' table. You can move, or remove it, as needed.
            this.dbsalesTableAdapter.Fill(this.dbsalesDataSet.dbsales);

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            
        }

        private void txtSearchId_KeyDown(object sender, KeyEventArgs e)
        {
            lblStatus.Text = "Processando...";
        }
    }
}
