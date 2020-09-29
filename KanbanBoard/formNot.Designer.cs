namespace KanbanBoard
{
    partial class formNot
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtbNot = new System.Windows.Forms.RichTextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblKalanKarakter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtbNot
            // 
            this.rtbNot.Location = new System.Drawing.Point(5, 34);
            this.rtbNot.Name = "rtbNot";
            this.rtbNot.Size = new System.Drawing.Size(366, 113);
            this.rtbNot.TabIndex = 0;
            this.rtbNot.Text = "";
            this.rtbNot.TextChanged += new System.EventHandler(this.RtbNot_TextChanged);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(294, 153);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 34);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-1, -2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 33);
            this.label4.TabIndex = 10;
            this.label4.Text = "Notu yazın:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 33);
            this.label1.TabIndex = 11;
            this.label1.Text = "Kalan Karakter:";
            // 
            // lblKalanKarakter
            // 
            this.lblKalanKarakter.AutoSize = true;
            this.lblKalanKarakter.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKalanKarakter.Location = new System.Drawing.Point(242, 154);
            this.lblKalanKarakter.Name = "lblKalanKarakter";
            this.lblKalanKarakter.Size = new System.Drawing.Size(24, 33);
            this.lblKalanKarakter.TabIndex = 12;
            this.lblKalanKarakter.Text = " ";
            // 
            // formNot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 198);
            this.Controls.Add(this.lblKalanKarakter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.rtbNot);
            this.Name = "formNot";
            this.Text = "formNot";
            this.Load += new System.EventHandler(this.FormNot_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbNot;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblKalanKarakter;
    }
}