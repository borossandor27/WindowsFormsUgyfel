
namespace WindowsFormsApp14
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox_Ugyfel = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_Orszag = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown_SzuletesiEv = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Iranyitoszam = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Nev = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_insert = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SzuletesiEv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Iranyitoszam)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_Ugyfel
            // 
            this.listBox_Ugyfel.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox_Ugyfel.FormattingEnabled = true;
            this.listBox_Ugyfel.Location = new System.Drawing.Point(0, 0);
            this.listBox_Ugyfel.Name = "listBox_Ugyfel";
            this.listBox_Ugyfel.Size = new System.Drawing.Size(225, 450);
            this.listBox_Ugyfel.TabIndex = 0;
            this.listBox_Ugyfel.SelectedIndexChanged += new System.EventHandler(this.listBox_Ugyfel_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_Orszag);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numericUpDown_SzuletesiEv);
            this.groupBox1.Controls.Add(this.numericUpDown_Iranyitoszam);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_Nev);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_id);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(300, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 261);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kiválasztott ügyfél adatai";
            // 
            // textBox_Orszag
            // 
            this.textBox_Orszag.Location = new System.Drawing.Point(140, 193);
            this.textBox_Orszag.Name = "textBox_Orszag";
            this.textBox_Orszag.Size = new System.Drawing.Size(100, 20);
            this.textBox_Orszag.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ország";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Születési év";
            // 
            // numericUpDown_SzuletesiEv
            // 
            this.numericUpDown_SzuletesiEv.Location = new System.Drawing.Point(140, 147);
            this.numericUpDown_SzuletesiEv.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown_SzuletesiEv.Name = "numericUpDown_SzuletesiEv";
            this.numericUpDown_SzuletesiEv.Size = new System.Drawing.Size(170, 20);
            this.numericUpDown_SzuletesiEv.TabIndex = 6;
            this.numericUpDown_SzuletesiEv.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDown_Iranyitoszam
            // 
            this.numericUpDown_Iranyitoszam.Location = new System.Drawing.Point(140, 105);
            this.numericUpDown_Iranyitoszam.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDown_Iranyitoszam.Name = "numericUpDown_Iranyitoszam";
            this.numericUpDown_Iranyitoszam.Size = new System.Drawing.Size(170, 20);
            this.numericUpDown_Iranyitoszam.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "irányítószám";
            // 
            // textBox_Nev
            // 
            this.textBox_Nev.Location = new System.Drawing.Point(140, 63);
            this.textBox_Nev.Name = "textBox_Nev";
            this.textBox_Nev.Size = new System.Drawing.Size(258, 20);
            this.textBox_Nev.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Név";
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(140, 25);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.ReadOnly = true;
            this.textBox_id.Size = new System.Drawing.Size(160, 20);
            this.textBox_id.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Azonosító";
            // 
            // button_insert
            // 
            this.button_insert.Location = new System.Drawing.Point(300, 332);
            this.button_insert.Name = "button_insert";
            this.button_insert.Size = new System.Drawing.Size(75, 23);
            this.button_insert.TabIndex = 2;
            this.button_insert.Text = "Új";
            this.button_insert.UseVisualStyleBackColor = true;
            this.button_insert.Click += new System.EventHandler(this.button_insert_Click);
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(493, 332);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(75, 23);
            this.button_update.TabIndex = 2;
            this.button_update.Text = "Módosít";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(686, 332);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(75, 23);
            this.button_delete.TabIndex = 2;
            this.button_delete.Text = "Törlés";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 450);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_insert);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox_Ugyfel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "MySQL adatbázisban az ugyfél adatainak a kezelése demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SzuletesiEv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Iranyitoszam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Ugyfel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown_SzuletesiEv;
        private System.Windows.Forms.NumericUpDown numericUpDown_Iranyitoszam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Nev;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Orszag;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_insert;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_delete;
    }
}

