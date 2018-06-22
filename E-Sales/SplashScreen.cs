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
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            InitializeComponent();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            try
            {
                rectangleShape2.Width += 5;                            
                if (rectangleShape2.Width >= 684)
                {
                    //Parar Timer e Abrir Form de Login:
                    Timer.Stop();

                    //Fechar SplashScreen:
                    this.Hide();

                    (new Login()).Show();
                }
                else 
                {
                    
                }
            }
            catch (Exception)
            { 
                return;
            }
            
        }
    }
}
