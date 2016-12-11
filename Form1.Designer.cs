namespace ArduinoPiano
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
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnBaglan = new System.Windows.Forms.Button();
            this.btnBaglantiKes = new System.Windows.Forms.Button();
            this.lblArduinoAlinanDeger = new System.Windows.Forms.Label();
            this.lblConnectionStatus = new System.Windows.Forms.Label();
            this.picPianoPictures = new System.Windows.Forms.PictureBox();
            this.picConnectionStatus = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPianoPictures)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picConnectionStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 580);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(98, 20);
            this.textBox1.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnBaglan
            // 
            this.btnBaglan.Location = new System.Drawing.Point(387, 590);
            this.btnBaglan.Name = "btnBaglan";
            this.btnBaglan.Size = new System.Drawing.Size(52, 26);
            this.btnBaglan.TabIndex = 2;
            this.btnBaglan.Text = "Baglan";
            this.btnBaglan.UseVisualStyleBackColor = true;
            this.btnBaglan.Click += new System.EventHandler(this.btnBaglan_Click);
            // 
            // btnBaglantiKes
            // 
            this.btnBaglantiKes.Location = new System.Drawing.Point(445, 590);
            this.btnBaglantiKes.Name = "btnBaglantiKes";
            this.btnBaglantiKes.Size = new System.Drawing.Size(52, 26);
            this.btnBaglantiKes.TabIndex = 3;
            this.btnBaglantiKes.Text = "Kes";
            this.btnBaglantiKes.UseVisualStyleBackColor = true;
            this.btnBaglantiKes.Click += new System.EventHandler(this.btnBaglantiKes_Click);
            // 
            // lblArduinoAlinanDeger
            // 
            this.lblArduinoAlinanDeger.AutoSize = true;
            this.lblArduinoAlinanDeger.Location = new System.Drawing.Point(12, 564);
            this.lblArduinoAlinanDeger.Name = "lblArduinoAlinanDeger";
            this.lblArduinoAlinanDeger.Size = new System.Drawing.Size(37, 13);
            this.lblArduinoAlinanDeger.TabIndex = 4;
            this.lblArduinoAlinanDeger.Text = "Value:";
            // 
            // lblConnectionStatus
            // 
            this.lblConnectionStatus.AutoSize = true;
            this.lblConnectionStatus.Location = new System.Drawing.Point(282, 571);
            this.lblConnectionStatus.Name = "lblConnectionStatus";
            this.lblConnectionStatus.Size = new System.Drawing.Size(101, 13);
            this.lblConnectionStatus.TabIndex = 0;
            this.lblConnectionStatus.Text = "lblConnectionStatus";
            // 
            // picPianoPictures
            // 
            this.picPianoPictures.Image = global::ArduinoPiano.Properties.Resources._default;
            this.picPianoPictures.Location = new System.Drawing.Point(-4, 1);
            this.picPianoPictures.Name = "picPianoPictures";
            this.picPianoPictures.Size = new System.Drawing.Size(650, 513);
            this.picPianoPictures.TabIndex = 6;
            this.picPianoPictures.TabStop = false;
            // 
            // picConnectionStatus
            // 
            this.picConnectionStatus.Image = global::ArduinoPiano.Properties.Resources.bekleniyor;
            this.picConnectionStatus.Location = new System.Drawing.Point(389, 507);
            this.picConnectionStatus.Name = "picConnectionStatus";
            this.picConnectionStatus.Size = new System.Drawing.Size(108, 77);
            this.picConnectionStatus.TabIndex = 5;
            this.picConnectionStatus.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(509, 628);
            this.Controls.Add(this.picPianoPictures);
            this.Controls.Add(this.picConnectionStatus);
            this.Controls.Add(this.lblArduinoAlinanDeger);
            this.Controls.Add(this.btnBaglantiKes);
            this.Controls.Add(this.btnBaglan);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblConnectionStatus);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Istanbul Kultur University Piano Project - Manual Play";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPianoPictures)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picConnectionStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnBaglan;
        private System.Windows.Forms.Button btnBaglantiKes;
        private System.Windows.Forms.Label lblArduinoAlinanDeger;
        private System.Windows.Forms.PictureBox picConnectionStatus;
        private System.Windows.Forms.Label lblConnectionStatus;
        private System.Windows.Forms.PictureBox picPianoPictures;
    }
}

