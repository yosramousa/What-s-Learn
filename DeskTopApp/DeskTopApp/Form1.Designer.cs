namespace DeskTopApp
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.paneltop = new System.Windows.Forms.Panel();
            this.buttonreservation = new System.Windows.Forms.Button();
            this.buttonmanagepatients = new System.Windows.Forms.Button();
            this.buttonfuturepatients = new System.Windows.Forms.Button();
            this.buttonprofits = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.panel1.Controls.Add(this.buttonprofits);
            this.panel1.Controls.Add(this.buttonfuturepatients);
            this.panel1.Controls.Add(this.buttonmanagepatients);
            this.panel1.Controls.Add(this.buttonreservation);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 742);
            this.panel1.TabIndex = 0;
            // 
            // paneltop
            // 
            this.paneltop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(161)))), ((int)(((byte)(156)))));
            this.paneltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltop.Location = new System.Drawing.Point(236, 0);
            this.paneltop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.paneltop.Name = "paneltop";
            this.paneltop.Size = new System.Drawing.Size(964, 37);
            this.paneltop.TabIndex = 1;
            // 
            // buttonreservation
            // 
            this.buttonreservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonreservation.ForeColor = System.Drawing.Color.White;
            this.buttonreservation.Location = new System.Drawing.Point(-9, 68);
            this.buttonreservation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonreservation.Name = "buttonreservation";
            this.buttonreservation.Size = new System.Drawing.Size(266, 75);
            this.buttonreservation.TabIndex = 0;
            this.buttonreservation.Text = "Reservation";
            this.buttonreservation.UseVisualStyleBackColor = true;
            // 
            // buttonmanagepatients
            // 
            this.buttonmanagepatients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonmanagepatients.ForeColor = System.Drawing.Color.White;
            this.buttonmanagepatients.Location = new System.Drawing.Point(-20, 142);
            this.buttonmanagepatients.Margin = new System.Windows.Forms.Padding(4);
            this.buttonmanagepatients.Name = "buttonmanagepatients";
            this.buttonmanagepatients.Size = new System.Drawing.Size(266, 75);
            this.buttonmanagepatients.TabIndex = 1;
            this.buttonmanagepatients.Text = "Manage Patients";
            this.buttonmanagepatients.UseVisualStyleBackColor = true;
            // 
            // buttonfuturepatients
            // 
            this.buttonfuturepatients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonfuturepatients.ForeColor = System.Drawing.Color.White;
            this.buttonfuturepatients.Location = new System.Drawing.Point(-20, 216);
            this.buttonfuturepatients.Margin = new System.Windows.Forms.Padding(4);
            this.buttonfuturepatients.Name = "buttonfuturepatients";
            this.buttonfuturepatients.Size = new System.Drawing.Size(266, 75);
            this.buttonfuturepatients.TabIndex = 2;
            this.buttonfuturepatients.Text = "Future Patients";
            this.buttonfuturepatients.UseVisualStyleBackColor = true;
            // 
            // buttonprofits
            // 
            this.buttonprofits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonprofits.ForeColor = System.Drawing.Color.White;
            this.buttonprofits.Location = new System.Drawing.Point(-20, 288);
            this.buttonprofits.Margin = new System.Windows.Forms.Padding(4);
            this.buttonprofits.Name = "buttonprofits";
            this.buttonprofits.Size = new System.Drawing.Size(266, 75);
            this.buttonprofits.TabIndex = 3;
            this.buttonprofits.Text = "Profits";
            this.buttonprofits.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(247)))), ((int)(((byte)(191)))));
            this.ClientSize = new System.Drawing.Size(1200, 742);
            this.Controls.Add(this.paneltop);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel paneltop;
        private System.Windows.Forms.Button buttonprofits;
        private System.Windows.Forms.Button buttonfuturepatients;
        private System.Windows.Forms.Button buttonmanagepatients;
        private System.Windows.Forms.Button buttonreservation;
    }
}

