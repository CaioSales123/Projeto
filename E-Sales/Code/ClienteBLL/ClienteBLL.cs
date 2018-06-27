using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace E_Sales.Code.ClienteBLL
{
    class ClienteBLL
    {
        //Método de Limpar Campos:
        public void LimparCampos()
        {
            Painel_Admin ui = new Painel_Admin(); //instancia a classe UI
            ui.txtCliente.Text = "";
        }
    }

    
}
