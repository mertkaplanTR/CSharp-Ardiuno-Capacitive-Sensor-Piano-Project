namespace ArduinoPiano
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
            this.components = new System.ComponentModel.Container();
            this.btnCal = new System.Windows.Forms.Button();
            this.btnBaglan = new System.Windows.Forms.Button();
            this.picConnectionStatus = new System.Windows.Forms.PictureBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picConnectionStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(146, 95);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(75, 28);
            this.btnCal.TabIndex = 17;
            this.btnCal.Text = "Çal";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // btnBaglan
            // 
            this.btnBaglan.Location = new System.Drawing.Point(12, 95);
            this.btnBaglan.Name = "btnBaglan";
            this.btnBaglan.Size = new System.Drawing.Size(111, 26);
            this.btnBaglan.TabIndex = 15;
            this.btnBaglan.Text = "Baglan";
            this.btnBaglan.UseVisualStyleBackColor = true;
            this.btnBaglan.Click += new System.EventHandler(this.btnBaglan_Click);
            // 
            // picConnectionStatus
            // 
            this.picConnectionStatus.Image = global::ArduinoPiano.Properties.Resources.bekleniyor;
            this.picConnectionStatus.Location = new System.Drawing.Point(15, 12);
            this.picConnectionStatus.Name = "picConnectionStatus";
            this.picConnectionStatus.Size = new System.Drawing.Size(108, 77);
            this.picConnectionStatus.TabIndex = 14;
            this.picConnectionStatus.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "label1";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 343);
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.btnBaglan);
            this.Controls.Add(this.picConnectionStatus);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picConnectionStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Button btnBaglan;
        private System.Windows.Forms.PictureBox picConnectionStatus;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label1;
    }
}