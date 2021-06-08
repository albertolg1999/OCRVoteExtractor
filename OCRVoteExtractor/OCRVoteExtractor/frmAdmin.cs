using Newtonsoft.Json;
using OCRVoteExtractor.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OCRVoteExtractor
{
    public partial class frmAdmin : Form
    {
        List<Usuario> lista;

        public frmAdmin()
        {
            //dgvUsuarios = new DataGridView();
            InitializeComponent();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            
        }

        private void administraciónUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                if (this.MdiChildren[0].Name != "frmAdminUsuarios")
                {
                    DialogResult rs = MessageBox.Show("¿Desea cerrar el formulario?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rs == DialogResult.Yes)
                    {
                        this.MdiChildren[0].Close();
                        frmAdminUsuarios frau = new frmAdminUsuarios();
                        frau.MdiParent = this;
                        frau.Dock = DockStyle.Fill;
                        frau.Show();

                    }
                }
            }
            else
            {
                
                frmAdminUsuarios frau = new frmAdminUsuarios();
                frau.MdiParent = this;
                frau.Dock = DockStyle.Fill;
                frau.Show();
            }
        }
    }
}
