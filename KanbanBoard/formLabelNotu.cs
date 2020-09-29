using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KanbanBoard
{
    public partial class formLabelNotu : Form
    {
        public formLabelNotu()
        {
            InitializeComponent();
        }
        public formBoard anaForm;
        public string not;
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            not = rchGirilenNot.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void formLabelNotu_Load(object sender, EventArgs e)
        {
            rchGirilenNot.Text = not;
            rchGirilenNot.Select(rchGirilenNot.Text.Length, 0);
        }
    }
}
