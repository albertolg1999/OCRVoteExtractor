using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OCRVoteExtractor
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            this.StartPosition=FormStartPosition.CenterScreen;
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            frmRegistro r = new frmRegistro();
            r.Show();
            this.Hide();
        }

        
    }
}
