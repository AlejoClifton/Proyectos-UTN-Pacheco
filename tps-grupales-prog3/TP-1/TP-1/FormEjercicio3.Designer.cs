
namespace TP_1
{
    partial class FormEjercicio3
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
            this.chklbOccupation = new System.Windows.Forms.CheckedListBox();
            this.gbxSex = new System.Windows.Forms.GroupBox();
            this.rbtnMasc = new System.Windows.Forms.RadioButton();
            this.rbtnFem = new System.Windows.Forms.RadioButton();
            this.gbxMaritalStatus = new System.Windows.Forms.GroupBox();
            this.rbtnSingle = new System.Windows.Forms.RadioButton();
            this.rbtnMarried = new System.Windows.Forms.RadioButton();
            this.btnShowSelection = new System.Windows.Forms.Button();
            this.lblSelectedItems = new System.Windows.Forms.Label();
            this.lblMostrarseleccion = new System.Windows.Forms.Label();
            this.gbxSex.SuspendLayout();
            this.gbxMaritalStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // chklbOccupation
            // 
            this.chklbOccupation.CheckOnClick = true;
            this.chklbOccupation.FormattingEnabled = true;
            this.chklbOccupation.Items.AddRange(new object[] {
            "Data Entry",
            "Operador de PC",
            "Programador",
            "Tester"});
            this.chklbOccupation.Location = new System.Drawing.Point(343, 143);
            this.chklbOccupation.Name = "chklbOccupation";
            this.chklbOccupation.Size = new System.Drawing.Size(136, 112);
            this.chklbOccupation.TabIndex = 0;
            // 
            // gbxSex
            // 
            this.gbxSex.Controls.Add(this.rbtnMasc);
            this.gbxSex.Controls.Add(this.rbtnFem);
            this.gbxSex.Location = new System.Drawing.Point(96, 41);
            this.gbxSex.Name = "gbxSex";
            this.gbxSex.Size = new System.Drawing.Size(200, 90);
            this.gbxSex.TabIndex = 1;
            this.gbxSex.TabStop = false;
            this.gbxSex.Text = "Sexo";
            // 
            // rbtnMasc
            // 
            this.rbtnMasc.AutoSize = true;
            this.rbtnMasc.Location = new System.Drawing.Point(6, 59);
            this.rbtnMasc.Name = "rbtnMasc";
            this.rbtnMasc.Size = new System.Drawing.Size(80, 19);
            this.rbtnMasc.TabIndex = 1;
            this.rbtnMasc.Text = "Masculino";
            this.rbtnMasc.UseVisualStyleBackColor = true;
            // 
            // rbtnFem
            // 
            this.rbtnFem.AutoSize = true;
            this.rbtnFem.Checked = true;
            this.rbtnFem.Location = new System.Drawing.Point(7, 23);
            this.rbtnFem.Name = "rbtnFem";
            this.rbtnFem.Size = new System.Drawing.Size(78, 19);
            this.rbtnFem.TabIndex = 0;
            this.rbtnFem.TabStop = true;
            this.rbtnFem.Text = "Femenino";
            this.rbtnFem.UseVisualStyleBackColor = true;
            // 
            // gbxMaritalStatus
            // 
            this.gbxMaritalStatus.Controls.Add(this.rbtnSingle);
            this.gbxMaritalStatus.Controls.Add(this.rbtnMarried);
            this.gbxMaritalStatus.Location = new System.Drawing.Point(534, 41);
            this.gbxMaritalStatus.Name = "gbxMaritalStatus";
            this.gbxMaritalStatus.Size = new System.Drawing.Size(200, 90);
            this.gbxMaritalStatus.TabIndex = 2;
            this.gbxMaritalStatus.TabStop = false;
            this.gbxMaritalStatus.Text = "Estado Civil";
            // 
            // rbtnSingle
            // 
            this.rbtnSingle.AutoSize = true;
            this.rbtnSingle.Location = new System.Drawing.Point(7, 55);
            this.rbtnSingle.Name = "rbtnSingle";
            this.rbtnSingle.Size = new System.Drawing.Size(62, 19);
            this.rbtnSingle.TabIndex = 1;
            this.rbtnSingle.Text = "Soltero";
            this.rbtnSingle.UseVisualStyleBackColor = true;
            // 
            // rbtnMarried
            // 
            this.rbtnMarried.AutoSize = true;
            this.rbtnMarried.Checked = true;
            this.rbtnMarried.Location = new System.Drawing.Point(7, 22);
            this.rbtnMarried.Name = "rbtnMarried";
            this.rbtnMarried.Size = new System.Drawing.Size(64, 19);
            this.rbtnMarried.TabIndex = 0;
            this.rbtnMarried.TabStop = true;
            this.rbtnMarried.Text = "Casado";
            this.rbtnMarried.UseVisualStyleBackColor = true;
            // 
            // btnShowSelection
            // 
            this.btnShowSelection.Location = new System.Drawing.Point(334, 273);
            this.btnShowSelection.Name = "btnShowSelection";
            this.btnShowSelection.Size = new System.Drawing.Size(163, 33);
            this.btnShowSelection.TabIndex = 3;
            this.btnShowSelection.Text = "Mostrar lo que selecciono";
            this.btnShowSelection.UseVisualStyleBackColor = true;
            this.btnShowSelection.Click += new System.EventHandler(this.btnShowSelection_Click);
            // 
            // lblSelectedItems
            // 
            this.lblSelectedItems.AutoSize = true;
            this.lblSelectedItems.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSelectedItems.Location = new System.Drawing.Point(222, 325);
            this.lblSelectedItems.Name = "lblSelectedItems";
            this.lblSelectedItems.Size = new System.Drawing.Size(339, 21);
            this.lblSelectedItems.TabIndex = 4;
            this.lblSelectedItems.Text = "Usted selecciono los siguientes elementos: ";
            // 
            // lblMostrarseleccion
            // 
            this.lblMostrarseleccion.AutoSize = true;
            this.lblMostrarseleccion.Location = new System.Drawing.Point(222, 358);
            this.lblMostrarseleccion.Name = "lblMostrarseleccion";
            this.lblMostrarseleccion.Size = new System.Drawing.Size(0, 15);
            this.lblMostrarseleccion.TabIndex = 5;
            // 
            // FormEjercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMostrarseleccion);
            this.Controls.Add(this.lblSelectedItems);
            this.Controls.Add(this.btnShowSelection);
            this.Controls.Add(this.gbxMaritalStatus);
            this.Controls.Add(this.gbxSex);
            this.Controls.Add(this.chklbOccupation);
            this.Name = "FormEjercicio3";
            this.Text = "FormEjercicio3";
            this.gbxSex.ResumeLayout(false);
            this.gbxSex.PerformLayout();
            this.gbxMaritalStatus.ResumeLayout(false);
            this.gbxMaritalStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chklbOccupation;
        private System.Windows.Forms.GroupBox gbxSex;
        private System.Windows.Forms.RadioButton rbtnMasc;
        private System.Windows.Forms.RadioButton rbtnFem;
        private System.Windows.Forms.GroupBox gbxMaritalStatus;
        private System.Windows.Forms.RadioButton rbtnSingle;
        private System.Windows.Forms.RadioButton rbtnMarried;
        private System.Windows.Forms.Button btnShowSelection;
        private System.Windows.Forms.Label lblSelectedItems;
        private System.Windows.Forms.Label lblMostrarseleccion;
    }
}