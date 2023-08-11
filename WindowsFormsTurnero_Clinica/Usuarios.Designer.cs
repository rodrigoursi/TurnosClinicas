namespace WindowsFormsTurnero_Clinica
{
    partial class FormUsuarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridUsuarios = new System.Windows.Forms.DataGridView();
            this.groupBox_accionesUser = new System.Windows.Forms.GroupBox();
            this.button_eliminarUser = new System.Windows.Forms.Button();
            this.button_agregarUser = new System.Windows.Forms.Button();
            this.button_verUser = new System.Windows.Forms.Button();
            this.button_editarUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsuarios)).BeginInit();
            this.groupBox_accionesUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridUsuarios
            // 
            this.dataGridUsuarios.AllowUserToAddRows = false;
            this.dataGridUsuarios.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.dataGridUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridUsuarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridUsuarios.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridUsuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Castellar", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridUsuarios.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridUsuarios.EnableHeadersVisualStyles = false;
            this.dataGridUsuarios.GridColor = System.Drawing.SystemColors.Desktop;
            this.dataGridUsuarios.Location = new System.Drawing.Point(200, 61);
            this.dataGridUsuarios.Name = "dataGridUsuarios";
            this.dataGridUsuarios.ReadOnly = true;
            this.dataGridUsuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridUsuarios.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.dataGridUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridUsuarios.Size = new System.Drawing.Size(457, 294);
            this.dataGridUsuarios.TabIndex = 0;
            // 
            // groupBox_accionesUser
            // 
            this.groupBox_accionesUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox_accionesUser.AutoSize = true;
            this.groupBox_accionesUser.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.groupBox_accionesUser.Controls.Add(this.button_eliminarUser);
            this.groupBox_accionesUser.Controls.Add(this.button_agregarUser);
            this.groupBox_accionesUser.Controls.Add(this.button_verUser);
            this.groupBox_accionesUser.Controls.Add(this.button_editarUser);
            this.groupBox_accionesUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox_accionesUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_accionesUser.Location = new System.Drawing.Point(200, 362);
            this.groupBox_accionesUser.Name = "groupBox_accionesUser";
            this.groupBox_accionesUser.Size = new System.Drawing.Size(457, 66);
            this.groupBox_accionesUser.TabIndex = 1;
            this.groupBox_accionesUser.TabStop = false;
            this.groupBox_accionesUser.Text = "Panel de acciones";
            // 
            // button_eliminarUser
            // 
            this.button_eliminarUser.AutoSize = true;
            this.button_eliminarUser.BackColor = System.Drawing.Color.Red;
            this.button_eliminarUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_eliminarUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_eliminarUser.Location = new System.Drawing.Point(359, 19);
            this.button_eliminarUser.Name = "button_eliminarUser";
            this.button_eliminarUser.Size = new System.Drawing.Size(75, 26);
            this.button_eliminarUser.TabIndex = 3;
            this.button_eliminarUser.Text = "Eliminar";
            this.button_eliminarUser.UseVisualStyleBackColor = false;
            // 
            // button_agregarUser
            // 
            this.button_agregarUser.AutoSize = true;
            this.button_agregarUser.BackColor = System.Drawing.Color.Green;
            this.button_agregarUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_agregarUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_agregarUser.Location = new System.Drawing.Point(25, 19);
            this.button_agregarUser.Name = "button_agregarUser";
            this.button_agregarUser.Size = new System.Drawing.Size(75, 26);
            this.button_agregarUser.TabIndex = 0;
            this.button_agregarUser.Text = "Agregar";
            this.button_agregarUser.UseVisualStyleBackColor = false;
            this.button_agregarUser.Click += new System.EventHandler(this.button_agregarUser_Click);
            // 
            // button_verUser
            // 
            this.button_verUser.AutoSize = true;
            this.button_verUser.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_verUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_verUser.Location = new System.Drawing.Point(246, 19);
            this.button_verUser.Name = "button_verUser";
            this.button_verUser.Size = new System.Drawing.Size(75, 26);
            this.button_verUser.TabIndex = 2;
            this.button_verUser.Text = "Ver";
            this.button_verUser.UseVisualStyleBackColor = false;
            // 
            // button_editarUser
            // 
            this.button_editarUser.AutoSize = true;
            this.button_editarUser.BackColor = System.Drawing.Color.Gold;
            this.button_editarUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_editarUser.Location = new System.Drawing.Point(138, 19);
            this.button_editarUser.Name = "button_editarUser";
            this.button_editarUser.Size = new System.Drawing.Size(75, 26);
            this.button_editarUser.TabIndex = 1;
            this.button_editarUser.Text = "Editar";
            this.button_editarUser.UseVisualStyleBackColor = false;
            // 
            // FormUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsTurnero_Clinica.Properties.Resources._2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 500);
            this.Controls.Add(this.groupBox_accionesUser);
            this.Controls.Add(this.dataGridUsuarios);
            this.Name = "FormUsuarios";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.FormUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsuarios)).EndInit();
            this.groupBox_accionesUser.ResumeLayout(false);
            this.groupBox_accionesUser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridUsuarios;
        private System.Windows.Forms.GroupBox groupBox_accionesUser;
        private System.Windows.Forms.Button button_verUser;
        private System.Windows.Forms.Button button_editarUser;
        private System.Windows.Forms.Button button_agregarUser;
        private System.Windows.Forms.Button button_eliminarUser;
    }
}