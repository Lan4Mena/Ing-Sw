using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Security
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        public string Login{get{return labelLogin.Text; }set{labelLogin.Text = value;}}

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                new FrmLogin(this).ShowDialog();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
