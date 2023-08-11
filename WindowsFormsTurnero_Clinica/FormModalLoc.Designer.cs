namespace WindowsFormsTurnero_Clinica
{
    partial class FormModalLoc
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
            this.label1 = new System.Windows.Forms.Label();
            this.textModal_nombre = new System.Windows.Forms.TextBox();
            this.comboModal_prov = new System.Windows.Forms.ComboBox();
            this.button_agregarUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Localidad:";
            // 
            // textModal_nombre
            // 
            this.textModal_nombre.Location = new System.Drawing.Point(82, 39);
            this.textModal_nombre.Name = "textModal_nombre";
            this.textModal_nombre.Size = new System.Drawing.Size(130, 20);
            this.textModal_nombre.TabIndex = 1;
            // 
            // comboModal_prov
            // 
            this.comboModal_prov.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboModal_prov.FormattingEnabled = true;
            this.comboModal_prov.Location = new System.Drawing.Point(233, 39);
            this.comboModal_prov.Name = "comboModal_prov";
            this.comboModal_prov.Size = new System.Drawing.Size(130, 21);
            this.comboModal_prov.TabIndex = 2;
            // 
            // button_agregarUser
            // 
            this.button_agregarUser.AutoSize = true;
            this.button_agregarUser.BackColor = System.Drawing.Color.Green;
            this.button_agregarUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_agregarUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_agregarUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_agregarUser.Location = new System.Drawing.Point(130, 84);
            this.button_agregarUser.Name = "button_agregarUser";
            this.button_agregarUser.Size = new System.Drawing.Size(151, 41);
            this.button_agregarUser.TabIndex = 3;
            this.button_agregarUser.Text = "Agregar";
            this.button_agregarUser.UseVisualStyleBackColor = false;
            this.button_agregarUser.Click += new System.EventHandler(this.button_agregarUser_Click);
            // 
            // FormModalLoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 148);
            this.Controls.Add(this.button_agregarUser);
            this.Controls.Add(this.comboModal_prov);
            this.Controls.Add(this.textModal_nombre);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormModalLoc";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar localidad";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormModalLoc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textModal_nombre;
        private System.Windows.Forms.ComboBox comboModal_prov;
        private System.Windows.Forms.Button button_agregarUser;
    }
}