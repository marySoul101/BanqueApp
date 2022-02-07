
namespace BanqueInter
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.adrBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.radioret = new System.Windows.Forms.RadioButton();
            this.radiodep = new System.Windows.Forms.RadioButton();
            this.radiotrn = new System.Windows.Forms.RadioButton();
            this.label7Transfert = new System.Windows.Forms.Label();
            this.labelTransfert = new System.Windows.Forms.Label();
            this.textBoxTransfert = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 24F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(29, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "BanqueApp";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.PeachPuff;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(12, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 30);
            this.label5.TabIndex = 10;
            this.label5.Text = "solde";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // adrBox
            // 
            this.adrBox.BackColor = System.Drawing.Color.PeachPuff;
            this.adrBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adrBox.ForeColor = System.Drawing.Color.MidnightBlue;
            this.adrBox.Location = new System.Drawing.Point(146, 211);
            this.adrBox.Multiline = true;
            this.adrBox.Name = "adrBox";
            this.adrBox.Size = new System.Drawing.Size(180, 30);
            this.adrBox.TabIndex = 11;
            this.adrBox.TextChanged += new System.EventHandler(this.adrBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Courier New", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(30, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(254, 31);
            this.label3.TabIndex = 12;
            this.label3.Text = "solde du compte";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Courier New", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(412, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(366, 31);
            this.label2.TabIndex = 13;
            this.label2.Text = "montant de l\'operation";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.PeachPuff;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.textBox1.Location = new System.Drawing.Point(571, 227);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 30);
            this.textBox1.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.PeachPuff;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(441, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 30);
            this.label4.TabIndex = 15;
            this.label4.Text = "montant";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PeachPuff;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button2.Location = new System.Drawing.Point(352, 368);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 30);
            this.button2.TabIndex = 17;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Courier New", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(412, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(318, 31);
            this.label6.TabIndex = 18;
            this.label6.Text = "type de l\'operation";
            // 
            // radioret
            // 
            this.radioret.BackColor = System.Drawing.Color.PeachPuff;
            this.radioret.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioret.ForeColor = System.Drawing.Color.MidnightBlue;
            this.radioret.Location = new System.Drawing.Point(396, 127);
            this.radioret.Name = "radioret";
            this.radioret.Size = new System.Drawing.Size(104, 30);
            this.radioret.TabIndex = 19;
            this.radioret.TabStop = true;
            this.radioret.Text = "retrait";
            this.radioret.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioret.UseVisualStyleBackColor = false;
            this.radioret.CheckedChanged += new System.EventHandler(this.radioret_CheckedChanged);
            // 
            // radiodep
            // 
            this.radiodep.BackColor = System.Drawing.Color.PeachPuff;
            this.radiodep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiodep.ForeColor = System.Drawing.Color.MidnightBlue;
            this.radiodep.Location = new System.Drawing.Point(529, 127);
            this.radiodep.Name = "radiodep";
            this.radiodep.Size = new System.Drawing.Size(104, 30);
            this.radiodep.TabIndex = 20;
            this.radiodep.TabStop = true;
            this.radiodep.Text = "dépot";
            this.radiodep.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radiodep.UseVisualStyleBackColor = false;
            this.radiodep.CheckedChanged += new System.EventHandler(this.radiodep_CheckedChanged_1);
            // 
            // radiotrn
            // 
            this.radiotrn.BackColor = System.Drawing.Color.PeachPuff;
            this.radiotrn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiotrn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.radiotrn.Location = new System.Drawing.Point(664, 127);
            this.radiotrn.Name = "radiotrn";
            this.radiotrn.Size = new System.Drawing.Size(104, 30);
            this.radiotrn.TabIndex = 21;
            this.radiotrn.TabStop = true;
            this.radiotrn.Text = "transfert";
            this.radiotrn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radiotrn.UseVisualStyleBackColor = false;
            this.radiotrn.CheckedChanged += new System.EventHandler(this.radiotrn_CheckedChanged);
            // 
            // label7Transfert
            // 
            this.label7Transfert.AutoSize = true;
            this.label7Transfert.BackColor = System.Drawing.Color.Transparent;
            this.label7Transfert.Font = new System.Drawing.Font("Courier New", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7Transfert.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7Transfert.Location = new System.Drawing.Point(460, 271);
            this.label7Transfert.Name = "label7Transfert";
            this.label7Transfert.Size = new System.Drawing.Size(270, 31);
            this.label7Transfert.TabIndex = 22;
            this.label7Transfert.Text = "numero du compte";
            // 
            // labelTransfert
            // 
            this.labelTransfert.BackColor = System.Drawing.Color.PeachPuff;
            this.labelTransfert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTransfert.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelTransfert.Location = new System.Drawing.Point(441, 317);
            this.labelTransfert.Name = "labelTransfert";
            this.labelTransfert.Size = new System.Drawing.Size(90, 30);
            this.labelTransfert.TabIndex = 23;
            this.labelTransfert.Text = "numero";
            this.labelTransfert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxTransfert
            // 
            this.textBoxTransfert.BackColor = System.Drawing.Color.PeachPuff;
            this.textBoxTransfert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTransfert.ForeColor = System.Drawing.Color.MidnightBlue;
            this.textBoxTransfert.Location = new System.Drawing.Point(571, 317);
            this.textBoxTransfert.Multiline = true;
            this.textBoxTransfert.Name = "textBoxTransfert";
            this.textBoxTransfert.Size = new System.Drawing.Size(180, 30);
            this.textBoxTransfert.TabIndex = 24;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BanqueInter.Properties.Resources.HD_wallpaper__digital_art__artwork__fantasy_art__planet__Sun__sunlight__nature;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxTransfert);
            this.Controls.Add(this.labelTransfert);
            this.Controls.Add(this.label7Transfert);
            this.Controls.Add(this.radiotrn);
            this.Controls.Add(this.radiodep);
            this.Controls.Add(this.radioret);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.adrBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "BanqueApp";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox adrBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioret;
        private System.Windows.Forms.RadioButton radiodep;
        private System.Windows.Forms.RadioButton radiotrn;
        private System.Windows.Forms.Label label7Transfert;
        private System.Windows.Forms.Label labelTransfert;
        private System.Windows.Forms.TextBox textBoxTransfert;
    }
}