namespace E_Security
{
    partial class FrmInformativa
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
            this.txtMsj = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnSi = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMsj
            // 
            this.txtMsj.BackColor = System.Drawing.SystemColors.Control;
            this.txtMsj.Enabled = false;
            this.txtMsj.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMsj.Location = new System.Drawing.Point(15, 26);
            this.txtMsj.Multiline = true;
            this.txtMsj.Name = "txtMsj";
            this.txtMsj.Size = new System.Drawing.Size(643, 44);
            this.txtMsj.TabIndex = 0;
            this.txtMsj.Text = "El nuevo Usuario ha sido agregado al sistemas\r\nEl nuevo Usuario ha sido agregado " +
    "al sistemas";
            this.txtMsj.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(166)))), ((int)(((byte)(224)))));
            this.btnAceptar.Location = new System.Drawing.Point(290, 88);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(87, 23);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnSi
            // 
            this.btnSi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(166)))), ((int)(((byte)(224)))));
            this.btnSi.Location = new System.Drawing.Point(219, 87);
            this.btnSi.Name = "btnSi";
            this.btnSi.Size = new System.Drawing.Size(87, 23);
            this.btnSi.TabIndex = 2;
            this.btnSi.Text = "SÍ";
            this.btnSi.UseVisualStyleBackColor = false;
            this.btnSi.Click += new System.EventHandler(this.btnSi_Click);
            // 
            // btnNo
            // 
            this.btnNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(166)))), ((int)(((byte)(224)))));
            this.btnNo.Location = new System.Drawing.Point(358, 87);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(87, 23);
            this.btnNo.TabIndex = 3;
            this.btnNo.Text = "NO";
            this.btnNo.UseVisualStyleBackColor = false;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(551, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Pvto";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FrmInformativa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 122);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnSi);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtMsj);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmInformativa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmInformativa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMsj;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnSi;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Button button1;
    }
}