namespace stepbystep
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericupdown = new System.Windows.Forms.NumericUpDown();
            this.domainupdown = new System.Windows.Forms.DomainUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericupdown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Size:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sample Text";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // numericupdown
            // 
            this.numericupdown.Location = new System.Drawing.Point(108, 91);
            this.numericupdown.Name = "numericupdown";
            this.numericupdown.Size = new System.Drawing.Size(120, 20);
            this.numericupdown.TabIndex = 5;
            this.numericupdown.ValueChanged += new System.EventHandler(this.n1_ValueChanged);
            // 
            // domainupdown
            // 
            this.domainupdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.domainupdown.Items.Add("red");
            this.domainupdown.Items.Add("yellow ");
            this.domainupdown.Items.Add("blue");
            this.domainupdown.Items.Add("green");
            this.domainupdown.Items.Add("gray");
            this.domainupdown.Items.Add("black");
            this.domainupdown.Items.Add("white");
            this.domainupdown.Items.Add("pink ");
            this.domainupdown.Items.Add("lemon");
            this.domainupdown.Location = new System.Drawing.Point(108, 36);
            this.domainupdown.Name = "domainupdown";
            this.domainupdown.Size = new System.Drawing.Size(120, 20);
            this.domainupdown.TabIndex = 6;
            this.domainupdown.Text = "black";
            this.domainupdown.SelectedItemChanged += new System.EventHandler(this.red_SelectedItemChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 320);
            this.Controls.Add(this.domainupdown);
            this.Controls.Add(this.numericupdown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "stepbystep";
            ((System.ComponentModel.ISupportInitialize)(this.numericupdown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericupdown;
        private System.Windows.Forms.DomainUpDown domainupdown;
    }
}

