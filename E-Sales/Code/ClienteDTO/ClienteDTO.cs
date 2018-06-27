using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Sales.Code.ClienteDTO
{
    public class ClienteDTO
    {
         int _id; 
         String _cliente;
         String _telefone;
         String _orcamento;

         String _produto;
         String _marca;
         String _numeroSerie;

         String _endereco;                          
         String _descricao;
         String _status;
        
         //Captura o ID:
         public int Id
         {
             get { return _id; }
             set { _id = value; }
         }

         //Captura o nome do Cliente:
         public String Cliente
         {
             get { return _cliente; }
             set { _cliente = value; }
         }

         //Captura o Telefone:
         public String Telefone
         {
             get { return _telefone; }
             set { _telefone = value; }
         }

         //Captura o Orçamento:
         public String Orcamento
         {
             get { return _orcamento; }
             set { _orcamento = value; }
         }

         //Captura o Produto:
         public String Produto
         {
             get { return _produto; }
             set { _produto = value; }
         }

         //Captura a Marca:
         public String Marca
         {
             get { return _marca; }
             set { _marca = value; }
         }

         //Captura o Número de Série:
         public String Serie
         {
             get { return _numeroSerie; }
             set { _numeroSerie = value; }
         }

         //Captura o Endereço:
        public String Endereco { 
            get { return _endereco; } 
            set { _endereco = value; } 
        }

        //Captura a Descrição:
        public String DEscricao
        {
            get { return _descricao; }
            set { _descricao = value; }
        }

        //Captura o Status:
        public String Status { 
            get { return _status; } 
            set { _status = value; }
        }         
    }
}
