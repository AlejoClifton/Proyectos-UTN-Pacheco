
namespace TP_1
{
    partial class FormEjercicio2
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
            this.groupBox_izq = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.tbxApellido = new System.Windows.Forms.TextBox();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.groupBox_der = new System.Windows.Forms.GroupBox();
            this.listbElementos = new System.Windows.Forms.ListBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.groupBox_izq.SuspendLayout();
            this.groupBox_der.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_izq
            // 
            this.groupBox_izq.Controls.Add(this.btnAgregar);
            this.groupBox_izq.Controls.Add(this.tbxApellido);
            this.groupBox_izq.Controls.Add(this.tbxNombre);
            this.groupBox_izq.Controls.Add(this.lblApellido);
            this.groupBox_izq.Controls.Add(this.lblNombre);
            this.groupBox_izq.Location = new System.Drawing.Point(14, 36);
            this.groupBox_izq.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_izq.Name = "groupBox_izq";
            this.groupBox_izq.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_izq.Size = new System.Drawing.Size(405, 528);
            this.groupBox_izq.TabIndex = 0;
            this.groupBox_izq.TabStop = false;
            this.groupBox_izq.Text = "Ingreso de datos";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(174, 379);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(126, 45);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // tbxApellido
            // 
            this.tbxApellido.Location = new System.Drawing.Point(174, 285);
            this.tbxApellido.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxApellido.Name = "tbxApellido";
            this.tbxApellido.Size = new System.Drawing.Size(195, 27);
            this.tbxApellido.TabIndex = 3;
            this.tbxApellido.TextChanged += new System.EventHandler(this.tbxApellido_TextChanged);
            // 
            // tbxNombre
            // 
            this.tbxNombre.Location = new System.Drawing.Point(174, 224);
            this.tbxNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(193, 27);
            this.tbxNombre.TabIndex = 2;
            this.tbxNombre.TextChanged += new System.EventHandler(this.tbxNombre_TextChanged);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblApellido.Location = new System.Drawing.Point(88, 283);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(91, 25);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(88, 223);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(91, 25);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // groupBox_der
            // 
            this.groupBox_der.Controls.Add(this.listbElementos);
            this.groupBox_der.Controls.Add(this.btnBorrar);
            this.groupBox_der.Location = new System.Drawing.Point(473, 36);
            this.groupBox_der.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_der.Name = "groupBox_der";
            this.groupBox_der.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_der.Size = new System.Drawing.Size(427, 528);
            this.groupBox_der.TabIndex = 0;
            this.groupBox_der.TabStop = false;
            this.groupBox_der.Text = "Elementos";
            // 
            // listbElementos
            // 
            this.listbElementos.FormattingEnabled = true;
            this.listbElementos.ItemHeight = 20;
            this.listbElementos.Location = new System.Drawing.Point(7, 29);
            this.listbElementos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listbElementos.Name = "listbElementos";
            this.listbElementos.Size = new System.Drawing.Size(412, 384);
            this.listbElementos.TabIndex = 7;
            this.listbElementos.SelectedIndexChanged += new System.EventHandler(this.listbElementos_SelectedIndexChanged);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(153, 453);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(128, 45);
            this.btnBorrar.TabIndex = 6;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // FormEjercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.groupBox_der);
            this.Controls.Add(this.groupBox_izq);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormEjercicio2";
            this.Text = "FormEjercicio2";
            this.groupBox_izq.ResumeLayout(false);
            this.groupBox_izq.PerformLayout();
            this.groupBox_der.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_izq;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox groupBox_der;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox tbxApellido;
        private System.Windows.Forms.TextBox tbxNombre;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.ListBox listbElementos;
    }
}