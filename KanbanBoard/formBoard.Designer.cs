namespace KanbanBoard
{
    partial class formBoard
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDosyayiAc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(616, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 33);
            this.label6.TabIndex = 11;
            this.label6.Text = "Done";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(355, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 33);
            this.label5.TabIndex = 10;
            this.label5.Text = "Doing";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(72, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 33);
            this.label4.TabIndex = 9;
            this.label4.Text = "To Do";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(534, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 450);
            this.label3.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(260, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 450);
            this.label2.TabIndex = 7;
            this.label2.Text = "-";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(0, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(798, 10);
            this.label1.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(0, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(798, 10);
            this.label7.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 19);
            this.button1.TabIndex = 17;
            this.button1.Text = "Not Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.Location = new System.Drawing.Point(3, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 354);
            this.panel1.TabIndex = 19;
            this.panel1.Tag = "todo";
            this.panel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.Panel1_DragDrop);
            this.panel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel1_DragEnter);
            this.panel1.DragOver += new System.Windows.Forms.DragEventHandler(this.Panel1_DragOver);
            // 
            // panel2
            // 
            this.panel2.AllowDrop = true;
            this.panel2.Location = new System.Drawing.Point(279, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(249, 354);
            this.panel2.TabIndex = 20;
            this.panel2.Tag = "doing";
            this.panel2.DragDrop += new System.Windows.Forms.DragEventHandler(this.Panel1_DragDrop);
            this.panel2.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel1_DragEnter);
            this.panel2.DragOver += new System.Windows.Forms.DragEventHandler(this.Panel1_DragOver);
            // 
            // panel3
            // 
            this.panel3.AllowDrop = true;
            this.panel3.Location = new System.Drawing.Point(553, 88);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(245, 354);
            this.panel3.TabIndex = 20;
            this.panel3.Tag = "done";
            this.panel3.DragDrop += new System.Windows.Forms.DragEventHandler(this.Panel1_DragDrop);
            this.panel3.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel1_DragEnter);
            this.panel3.DragOver += new System.Windows.Forms.DragEventHandler(this.Panel1_DragOver);
            // 
            // btnDosyayiAc
            // 
            this.btnDosyayiAc.Location = new System.Drawing.Point(713, 0);
            this.btnDosyayiAc.Name = "btnDosyayiAc";
            this.btnDosyayiAc.Size = new System.Drawing.Size(75, 23);
            this.btnDosyayiAc.TabIndex = 21;
            this.btnDosyayiAc.Text = "Dosyayı Aç";
            this.btnDosyayiAc.UseVisualStyleBackColor = true;
            this.btnDosyayiAc.Click += new System.EventHandler(this.btnDosyayiAc_Click);
            // 
            // formBoard
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 445);
            this.Controls.Add(this.btnDosyayiAc);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Name = "formBoard";
            this.Text = "formBoard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDosyayiAc;
    }
}