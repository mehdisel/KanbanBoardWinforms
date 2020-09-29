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
    public partial class formNot : Form
    {
        public formNot()
        {
            InitializeComponent();
        }
        public string girilenNot;
        public formBoard anaForm;
        private void BtnKaydet_Click(object sender, EventArgs e)
        {

            girilenNot = rtbNot.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void RtbNot_TextChanged(object sender, EventArgs e)
        {
            int suanKacKarakterYazildi = rtbNot.Text.Length;

            int kalanKarakter = 140 - suanKacKarakterYazildi;

            lblKalanKarakter.Text = kalanKarakter.ToString();
        }

        private void FormNot_Load(object sender, EventArgs e)
        {
            rtbNot.MaxLength = 140;
            lblKalanKarakter.Text = "140";
        }
    }
}
