namespace Ejercicio1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbPatente = new TextBox();
            tbImporte = new TextBox();
            btnConfirmar = new Button();
            btnActualizar = new Button();
            btnExportar = new Button();
            lsbVer = new ListBox();
            dtpVencimiento = new DateTimePicker();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            btnImportar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 24);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Patente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 53);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 1;
            label2.Text = "Vencimiento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 82);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 2;
            label3.Text = "Importe";
            // 
            // tbPatente
            // 
            tbPatente.Location = new Point(112, 16);
            tbPatente.Name = "tbPatente";
            tbPatente.Size = new Size(100, 23);
            tbPatente.TabIndex = 3;
            // 
            // tbImporte
            // 
            tbImporte.Location = new Point(112, 74);
            tbImporte.Name = "tbImporte";
            tbImporte.Size = new Size(100, 23);
            tbImporte.TabIndex = 5;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(263, 45);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(75, 23);
            btnConfirmar.TabIndex = 6;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(263, 139);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 7;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnExportar
            // 
            btnExportar.Location = new Point(263, 224);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(75, 23);
            btnExportar.TabIndex = 9;
            btnExportar.Text = "Exportar";
            btnExportar.UseVisualStyleBackColor = true;
            // 
            // lsbVer
            // 
            lsbVer.FormattingEnabled = true;
            lsbVer.ItemHeight = 15;
            lsbVer.Location = new Point(12, 117);
            lsbVer.Name = "lsbVer";
            lsbVer.Size = new Size(230, 184);
            lsbVer.TabIndex = 10;
            // 
            // dtpVencimiento
            // 
            dtpVencimiento.CustomFormat = "dd/MM/yyyy";
            dtpVencimiento.Format = DateTimePickerFormat.Custom;
            dtpVencimiento.Location = new Point(112, 47);
            dtpVencimiento.Name = "dtpVencimiento";
            dtpVencimiento.Size = new Size(100, 23);
            dtpVencimiento.TabIndex = 11;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnImportar
            // 
            btnImportar.Location = new Point(263, 182);
            btnImportar.Name = "btnImportar";
            btnImportar.Size = new Size(75, 23);
            btnImportar.TabIndex = 12;
            btnImportar.Text = "Importar";
            btnImportar.UseVisualStyleBackColor = true;
            btnImportar.Click += btnImportar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(366, 325);
            Controls.Add(btnImportar);
            Controls.Add(dtpVencimiento);
            Controls.Add(lsbVer);
            Controls.Add(btnExportar);
            Controls.Add(btnActualizar);
            Controls.Add(btnConfirmar);
            Controls.Add(tbImporte);
            Controls.Add(tbPatente);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button btnConfirmar;
        private Button btnActualizar;
        private Button button3;
        private Button btnExportar;
        public ListBox lsbVer;
        public TextBox tbImporte;
        public TextBox tbPatente;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private ListBox listBox1;
        public DateTimePicker dtpVencimiento;
        private Button btnImportar;
    }
}
