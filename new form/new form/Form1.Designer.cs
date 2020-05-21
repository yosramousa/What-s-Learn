namespace new_form
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnformat = new System.Windows.Forms.Button();
            this.textbox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(23, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // btnformat
            // 
            this.btnformat.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnformat.Location = new System.Drawing.Point(450, 184);
            this.btnformat.Name = "btnformat";
            this.btnformat.Size = new System.Drawing.Size(132, 36);
            this.btnformat.TabIndex = 1;
            this.btnformat.Text = "Format";
            this.btnformat.UseVisualStyleBackColor = true;
            this.btnformat.Click += new System.EventHandler(this.btnformat_Click);
            // 
            // textbox2
            // 
            this.textbox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.textbox2.Location = new System.Drawing.Point(156, 173);
            this.textbox2.Name = "textbox2";
            this.textbox2.Size = new System.Drawing.Size(229, 38);
            this.textbox2.TabIndex = 2;
            this.textbox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(615, 381);
            this.Controls.Add(this.textbox2);
            this.Controls.Add(this.btnformat);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Trainees";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnformat;
        private System.Windows.Forms.TextBox textbox2;
    }
}

