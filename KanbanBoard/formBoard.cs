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
using System.Diagnostics;

namespace KanbanBoard
{
    public partial class formBoard : Form
    {
        public formBoard()
        {
            InitializeComponent();
        }
        public anaForm ana;
        private void Button1_Click(object sender, EventArgs e)
        {
            formNot frmNot = new formNot();
            frmNot.anaForm = this;
            DialogResult gelen = frmNot.ShowDialog();
            EklenecekNot(frmNot.girilenNot, gelen);
        }
        public void NotYukle(string gid, string not,string list)
        {
            Label lblNot = new Label();
            lblNot.Text = not;
            lblNot.Tag = string.Format(gid + "+");
            lblNot.AutoSize = true;
            lblNot.BorderStyle = BorderStyle.FixedSingle;
            lblNot.MouseDown += new MouseEventHandler(Label_MouseDown);
            if (list == "todo")
            {
                lblNot.Top = EklencekYer(panel1);
                panel1.Controls.Add(lblNot);
            }
            if (list == "doing")
            {
                lblNot.Top = EklencekYer(panel2);
                panel2.Controls.Add(lblNot);
            }
            if (list == "done")
            {
                lblNot.Top = EklencekYer(panel3);
                panel3.Controls.Add(lblNot);
            }
           

        }
        private void EklenecekNot(string not, DialogResult dlg)
        {
            if (dlg == DialogResult.OK)
            {
                Label lblNot = new Label();
                Guid gd = Guid.NewGuid();
                lblNot.Text = not;
                lblNot.Tag = string.Format(gd + "+");
                lblNot.AutoSize = true;
                lblNot.BorderStyle = BorderStyle.FixedSingle;
                StreamWriter yazici = new StreamWriter(Directory.GetCurrentDirectory() + "\\" + this.Text + "\\todo\\" + lblNot.Tag + not + ".txt", true);
                yazici.Write("");
                yazici.Close();
                lblNot.MouseDown += new MouseEventHandler(Label_MouseDown);
                lblNot.Top = EklencekYer(panel1);
                panel1.Controls.Add(lblNot);
            }
        }
        private void TexteYaz(string not, string labelAdi)
        {
            StreamWriter yazici = new StreamWriter(Path.Combine(Directory.GetCurrentDirectory(), this.Text, tasimadanOncePanel, labelAdi + ".txt"));
            yazici.Write(not);
            yazici.Close();
        }
        private string TextiOku(string labelAdi)
        {
            StreamReader okuyucu = new StreamReader(Path.Combine(Directory.GetCurrentDirectory(), this.Text, tasimadanOncePanel, labelAdi + ".txt"));
            string okunan = okuyucu.ReadToEnd();
            okuyucu.Close();
            return okunan;

        }
        string tasimadanOncePanel;
        Panel tasimadanOncekiPanel;
        private void Label_MouseDown(object sender, MouseEventArgs e)
        {
            Label basilanLabel = (Label)sender;
            tasimadanOncePanel = ((Panel)basilanLabel.Parent).Tag.ToString();
            tasimadanOncekiPanel = (Panel)basilanLabel.Parent;
            if (e.Button == MouseButtons.Left)
            {

                basilanLabel.DoDragDrop(sender, DragDropEffects.Copy);
            }
            if (e.Button == MouseButtons.Right)
            {
                formLabelNotu frmLblNot = new formLabelNotu();
                frmLblNot.anaForm = this;
                frmLblNot.Text = basilanLabel.Text;
                frmLblNot.not = TextiOku(basilanLabel.Tag.ToString() + basilanLabel.Text);
                DialogResult dlg = frmLblNot.ShowDialog();
                if (dlg == DialogResult.OK)
                {
                    TexteYaz(frmLblNot.not, basilanLabel.Tag.ToString() + basilanLabel.Text);
                }
            }

        }
  
        private void Panel1_DragOver(object sender, DragEventArgs e)
        {

            e.Effect = DragDropEffects.All;

        }
        string dosyaninYolu;
        private void Panel1_DragDrop(object sender, DragEventArgs e)
        {

            Label lb = ((Label)e.Data.GetData(typeof(Label)));
            lb.Top = EklencekYer((Panel)sender);
            ((Panel)lb.Parent).Controls.Remove(lb);
            ((Panel)sender).Controls.Add(lb);
            Panel pnl = (Panel)sender;
            YenidenSirala(tasimadanOncekiPanel);
            dosyaninYolu = Path.Combine(Directory.GetCurrentDirectory(), this.Text, tasimadanOncePanel, lb.Tag + lb.Text + ".txt");
            //string.Format(Directory.GetCurrentDirectory() + "\\" + this.Text + "\\" + tasimadanOncePanel + "\\" + lb.Text + ".txt");
            string tasinacakYol = Path.Combine(Directory.GetCurrentDirectory(), this.Text, pnl.Tag.ToString(), lb.Tag + lb.Text + ".txt");
            //string.Format(Directory.GetCurrentDirectory() + "\\" + this.Text + pnl.Tag.ToString());
            File.Move(dosyaninYolu, tasinacakYol);

        }

        private int EklencekYer(Panel panelim,int kaldigiNokta=0)
        {
            int toplam = kaldigiNokta;
            foreach (Control item in panelim.Controls)
            {
                toplam += item.Height;
            }
            return toplam;
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            //Label lb = ((Label)e.Data.GetData(typeof(Label)));
            //lb.Top = EklencekYer((Panel)sender);
        }
        private void YenidenSirala(Panel panel)
        {
            int sayac = 0;
            foreach (var item in panel.Controls)
            {
                if (item is Label)
                {
                    Label lbl = item as Label;
                    lbl.Top = sayac*lbl.Height;
                    sayac++;
                }
            }
        }

        private void btnDosyayiAc_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", Path.Combine(Directory.GetCurrentDirectory(),this.Text));
        }
    }
}
