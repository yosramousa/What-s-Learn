namespace specialform
{
    partial class specialForm
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
            this.btnconvert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lname = new System.Windows.Forms.Label();
            this.lresult = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lchoose = new System.Windows.Forms.Label();
            this.radior1 = new System.Windows.Forms.RadioButton();
            this.radior2 = new System.Windows.Forms.RadioButton();
            this.radior3 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnconvert
            // 
            this.btnconvert.Location = new System.Drawing.Point(107, 226);
            this.btnconvert.Name = "btnconvert";
            this.btnconvert.Size = new System.Drawing.Size(75, 23);
            this.btnconvert.TabIndex = 0;
            this.btnconvert.Text = "Convert";
            this.btnconvert.UseVisualStyleBackColor = true;
            this.btnconvert.Click += new System.EventHandler(this.btnconvert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Converter";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lname
            // 
            this.lname.AutoSize = true;
            this.lname.Location = new System.Drawing.Point(12, 62);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(37, 13);
            this.lname.TabIndex = 2;
            this.lname.Text = "Value:";
            this.lname.Click += new System.EventHandler(this.label2_Click);
            // 
            // lresult
            // 
            this.lresult.AutoSize = true;
            this.lresult.Location = new System.Drawing.Point(12, 115);
            this.lresult.Name = "lresult";
            this.lresult.Size = new System.Drawing.Size(40, 13);
            this.lresult.TabIndex = 3;
            this.lresult.Text = "Result:";
            this.lresult.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(53, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(53, 115);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lchoose
            // 
            this.lchoose.AutoSize = true;
            this.lchoose.Location = new System.Drawing.Point(206, 32);
            this.lchoose.Name = "lchoose";
            this.lchoose.Size = new System.Drawing.Size(65, 13);
            this.lchoose.TabIndex = 6;
            this.lchoose.Text = "Choose Unit";
            // 
            // radior1
            // 
            this.radior1.AutoSize = true;
            this.radior1.Location = new System.Drawing.Point(174, 65);
            this.radior1.Name = "radior1";
            this.radior1.Size = new System.Drawing.Size(110, 17);
            this.radior1.TabIndex = 7;
            this.radior1.TabStop = true;
            this.radior1.Text = "Meter to Kilometer";
            this.radior1.UseVisualStyleBackColor = true;
            this.radior1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            this.radior1.Click += new System.EventHandler(this.radior1_Click);
            // 
            // radior2
            // 
            this.radior2.AutoSize = true;
            this.radior2.Location = new System.Drawing.Point(174, 88);
            this.radior2.Name = "radior2";
            this.radior2.Size = new System.Drawing.Size(86, 17);
            this.radior2.TabIndex = 8;
            this.radior2.TabStop = true;
            this.radior2.Text = "Meter to Mile";
            this.radior2.UseVisualStyleBackColor = true;
            // 
            // radior3
            // 
            this.radior3.AutoSize = true;
            this.radior3.Location = new System.Drawing.Point(174, 113);
            this.radior3.Name = "radior3";
            this.radior3.Size = new System.Drawing.Size(86, 17);
            this.radior3.TabIndex = 9;
            this.radior3.TabStop = true;
            this.radior3.Text = "Mile to Meter";
            this.radior3.UseVisualStyleBackColor = true;
            // 
            // specialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.radior3);
            this.Controls.Add(this.radior2);
            this.Controls.Add(this.radior1);
            this.Controls.Add(this.lchoose);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lresult);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnconvert);
            this.Name = "specialForm";
            this.Text = "specialForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnconvert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lname;
        private System.Windows.Forms.Label lresult;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lchoose;
        private System.Windows.Forms.RadioButton radior1;
        private System.Windows.Forms.RadioButton radior2;
        private System.Windows.Forms.RadioButton radior3;
    }
}