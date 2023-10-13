using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkTrabalho
{
    public partial class formCrud : Form
    {
        public formCrud()
        {
            InitializeComponent();

            using (var context = new DataContext())
            {
                dataGridView1.DataSource = (from pessoa in context.pessoas select pessoa).ToList();
            }

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
            using (var frm = new formCadastro(id))
                frm.ShowDialog();

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var id = 0;
            using (var frm = new formCadastro(id))
                frm.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
            using (var frm = new formCadastro(id, "v"))
                frm.ShowDialog();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
            using (var frm = new formCadastro(id, "e"))
                frm.ShowDialog();
        }
    }
}
