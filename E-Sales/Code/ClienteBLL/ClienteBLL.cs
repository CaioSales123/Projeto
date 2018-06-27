using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace E_Sales.Code.ClienteBLL
{
    class ClienteBLL
    {
        //Método de Limpar Campos:
        public void LimparCampos(//Parametros
                                 Label txtCliente, Label txtEndereco, 
                                 Label txtMarca, Label txtOrcamento,
                                 Label txtProduto, Label txtSearchId, 
                                 Label txtSerie, Label txtTelefone)
        {
            txtCliente.Text = "";
            txtEndereco.Text = "";
            txtMarca.Text = "";
            txtOrcamento.Text = "";
            txtProduto.Text = "";
            txtSearchId.Text = "";
            txtSerie.Text = "";
            txtTelefone.Text = "";
        }

        internal void LimparCampos(//Parametros
                                   MaterialSkin.Controls.MaterialSingleLineTextField txtCliente, 
                                   MaterialSkin.Controls.MaterialSingleLineTextField txtEndereco, 
                                   MaterialSkin.Controls.MaterialSingleLineTextField txtMarca, 
                                   MaterialSkin.Controls.MaterialSingleLineTextField txtOrcamento, 
                                   MaterialSkin.Controls.MaterialSingleLineTextField txtProduto, 
                                   MaterialSkin.Controls.MaterialSingleLineTextField txtSearchId, 
                                   MaterialSkin.Controls.MaterialSingleLineTextField txtSerie, 
                                   MaterialSkin.Controls.MaterialSingleLineTextField txtTelefone)
        {
            throw new NotImplementedException();
        }
    }

    
}
