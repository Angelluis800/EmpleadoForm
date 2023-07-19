
namespace PersonaForm
{
    partial class PersonForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.AFPtextBox1 = new System.Windows.Forms.TextBox();
            this.DigitextBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.VocaltextBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.SueldotextBox1 = new System.Windows.Forms.TextBox();
            this.labelSueldo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Buscarbutton3 = new System.Windows.Forms.Button();
            this.Guardarbutton2 = new System.Windows.Forms.Button();
            this.Cancelarbutton1 = new System.Windows.Forms.Button();
            this.telefonomaskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DirecciontextBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NombretextBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.IDnumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.MyerrorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyerrorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AFPtextBox1);
            this.panel1.Controls.Add(this.DigitextBox1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.VocaltextBox1);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.SueldotextBox1);
            this.panel1.Controls.Add(this.labelSueldo);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Buscarbutton3);
            this.panel1.Controls.Add(this.Guardarbutton2);
            this.panel1.Controls.Add(this.Cancelarbutton1);
            this.panel1.Controls.Add(this.telefonomaskedTextBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.DirecciontextBox2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.NombretextBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.IDnumericUpDown1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(17, 16);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 318);
            this.panel1.TabIndex = 0;
            // 
            // AFPtextBox1
            // 
            this.AFPtextBox1.Enabled = false;
            this.AFPtextBox1.Location = new System.Drawing.Point(582, 62);
            this.AFPtextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.AFPtextBox1.Name = "AFPtextBox1";
            this.AFPtextBox1.Size = new System.Drawing.Size(191, 22);
            this.AFPtextBox1.TabIndex = 20;
            this.AFPtextBox1.TextChanged += new System.EventHandler(this.AFPtextBox1_TextChanged);
            // 
            // DigitextBox1
            // 
            this.DigitextBox1.Enabled = false;
            this.DigitextBox1.Location = new System.Drawing.Point(181, 146);
            this.DigitextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.DigitextBox1.Name = "DigitextBox1";
            this.DigitextBox1.Size = new System.Drawing.Size(121, 22);
            this.DigitextBox1.TabIndex = 19;
            this.DigitextBox1.TextChanged += new System.EventHandler(this.DigitextBox1_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 149);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "NUMERO DE DIGITOS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 53);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "VOCALES:";
            // 
            // VocaltextBox1
            // 
            this.VocaltextBox1.Enabled = false;
            this.VocaltextBox1.Location = new System.Drawing.Point(131, 44);
            this.VocaltextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.VocaltextBox1.Name = "VocaltextBox1";
            this.VocaltextBox1.Size = new System.Drawing.Size(99, 22);
            this.VocaltextBox1.TabIndex = 16;
            this.VocaltextBox1.TextChanged += new System.EventHandler(this.VocaltextBox1_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(194, 200);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(89, 22);
            this.dateTimePicker1.TabIndex = 15;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "FECHA DE ADMSION";
            // 
            // SueldotextBox1
            // 
            this.SueldotextBox1.Location = new System.Drawing.Point(582, 20);
            this.SueldotextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.SueldotextBox1.Name = "SueldotextBox1";
            this.SueldotextBox1.Size = new System.Drawing.Size(191, 22);
            this.SueldotextBox1.TabIndex = 13;
            this.SueldotextBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelSueldo
            // 
            this.labelSueldo.AutoSize = true;
            this.labelSueldo.Location = new System.Drawing.Point(502, 23);
            this.labelSueldo.Name = "labelSueldo";
            this.labelSueldo.Size = new System.Drawing.Size(62, 16);
            this.labelSueldo.TabIndex = 12;
            this.labelSueldo.Text = "SUELDO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(267, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 16);
            this.label5.TabIndex = 11;
            // 
            // Buscarbutton3
            // 
            this.Buscarbutton3.BackColor = System.Drawing.Color.Teal;
            this.Buscarbutton3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Buscarbutton3.Location = new System.Drawing.Point(685, 263);
            this.Buscarbutton3.Margin = new System.Windows.Forms.Padding(4);
            this.Buscarbutton3.Name = "Buscarbutton3";
            this.Buscarbutton3.Size = new System.Drawing.Size(100, 39);
            this.Buscarbutton3.TabIndex = 10;
            this.Buscarbutton3.Text = "BUSCAR";
            this.Buscarbutton3.UseVisualStyleBackColor = false;
            this.Buscarbutton3.Click += new System.EventHandler(this.Buscarbutton3_Click);
            // 
            // Guardarbutton2
            // 
            this.Guardarbutton2.BackColor = System.Drawing.Color.SteelBlue;
            this.Guardarbutton2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Guardarbutton2.Location = new System.Drawing.Point(162, 255);
            this.Guardarbutton2.Margin = new System.Windows.Forms.Padding(4);
            this.Guardarbutton2.Name = "Guardarbutton2";
            this.Guardarbutton2.Size = new System.Drawing.Size(160, 54);
            this.Guardarbutton2.TabIndex = 9;
            this.Guardarbutton2.Text = "GUARDAR";
            this.Guardarbutton2.UseVisualStyleBackColor = false;
            this.Guardarbutton2.Click += new System.EventHandler(this.Guardarbutton2_Click);
            // 
            // Cancelarbutton1
            // 
            this.Cancelarbutton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Cancelarbutton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Cancelarbutton1.Location = new System.Drawing.Point(4, 255);
            this.Cancelarbutton1.Margin = new System.Windows.Forms.Padding(4);
            this.Cancelarbutton1.Name = "Cancelarbutton1";
            this.Cancelarbutton1.Size = new System.Drawing.Size(145, 54);
            this.Cancelarbutton1.TabIndex = 8;
            this.Cancelarbutton1.Text = "CANCELAR";
            this.Cancelarbutton1.UseVisualStyleBackColor = false;
            this.Cancelarbutton1.Click += new System.EventHandler(this.Cancelarbutton1_Click);
            // 
            // telefonomaskedTextBox1
            // 
            this.telefonomaskedTextBox1.Location = new System.Drawing.Point(131, 110);
            this.telefonomaskedTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.telefonomaskedTextBox1.Mask = "(999) 000-0000";
            this.telefonomaskedTextBox1.Name = "telefonomaskedTextBox1";
            this.telefonomaskedTextBox1.Size = new System.Drawing.Size(191, 22);
            this.telefonomaskedTextBox1.TabIndex = 7;
            this.telefonomaskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.telefonomaskedTextBox1_MaskInputRejected);
            this.telefonomaskedTextBox1.TextChanged += new System.EventHandler(this.telefonomaskedTextBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 118);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "TELEFONO:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // DirecciontextBox2
            // 
            this.DirecciontextBox2.Location = new System.Drawing.Point(131, 80);
            this.DirecciontextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.DirecciontextBox2.Name = "DirecciontextBox2";
            this.DirecciontextBox2.Size = new System.Drawing.Size(309, 22);
            this.DirecciontextBox2.TabIndex = 5;
            this.DirecciontextBox2.TextChanged += new System.EventHandler(this.DirecciontextBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "DIRRECION:";
            // 
            // NombretextBox1
            // 
            this.NombretextBox1.Location = new System.Drawing.Point(131, 17);
            this.NombretextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.NombretextBox1.Name = "NombretextBox1";
            this.NombretextBox1.Size = new System.Drawing.Size(309, 22);
            this.NombretextBox1.TabIndex = 3;
            this.NombretextBox1.TextChanged += new System.EventHandler(this.NombretextBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "NOMBRE:";
            // 
            // IDnumericUpDown1
            // 
            this.IDnumericUpDown1.Location = new System.Drawing.Point(505, 272);
            this.IDnumericUpDown1.Margin = new System.Windows.Forms.Padding(4);
            this.IDnumericUpDown1.Name = "IDnumericUpDown1";
            this.IDnumericUpDown1.Size = new System.Drawing.Size(160, 22);
            this.IDnumericUpDown1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(474, 274);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // MyerrorProvider1
            // 
            this.MyerrorProvider1.ContainerControl = this;
            // 
            // PersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 346);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "PersonForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro De Empleado";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyerrorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Guardarbutton2;
        private System.Windows.Forms.Button Cancelarbutton1;
        private System.Windows.Forms.MaskedTextBox telefonomaskedTextBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DirecciontextBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NombretextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown IDnumericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider MyerrorProvider1;
        private System.Windows.Forms.Button Buscarbutton3;
        private System.Windows.Forms.Label labelSueldo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox SueldotextBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox VocaltextBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox DigitextBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox AFPtextBox1;
    }
}

