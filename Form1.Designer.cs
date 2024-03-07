namespace U1_10
{
    partial class Form1
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
            this.data = new System.Windows.Forms.RichTextBox();
            this.enter = new System.Windows.Forms.Button();
            this.print = new System.Windows.Forms.Button();
            this.autoAge = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.autoKM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sortList = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.find = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.averageWork = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.aveWorkExpr = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.averageKM = new System.Windows.Forms.Button();
            this.aveKM = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // data
            // 
            this.data.BackColor = System.Drawing.Color.PeachPuff;
            this.data.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.data.Location = new System.Drawing.Point(12, 12);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(1368, 563);
            this.data.TabIndex = 0;
            this.data.Text = "Čia bus rodomi duomenys";
            // 
            // enter
            // 
            this.enter.BackColor = System.Drawing.Color.PeachPuff;
            this.enter.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.enter.Location = new System.Drawing.Point(1497, 12);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(279, 53);
            this.enter.TabIndex = 1;
            this.enter.Text = "Įvesti duomenis";
            this.enter.UseVisualStyleBackColor = false;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // print
            // 
            this.print.BackColor = System.Drawing.Color.PeachPuff;
            this.print.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.print.Location = new System.Drawing.Point(1497, 90);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(279, 53);
            this.print.TabIndex = 2;
            this.print.Text = "Spausdinti duomenis";
            this.print.UseVisualStyleBackColor = false;
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // autoAge
            // 
            this.autoAge.BackColor = System.Drawing.Color.PeachPuff;
            this.autoAge.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.autoAge.Location = new System.Drawing.Point(13, 737);
            this.autoAge.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.autoAge.Name = "autoAge";
            this.autoAge.Size = new System.Drawing.Size(159, 35);
            this.autoAge.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(8, 673);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(564, 26);
            this.label1.TabIndex = 12;
            this.label1.Text = "Įveskite, nuo kurių metų norite transporto priemonių:";
            // 
            // autoKM
            // 
            this.autoKM.BackColor = System.Drawing.Color.PeachPuff;
            this.autoKM.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.autoKM.Location = new System.Drawing.Point(1062, 737);
            this.autoKM.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.autoKM.Name = "autoKM";
            this.autoKM.Size = new System.Drawing.Size(159, 35);
            this.autoKM.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label2.Location = new System.Drawing.Point(1057, 673);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(735, 26);
            this.label2.TabIndex = 14;
            this.label2.Text = "Įveskite norimus, transporto priemonių, nuvažiuotus kilometrus(tūkst.)";
            // 
            // sortList
            // 
            this.sortList.BackColor = System.Drawing.Color.PeachPuff;
            this.sortList.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.sortList.Location = new System.Drawing.Point(659, 727);
            this.sortList.Name = "sortList";
            this.sortList.Size = new System.Drawing.Size(279, 53);
            this.sortList.TabIndex = 15;
            this.sortList.Text = "Surikiuoti sarašą";
            this.sortList.UseVisualStyleBackColor = false;
            this.sortList.Click += new System.EventHandler(this.sortList_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PeachPuff;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.button1.Location = new System.Drawing.Point(1497, 906);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(279, 53);
            this.button1.TabIndex = 16;
            this.button1.Text = "Baigti programą";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // find
            // 
            this.find.BackColor = System.Drawing.Color.PeachPuff;
            this.find.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.find.Location = new System.Drawing.Point(13, 792);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(279, 53);
            this.find.TabIndex = 17;
            this.find.Text = "Rasti";
            this.find.UseVisualStyleBackColor = false;
            this.find.Click += new System.EventHandler(this.find_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.PeachPuff;
            this.delete.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.delete.Location = new System.Drawing.Point(1062, 792);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(279, 53);
            this.delete.TabIndex = 18;
            this.delete.Text = "Ištrinti";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // averageWork
            // 
            this.averageWork.BackColor = System.Drawing.Color.PeachPuff;
            this.averageWork.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.averageWork.Location = new System.Drawing.Point(1497, 170);
            this.averageWork.Name = "averageWork";
            this.averageWork.Size = new System.Drawing.Size(279, 53);
            this.averageWork.TabIndex = 19;
            this.averageWork.Text = "Patyrę vairuotojai";
            this.averageWork.UseVisualStyleBackColor = false;
            this.averageWork.Click += new System.EventHandler(this.averageWork_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label3.Location = new System.Drawing.Point(1478, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(320, 26);
            this.label3.TabIndex = 20;
            this.label3.Text = "Labiausiai patyrę vairuotojai:";
            // 
            // aveWorkExpr
            // 
            this.aveWorkExpr.AutoSize = true;
            this.aveWorkExpr.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.aveWorkExpr.Location = new System.Drawing.Point(1386, 284);
            this.aveWorkExpr.Name = "aveWorkExpr";
            this.aveWorkExpr.Size = new System.Drawing.Size(0, 26);
            this.aveWorkExpr.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label4.Location = new System.Drawing.Point(1451, 480);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(405, 26);
            this.label4.TabIndex = 22;
            this.label4.Text = "Nuvažiuotų kilometrų vidurkis(tūkst.):";
            // 
            // averageKM
            // 
            this.averageKM.BackColor = System.Drawing.Color.PeachPuff;
            this.averageKM.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.averageKM.Location = new System.Drawing.Point(1497, 380);
            this.averageKM.Name = "averageKM";
            this.averageKM.Size = new System.Drawing.Size(279, 53);
            this.averageKM.TabIndex = 24;
            this.averageKM.Text = "Nuvažiuoti kilometrai";
            this.averageKM.UseVisualStyleBackColor = false;
            this.averageKM.Click += new System.EventHandler(this.averageKM_Click);
            // 
            // aveKM
            // 
            this.aveKM.AutoSize = true;
            this.aveKM.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.aveKM.Location = new System.Drawing.Point(1386, 521);
            this.aveKM.Name = "aveKM";
            this.aveKM.Size = new System.Drawing.Size(0, 26);
            this.aveKM.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1902, 983);
            this.Controls.Add(this.aveKM);
            this.Controls.Add(this.averageKM);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.aveWorkExpr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.averageWork);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.find);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sortList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.autoKM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.autoAge);
            this.Controls.Add(this.print);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.data);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Autobusų ir mikroautobusų parkų informacija";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox data;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.Button print;
        private System.Windows.Forms.TextBox autoAge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox autoKM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button sortList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button find;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button averageWork;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label aveWorkExpr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button averageKM;
        private System.Windows.Forms.Label aveKM;
    }
}

