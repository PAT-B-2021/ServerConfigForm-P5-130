
namespace ServerConfigForm_P5_130
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
            this.ON = new System.Windows.Forms.Button();
            this.OFF = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelKet = new System.Windows.Forms.Label();
            this.labelOnOrOff = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ON
            // 
            this.ON.Location = new System.Drawing.Point(269, 201);
            this.ON.Name = "ON";
            this.ON.Size = new System.Drawing.Size(75, 23);
            this.ON.TabIndex = 0;
            this.ON.Text = "ON";
            this.ON.UseVisualStyleBackColor = true;
            this.ON.Click += new System.EventHandler(this.ON_Click);
            // 
            // OFF
            // 
            this.OFF.Location = new System.Drawing.Point(482, 200);
            this.OFF.Name = "OFF";
            this.OFF.Size = new System.Drawing.Size(75, 23);
            this.OFF.TabIndex = 1;
            this.OFF.Text = "OFF";
            this.OFF.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(390, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Server";
            // 
            // labelKet
            // 
            this.labelKet.AutoSize = true;
            this.labelKet.Location = new System.Drawing.Point(390, 150);
            this.labelKet.Name = "labelKet";
            this.labelKet.Size = new System.Drawing.Size(57, 13);
            this.labelKet.TabIndex = 3;
            this.labelKet.Text = "Server ON";
            // 
            // labelOnOrOff
            // 
            this.labelOnOrOff.AutoSize = true;
            this.labelOnOrOff.Location = new System.Drawing.Point(390, 176);
            this.labelOnOrOff.Name = "labelOnOrOff";
            this.labelOnOrOff.Size = new System.Drawing.Size(166, 13);
            this.labelOnOrOff.TabIndex = 4;
            this.labelOnOrOff.Text = "Klik OFF untuk Mematikan Server";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelOnOrOff);
            this.Controls.Add(this.labelKet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OFF);
            this.Controls.Add(this.ON);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ON;
        private System.Windows.Forms.Button OFF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelKet;
        private System.Windows.Forms.Label labelOnOrOff;
    }
}

