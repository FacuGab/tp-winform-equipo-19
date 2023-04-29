namespace WinformApp
{
    partial class frmMenuPrincipal
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            BarraTitulo = new Panel();
            btnNormal = new PictureBox();
            btnMaximizar = new PictureBox();
            btnMinimizar = new PictureBox();
            btnCerrar = new PictureBox();
            MenuVertical = new Panel();
            panel3 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            button5 = new Button();
            panel4 = new Panel();
            button6 = new Button();
            button3 = new Button();
            panel7 = new Panel();
            panel8 = new Panel();
            button7 = new Button();
            button8 = new Button();
            btnGestionArt = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            button2 = new Button();
            btnCargaArticulo = new Button();
            IcoMenu = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            imgPrincipal = new PictureBox();
            BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnNormal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            MenuVertical.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel7.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)IcoMenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgPrincipal).BeginInit();
            SuspendLayout();
            // 
            // BarraTitulo
            // 
            BarraTitulo.BackColor = Color.FromArgb(255, 153, 51);
            BarraTitulo.Controls.Add(btnNormal);
            BarraTitulo.Controls.Add(btnMaximizar);
            BarraTitulo.Controls.Add(btnMinimizar);
            BarraTitulo.Controls.Add(btnCerrar);
            BarraTitulo.Dock = DockStyle.Top;
            BarraTitulo.Location = new Point(0, 0);
            BarraTitulo.Name = "BarraTitulo";
            BarraTitulo.Size = new Size(1350, 38);
            BarraTitulo.TabIndex = 0;
            // 
            // btnNormal
            // 
            btnNormal.Anchor = AnchorStyles.Right;
            btnNormal.Image = (Image)resources.GetObject("btnNormal.Image");
            btnNormal.Location = new Point(1289, 7);
            btnNormal.Name = "btnNormal";
            btnNormal.Size = new Size(21, 21);
            btnNormal.SizeMode = PictureBoxSizeMode.Zoom;
            btnNormal.TabIndex = 3;
            btnNormal.TabStop = false;
            btnNormal.Visible = false;
            btnNormal.Click += btnNormal_Click;
            // 
            // btnMaximizar
            // 
            btnMaximizar.Anchor = AnchorStyles.Right;
            btnMaximizar.Image = (Image)resources.GetObject("btnMaximizar.Image");
            btnMaximizar.Location = new Point(1289, 7);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(21, 21);
            btnMaximizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMaximizar.TabIndex = 2;
            btnMaximizar.TabStop = false;
            btnMaximizar.Click += btnMaximizar_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Right;
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(1258, 7);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(21, 21);
            btnMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinimizar.TabIndex = 1;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Right;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(1320, 7);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(21, 21);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 0;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // MenuVertical
            // 
            MenuVertical.BackColor = Color.FromArgb(36, 32, 40);
            MenuVertical.Controls.Add(panel3);
            MenuVertical.Controls.Add(btnGestionArt);
            MenuVertical.Controls.Add(panel1);
            MenuVertical.Controls.Add(btnCargaArticulo);
            MenuVertical.Controls.Add(IcoMenu);
            MenuVertical.Dock = DockStyle.Left;
            MenuVertical.Location = new Point(0, 38);
            MenuVertical.Name = "MenuVertical";
            MenuVertical.Size = new Size(220, 612);
            MenuVertical.TabIndex = 1;
            MenuVertical.Paint += MenuVertical_Paint;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gray;
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(button6);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(panel7);
            panel3.Controls.Add(button8);
            panel3.Location = new Point(0, 250);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(1);
            panel3.Size = new Size(5, 35);
            panel3.TabIndex = 4;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(255, 153, 51);
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(button5);
            panel5.Location = new Point(0, 70);
            panel5.Name = "panel5";
            panel5.Size = new Size(5, 35);
            panel5.TabIndex = 8;
            // 
            // panel6
            // 
            panel6.Location = new Point(-105, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(10, 23);
            panel6.TabIndex = 4;
            // 
            // button5
            // 
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 153, 51);
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = SystemColors.Control;
            button5.Location = new Point(-105, 0);
            button5.Name = "button5";
            button5.Size = new Size(10, 23);
            button5.TabIndex = 3;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Location = new Point(-105, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(10, 23);
            panel4.TabIndex = 4;
            // 
            // button6
            // 
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 153, 51);
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button6.ForeColor = SystemColors.Control;
            button6.Location = new Point(3, 70);
            button6.Name = "button6";
            button6.Size = new Size(215, 35);
            button6.TabIndex = 7;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 153, 51);
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = SystemColors.Control;
            button3.Location = new Point(-105, 0);
            button3.Name = "button3";
            button3.Size = new Size(10, 23);
            button3.TabIndex = 3;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(255, 153, 51);
            panel7.Controls.Add(panel8);
            panel7.Controls.Add(button7);
            panel7.Location = new Point(0, 41);
            panel7.Name = "panel7";
            panel7.Size = new Size(5, 35);
            panel7.TabIndex = 6;
            // 
            // panel8
            // 
            panel8.Location = new Point(-105, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(10, 23);
            panel8.TabIndex = 4;
            // 
            // button7
            // 
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 153, 51);
            button7.FlatStyle = FlatStyle.Flat;
            button7.ForeColor = SystemColors.Control;
            button7.Location = new Point(-105, 0);
            button7.Name = "button7";
            button7.Size = new Size(10, 23);
            button7.TabIndex = 3;
            button7.Text = "button7";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 153, 51);
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button8.ForeColor = SystemColors.Control;
            button8.Location = new Point(5, 41);
            button8.Name = "button8";
            button8.Size = new Size(215, 35);
            button8.TabIndex = 5;
            button8.Text = "Carga de Artículos";
            button8.UseVisualStyleBackColor = true;
            // 
            // btnGestionArt
            // 
            btnGestionArt.FlatAppearance.BorderSize = 0;
            btnGestionArt.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 153, 51);
            btnGestionArt.FlatStyle = FlatStyle.Flat;
            btnGestionArt.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnGestionArt.ForeColor = SystemColors.Control;
            btnGestionArt.Location = new Point(5, 250);
            btnGestionArt.Name = "btnGestionArt";
            btnGestionArt.Padding = new Padding(1);
            btnGestionArt.Size = new Size(215, 35);
            btnGestionArt.TabIndex = 3;
            btnGestionArt.Text = "Gestion de Artículos";
            btnGestionArt.UseVisualStyleBackColor = true;
            btnGestionArt.Click += btnGestionArt_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(button2);
            panel1.Location = new Point(0, 210);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(1);
            panel1.Size = new Size(5, 35);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Location = new Point(-105, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 23);
            panel2.TabIndex = 4;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 153, 51);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(-105, 0);
            button2.Name = "button2";
            button2.Size = new Size(10, 23);
            button2.TabIndex = 3;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnCargaArticulo
            // 
            btnCargaArticulo.FlatAppearance.BorderSize = 0;
            btnCargaArticulo.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 153, 51);
            btnCargaArticulo.FlatStyle = FlatStyle.Flat;
            btnCargaArticulo.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCargaArticulo.ForeColor = SystemColors.Control;
            btnCargaArticulo.Location = new Point(5, 210);
            btnCargaArticulo.Name = "btnCargaArticulo";
            btnCargaArticulo.Padding = new Padding(1);
            btnCargaArticulo.Size = new Size(215, 35);
            btnCargaArticulo.TabIndex = 1;
            btnCargaArticulo.Text = "Nuevo Artículo";
            btnCargaArticulo.UseVisualStyleBackColor = true;
            btnCargaArticulo.Click += btnCargaArticulo_Click;
            // 
            // IcoMenu
            // 
            IcoMenu.Image = (Image)resources.GetObject("IcoMenu.Image");
            IcoMenu.Location = new Point(0, 6);
            IcoMenu.Name = "IcoMenu";
            IcoMenu.Size = new Size(217, 148);
            IcoMenu.SizeMode = PictureBoxSizeMode.Zoom;
            IcoMenu.TabIndex = 0;
            IcoMenu.TabStop = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 75;
            timer1.Tick += timer1_Tick;
            // 
            // imgPrincipal
            // 
            imgPrincipal.Image = (Image)resources.GetObject("imgPrincipal.Image");
            imgPrincipal.Location = new Point(223, 38);
            imgPrincipal.Name = "imgPrincipal";
            imgPrincipal.Size = new Size(1127, 612);
            imgPrincipal.SizeMode = PictureBoxSizeMode.Zoom;
            imgPrincipal.TabIndex = 3;
            imgPrincipal.TabStop = false;
            // 
            // frmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 650);
            Controls.Add(imgPrincipal);
            Controls.Add(MenuVertical);
            Controls.Add(BarraTitulo);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Name = "frmMenuPrincipal";
            Opacity = 0D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnNormal).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            MenuVertical.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)IcoMenu).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgPrincipal).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel BarraTitulo;
        private Panel MenuVertical;
        private PictureBox btnCerrar;
        private PictureBox btnMaximizar;
        private PictureBox btnMinimizar;
        private PictureBox btnNormal;
        private PictureBox IcoMenu;
        private Button btnCargaArticulo;
        private Panel panel3;
        private Panel panel4;
        private Button button3;
        private Button btnGestionArt;
        private Panel panel1;
        private Panel panel2;
        private Button button2;
        private Panel panel5;
        private Panel panel6;
        private Button button5;
        private Button button6;
        private Panel panel7;
        private Panel panel8;
        private Button button7;
        private Button button8;
        private System.Windows.Forms.Timer timer1;
        private PictureBox imgPrincipal;
    }
}