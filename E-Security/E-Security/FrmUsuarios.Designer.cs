namespace E_Security
{
    partial class FrmUsuarios
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.toolTipUsuarios = new System.Windows.Forms.ToolTip(this.components);
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labelInformativo = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(46, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 255);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Módulo de Usuarios";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(151, 178);
            this.textBox5.Name = "textBox5";
            this.textBox5.PasswordChar = '*';
            this.textBox5.Size = new System.Drawing.Size(218, 20);
            this.textBox5.TabIndex = 29;
            this.toolTipUsuarios.SetToolTip(this.textBox5, "Repetir la anterior contraseña");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Repetir contraseña:";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(256, 221);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(71, 17);
            this.radioButton2.TabIndex = 21;
            this.radioButton2.Text = "Inactivo";
            this.toolTipUsuarios.SetToolTip(this.radioButton2, "No permitido para ingresar al sistema");
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(155, 221);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(61, 17);
            this.radioButton1.TabIndex = 20;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Activo";
            this.toolTipUsuarios.SetToolTip(this.radioButton1, "Permitido para ingresar al sistema");
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Estado:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(151, 140);
            this.textBox4.Name = "textBox4";
            this.textBox4.PasswordChar = '*';
            this.textBox4.Size = new System.Drawing.Size(218, 20);
            this.textBox4.TabIndex = 18;
            this.toolTipUsuarios.SetToolTip(this.textBox4, "Contraseña del Usuario para ingresar al sistema");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Contraseña:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(151, 103);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(218, 20);
            this.textBox3.TabIndex = 16;
            this.toolTipUsuarios.SetToolTip(this.textBox3, "Ej: Roberto Jesus Sanchez Rojas");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Nombre Completo:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(151, 68);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(218, 20);
            this.textBox2.TabIndex = 14;
            this.toolTipUsuarios.SetToolTip(this.textBox2, "Cédula del Usuario");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Cédula:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(151, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(218, 20);
            this.textBox1.TabIndex = 12;
            this.toolTipUsuarios.SetToolTip(this.textBox1, "Identificador del Usuario");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "ID Usuario:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.btnAceptar);
            this.groupBox2.Controls.Add(this.btnCancelar);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(46, 272);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(391, 48);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Acciones";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(166)))), ((int)(((byte)(224)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(179, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 28);
            this.button1.TabIndex = 25;
            this.button1.Text = "Modificar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(166)))), ((int)(((byte)(224)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(265, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 28);
            this.button2.TabIndex = 26;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(166)))), ((int)(((byte)(224)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Image = global::E_Security.Properties.Resources.limpiar;
            this.button3.Location = new System.Drawing.Point(352, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(28, 30);
            this.button3.TabIndex = 27;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(166)))), ((int)(((byte)(224)))));
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.Black;
            this.btnAceptar.Location = new System.Drawing.Point(3, 13);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(85, 28);
            this.btnAceptar.TabIndex = 23;
            this.btnAceptar.Text = "Consultar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(166)))), ((int)(((byte)(224)))));
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(90, 13);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(85, 28);
            this.btnCancelar.TabIndex = 24;
            this.btnCancelar.Text = "Agregar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // toolTipUsuarios
            // 
            this.toolTipUsuarios.ToolTipTitle = "¡Ayuda!";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(134, 9);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(350, 20);
            this.textBox6.TabIndex = 3;
            this.toolTipUsuarios.SetToolTip(this.textBox6, "Ingrese el nombre del usuario que desea buscar en la lista");
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(498, 362);
            this.tabControl1.TabIndex = 25;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(490, 336);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Control de Usuarios";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.labelInformativo);
            this.tabPage2.Controls.Add(this.textBox6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(490, 336);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Listado de Usuarios";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // labelInformativo
            // 
            this.labelInformativo.AutoSize = true;
            this.labelInformativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInformativo.ForeColor = System.Drawing.Color.Red;
            this.labelInformativo.Location = new System.Drawing.Point(221, 37);
            this.labelInformativo.Name = "labelInformativo";
            this.labelInformativo.Size = new System.Drawing.Size(138, 13);
            this.labelInformativo.TabIndex = 4;
            this.labelInformativo.Text = "Este Usuario NO existe";
            this.labelInformativo.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Busqueda por Nombre:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(3, 53);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(484, 277);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Información de usuarios";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.cedula,
            this.nombreCompleto});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(478, 258);
            this.dataGridView1.TabIndex = 0;
            // 
            // id
            // 
            this.id.FillWeight = 69.44444F;
            this.id.HeaderText = "ID Usuario";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 101;
            // 
            // cedula
            // 
            this.cedula.FillWeight = 100.798F;
            this.cedula.HeaderText = "Cédula";
            this.cedula.Name = "cedula";
            this.cedula.ReadOnly = true;
            this.cedula.Width = 146;
            // 
            // nombreCompleto
            // 
            this.nombreCompleto.FillWeight = 129.7576F;
            this.nombreCompleto.HeaderText = "Nombre Completo";
            this.nombreCompleto.Name = "nombreCompleto";
            this.nombreCompleto.ReadOnly = true;
            this.nombreCompleto.Width = 188;
            // 
            // FrmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 365);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmUsuarios";
            this.Text = "FrmUsuarios";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ToolTip toolTipUsuarios;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCompleto;
        private System.Windows.Forms.Label labelInformativo;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label7;
    }
}