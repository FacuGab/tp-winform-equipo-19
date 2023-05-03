namespace app
{
    partial class frmVentanaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentanaPrincipal));
            this.dgvPanel = new System.Windows.Forms.DataGridView();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.pbxArticuloLoad = new System.Windows.Forms.PictureBox();
            this.pbAñadirArt = new System.Windows.Forms.PictureBox();
            this.pbActualizar = new System.Windows.Forms.PictureBox();
            this.pbEliminar = new System.Windows.Forms.PictureBox();
            this.pbEditar = new System.Windows.Forms.PictureBox();
            this.lblFiltroNombre = new System.Windows.Forms.Label();
            this.tbFiltroNombre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticuloLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAñadirArt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbActualizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPanel
            // 
            this.dgvPanel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPanel.Location = new System.Drawing.Point(27, 103);
            this.dgvPanel.Name = "dgvPanel";
            this.dgvPanel.Size = new System.Drawing.Size(704, 350);
            this.dgvPanel.TabIndex = 0;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(320, 476);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(105, 35);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "    Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(611, 476);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(120, 35);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "       Añadir Articulo";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(29, 476);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(105, 35);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "     Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(171, 476);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(105, 35);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "    Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // pbxArticuloLoad
            // 
            this.pbxArticuloLoad.Location = new System.Drawing.Point(752, 103);
            this.pbxArticuloLoad.Name = "pbxArticuloLoad";
            this.pbxArticuloLoad.Size = new System.Drawing.Size(350, 350);
            this.pbxArticuloLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxArticuloLoad.TabIndex = 5;
            this.pbxArticuloLoad.TabStop = false;
            // 
            // pbAñadirArt
            // 
            this.pbAñadirArt.Image = ((System.Drawing.Image)(resources.GetObject("pbAñadirArt.Image")));
            this.pbAñadirArt.Location = new System.Drawing.Point(622, 484);
            this.pbAñadirArt.Name = "pbAñadirArt";
            this.pbAñadirArt.Size = new System.Drawing.Size(20, 20);
            this.pbAñadirArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAñadirArt.TabIndex = 6;
            this.pbAñadirArt.TabStop = false;
            // 
            // pbActualizar
            // 
            this.pbActualizar.Image = ((System.Drawing.Image)(resources.GetObject("pbActualizar.Image")));
            this.pbActualizar.Location = new System.Drawing.Point(331, 484);
            this.pbActualizar.Name = "pbActualizar";
            this.pbActualizar.Size = new System.Drawing.Size(20, 20);
            this.pbActualizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbActualizar.TabIndex = 7;
            this.pbActualizar.TabStop = false;
            // 
            // pbEliminar
            // 
            this.pbEliminar.Image = ((System.Drawing.Image)(resources.GetObject("pbEliminar.Image")));
            this.pbEliminar.Location = new System.Drawing.Point(182, 483);
            this.pbEliminar.Name = "pbEliminar";
            this.pbEliminar.Size = new System.Drawing.Size(20, 20);
            this.pbEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEliminar.TabIndex = 8;
            this.pbEliminar.TabStop = false;
            // 
            // pbEditar
            // 
            this.pbEditar.Image = ((System.Drawing.Image)(resources.GetObject("pbEditar.Image")));
            this.pbEditar.Location = new System.Drawing.Point(42, 483);
            this.pbEditar.Name = "pbEditar";
            this.pbEditar.Size = new System.Drawing.Size(20, 20);
            this.pbEditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEditar.TabIndex = 9;
            this.pbEditar.TabStop = false;
            // 
            // lblFiltroNombre
            // 
            this.lblFiltroNombre.AutoSize = true;
            this.lblFiltroNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltroNombre.Location = new System.Drawing.Point(24, 49);
            this.lblFiltroNombre.Name = "lblFiltroNombre";
            this.lblFiltroNombre.Size = new System.Drawing.Size(143, 15);
            this.lblFiltroNombre.TabIndex = 10;
            this.lblFiltroNombre.Text = "Nombre / Código artículo";
            this.lblFiltroNombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbFiltroNombre
            // 
            this.tbFiltroNombre.Location = new System.Drawing.Point(27, 77);
            this.tbFiltroNombre.Name = "tbFiltroNombre";
            this.tbFiltroNombre.Size = new System.Drawing.Size(173, 20);
            this.tbFiltroNombre.TabIndex = 11;
            // 
            // frmVentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1114, 531);
            this.Controls.Add(this.tbFiltroNombre);
            this.Controls.Add(this.lblFiltroNombre);
            this.Controls.Add(this.pbEditar);
            this.Controls.Add(this.pbEliminar);
            this.Controls.Add(this.pbActualizar);
            this.Controls.Add(this.pbAñadirArt);
            this.Controls.Add(this.pbxArticuloLoad);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.dgvPanel);
            this.Name = "frmVentanaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frnVentanaPrincipal";
            this.Load += new System.EventHandler(this.frmVentanaPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticuloLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAñadirArt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbActualizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPanel;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.PictureBox pbxArticuloLoad;
        private System.Windows.Forms.PictureBox pbAñadirArt;
        private System.Windows.Forms.PictureBox pbActualizar;
        private System.Windows.Forms.PictureBox pbEliminar;
        private System.Windows.Forms.PictureBox pbEditar;
        private System.Windows.Forms.Label lblFiltroNombre;
        private System.Windows.Forms.TextBox tbFiltroNombre;
    }
}