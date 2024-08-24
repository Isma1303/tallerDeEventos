
namespace TallerdeEventos
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
            comboBox = new ComboBox();
            txtDescripcion = new TextBox();
            btnAgregar = new Button();
            lstProgreso = new ListBox();
            lstTerminadas = new ListBox();
            lstPendientess = new ListBox();
            SuspendLayout();
            // 
            // comboBox
            // 
            comboBox.FormattingEnabled = true;
            comboBox.Items.AddRange(new object[] { "Pendiente", "En Progreso", "Terminado" });
            comboBox.Location = new Point(12, 34);
            comboBox.Name = "comboBox";
            comboBox.Size = new Size(121, 23);
            comboBox.TabIndex = 0;
            comboBox.SelectedIndexChanged += comboBox_SelectedIndexChanged;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(139, 34);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(398, 23);
            txtDescripcion.TabIndex = 1;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(568, 34);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "button1";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lstProgreso
            // 
            lstProgreso.FormattingEnabled = true;
            lstProgreso.ItemHeight = 15;
            lstProgreso.Location = new Point(216, 101);
            lstProgreso.Name = "lstProgreso";
            lstProgreso.Size = new Size(198, 319);
            lstProgreso.TabIndex = 4;
            lstProgreso.SelectedIndexChanged += lstProgreso_SelectedIndexChanged;
            // 
            // lstTerminadas
            // 
            lstTerminadas.FormattingEnabled = true;
            lstTerminadas.ItemHeight = 15;
            lstTerminadas.Location = new Point(420, 101);
            lstTerminadas.Name = "lstTerminadas";
            lstTerminadas.Size = new Size(198, 319);
            lstTerminadas.TabIndex = 5;
            lstTerminadas.SelectedIndexChanged += lstTerminadas_SelectedIndexChanged;
            // 
            // lstPendientess
            // 
            lstPendientess.FormattingEnabled = true;
            lstPendientess.ItemHeight = 15;
            lstPendientess.Location = new Point(12, 101);
            lstPendientess.Name = "lstPendientess";
            lstPendientess.Size = new Size(198, 319);
            lstPendientess.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstPendientess);
            Controls.Add(lstTerminadas);
            Controls.Add(lstProgreso);
            Controls.Add(btnAgregar);
            Controls.Add(txtDescripcion);
            Controls.Add(comboBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private ComboBox comboBox;
        private TextBox txtDescripcion;
        private Button btnAgregar;
        private ListBox lstProgreso;
        private ListBox lstTerminadas;
        private ListBox lstPendientess;
    }
}
