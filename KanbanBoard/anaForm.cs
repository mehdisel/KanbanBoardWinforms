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
    public partial class anaForm : Form
    {
        public anaForm()
        {
            InitializeComponent();
        }
        public formSayfaAdi ana;
        private void YeniFormEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {

            formSayfaAdi sayfaAdi = new formSayfaAdi();
            sayfaAdi.anaFrm = this;
            DialogResult gelen = sayfaAdi.ShowDialog();
            if (gelen == DialogResult.OK)
            {
                formBoard frmBoard = new formBoard();
                frmBoard.Text = sayfaAdi.formAdi;
                frmBoard.MdiParent = this;
                MenuYenile();
                frmBoard.Show();
                sayfaAdi.Hide();
            }
        }
        ToolStripMenuItem[] menuItem_;
        private void AnaForm_Load(object sender, EventArgs e)
        {
            MenuYenile();


        }

        private void MenuItemiTiklaninca(object sender, EventArgs e)
        {

            string tiklananMenuTagi = ((ToolStripMenuItem)sender).Tag.ToString();
            if (FormAciksaKilitle(tiklananMenuTagi) == true)
            {
                return;
            }
            else
            {

                ListeyiCek(tiklananMenuTagi);
            }

        }
        public void ListeyiCek(string klasorAdi)
        {
            formBoard frmBoard = new formBoard();
            frmBoard.ana = this;
            frmBoard.Text = klasorAdi;
            frmBoard.MdiParent = this;
            string[] todoList = Directory.GetFiles(Path.Combine(Directory.GetCurrentDirectory(), klasorAdi, "todo"));
            string[] doingList = Directory.GetFiles(Path.Combine(Directory.GetCurrentDirectory(), klasorAdi, "doing"));
            string[] doneList = Directory.GetFiles(Path.Combine(Directory.GetCurrentDirectory(), klasorAdi, "done"));
            foreach (string item in todoList)
            {
                string[] parcalanmis = item.Split('+', '.');
                frmBoard.NotYukle(Path.GetFileName(parcalanmis[0]), Path.GetFileName(parcalanmis[1]), "todo");

            }
            foreach (string item in doingList)
            {
                string[] parcalanmis = item.Split('+', '.');
                frmBoard.NotYukle(Path.GetFileName(parcalanmis[0]), Path.GetFileName(parcalanmis[1]), "doing");

            }
            foreach (string item in doneList)
            {
                string[] parcalanmis = item.Split('+', '.');
                frmBoard.NotYukle(Path.GetFileName(parcalanmis[0]), Path.GetFileName(parcalanmis[1]), "done");

            }
            frmBoard.Show();
        }
        private void Menu2ItemiTiklaninca(object sender, EventArgs e)
        {

            string yol = ((ToolStripMenuItem)sender).Tag.ToString();
            
            if (!FormAciksaSilme(yol))
            {

                if (!Directory.Exists(yol))
                {
                    MessageBox.Show("Silmek istediğiniz dizin mevcut değil.");
                    return;
                }
                else
                {

                    DialogResult dlg = MessageBox.Show("( "+yol+" )"+" tablosu silinsin mi? ", "Uyarı", MessageBoxButtons.YesNo);
                    if (dlg == DialogResult.No)
                    {
                        return;
                    }
                    else if (dlg == DialogResult.Yes)
                    {
                        Directory.Delete(yol, true);
                        MessageBox.Show("Tablo silindi");
                        MenuYenile();
                    }
                }
            }
            else
            {
                MessageBox.Show("Tablo açık olduğu için silme işlemi yapılamaz.Lütfen önce tabloyu kapatınız.");
            }
        }
        public bool FormAciksaKilitle(string gelenFormAdi)
        {

            foreach (Form item in this.MdiChildren)
            {
                if (item is Form)
                {
                    if (item.Text == gelenFormAdi)
                    {
                        item.BringToFront();

                        return true;
                    }

                }
            }
            return false;
        }
        public bool FormAciksaSilme(string gelenFormAdi)
        {

            foreach (Form item in this.MdiChildren)
            {
                if (item is Form)
                {
                    if (item.Text == gelenFormAdi)
                    {
                        //Form frm = item as Form;
                        //frm.Hide();
                        return true;
                    }

                }
            }
            return false;
        }
        private void MenuYenile()
        {
            menuForm.Items.Clear();
            ToolStripMenuItem formAc = new ToolStripMenuItem();
            formAc.Text = "Yeni Form";
            formAc.ForeColor = Color.Red;
            formAc.Click += new EventHandler(YeniFormEkleToolStripMenuItem_Click);
            menuForm.Items.Add(formAc);
            string[] klasorler = Directory.GetDirectories(Directory.GetCurrentDirectory());
            //Array.Sort(klasorler);
            menuItem_ = new ToolStripMenuItem[klasorler.Length];

            for (int i = 0; i < menuItem_.Length; i++)
            {

                try
                {
                    menuItem_[i] = new ToolStripMenuItem();
                    menuItem_[i].DropDownItems.Add("Tabloyu Aç");
                    menuItem_[i].DropDownItems.Add("Tabloyu Sil");
                    menuItem_[i].Name = Path.GetFileName(klasorler[i]);
                    menuItem_[i].Text = Path.GetFileName(klasorler[i]);
                    menuItem_[i].DropDownItems[0].Tag = Path.GetFileName(klasorler[i]);
                    menuItem_[i].DropDownItems[0].Click += new EventHandler(MenuItemiTiklaninca);
                    menuItem_[i].DropDownItems[1].Tag = Path.GetFileName(klasorler[i]);
                    menuItem_[i].DropDownItems[1].Click += new EventHandler(Menu2ItemiTiklaninca);
                    menuForm.Items.Add(menuItem_[i]);

                }
                catch (Exception)
                {

                    continue;
                }

            }
        }

    }
}
