using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace KanbanBoard
{
    public partial class formSayfaAdi : Form
    {
        public formSayfaAdi()
        {
            InitializeComponent();
        }
        public anaForm anaFrm;
        public string formAdi;
        public string yol;
        private void BtnSayfaAc_Click(object sender, EventArgs e)
        {
            string[] bosluksuz=txtSayfaAdi.Text.Split(' ');
            foreach (string item in bosluksuz)
            {
                yol += item;
            }
            
            
            if (Directory.Exists(yol))
            {
                //okuma yap
                
                DialogResult dlg= MessageBox.Show("Böyle bir tablo zaten var. Tablo yüklensin mi ? ","Uyarı",MessageBoxButtons.YesNo);
                if (dlg==DialogResult.No)
                {
                    yol = "";
                    return;
                }
                else if (dlg == DialogResult.Yes)
                {
                    anaFrm.ana = this;
                    anaFrm.ListeyiCek(yol);
                    this.Hide();

                }
                
            }
            else if (!string.IsNullOrEmpty(txtSayfaAdi.Text))
            {
                Directory.CreateDirectory(string.Format(yol + "\\todo"));
                Directory.CreateDirectory(string.Format(yol + "\\doing"));
                Directory.CreateDirectory(string.Format(yol + "\\done"));
                MessageBox.Show("Tablo oluşturuldu");
                formAdi = yol;
                this.DialogResult = DialogResult.OK;
            }


        }
    }
}
