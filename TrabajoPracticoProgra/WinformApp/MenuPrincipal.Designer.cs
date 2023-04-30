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
            panel9 = new Panel();
            panel10 = new Panel();
            panel11 = new Panel();
            button1 = new Button();
            panel12 = new Panel();
            button4 = new Button();
            button9 = new Button();
            panel13 = new Panel();
            panel14 = new Panel();
            button10 = new Button();
            button11 = new Button();
            btnVerLista = new Button();
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
            panel15 = new Panel();
            panel16 = new Panel();
            panel17 = new Panel();
            button12 = new Button();
            panel18 = new Panel();
            button13 = new Button();
            button14 = new Button();
            panel19 = new Panel();
            panel20 = new Panel();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnNormal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            MenuVertical.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            panel13.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel7.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)IcoMenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgPrincipal).BeginInit();
            panel15.SuspendLayout();
            panel16.SuspendLayout();
            panel19.SuspendLayout();
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
            MenuVertical.Controls.Add(panel15);
            MenuVertical.Controls.Add(button17);
            MenuVertical.Controls.Add(panel9);
            MenuVertical.Controls.Add(btnVerLista);
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
            // panel9
            // 
            panel9.BackColor = Color.Gray;
            panel9.Controls.Add(panel10);
            panel9.Controls.Add(panel12);
            panel9.Controls.Add(button4);
            panel9.Controls.Add(button9);
            panel9.Controls.Add(panel13);
            panel9.Controls.Add(button11);
            panel9.Location = new Point(0, 289);
            panel9.Name = "panel9";
            panel9.Padding = new Padding(1);
            panel9.Size = new Size(5, 35);
            panel9.TabIndex = 6;
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(255, 153, 51);
            panel10.Controls.Add(panel11);
            panel10.Controls.Add(button1);
            panel10.Location = new Point(0, 70);
            panel10.Name = "panel10";
            panel10.Size = new Size(5, 35);
            panel10.TabIndex = 8;
            // 
            // panel11
            // 
            panel11.Location = new Point(-105, 0);
            panel11.Name = "panel11";
            panel11.Size = new Size(10, 23);
            panel11.TabIndex = 4;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 153, 51);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(-105, 0);
            button1.Name = "button1";
            button1.Size = new Size(10, 23);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel12
            // 
            panel12.Location = new Point(-105, 0);
            panel12.Name = "panel12";
            panel12.Size = new Size(10, 23);
            panel12.TabIndex = 4;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 153, 51);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.Control;
            button4.Location = new Point(3, 70);
            button4.Name = "button4";
            button4.Size = new Size(215, 35);
            button4.TabIndex = 7;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 153, 51);
            button9.FlatStyle = FlatStyle.Flat;
            button9.ForeColor = SystemColors.Control;
            button9.Location = new Point(-105, 0);
            button9.Name = "button9";
            button9.Size = new Size(10, 23);
            button9.TabIndex = 3;
            button9.Text = "button9";
            button9.UseVisualStyleBackColor = true;
            // 
            // panel13
            // 
            panel13.BackColor = Color.FromArgb(255, 153, 51);
            panel13.Controls.Add(panel14);
            panel13.Controls.Add(button10);
            panel13.Location = new Point(0, 41);
            panel13.Name = "panel13";
            panel13.Size = new Size(5, 35);
            panel13.TabIndex = 6;
            // 
            // panel14
            // 
            panel14.Location = new Point(-105, 0);
            panel14.Name = "panel14";
            panel14.Size = new Size(10, 23);
            panel14.TabIndex = 4;
            // 
            // button10
            // 
            button10.FlatAppearance.BorderSize = 0;
            button10.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 153, 51);
            button10.FlatStyle = FlatStyle.Flat;
            button10.ForeColor = SystemColors.Control;
            button10.Location = new Point(-105, 0);
            button10.Name = "button10";
            button10.Size = new Size(10, 23);
            button10.TabIndex = 3;
            button10.Text = "button10";
            button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.FlatAppearance.BorderSize = 0;
            button11.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 153, 51);
            button11.FlatStyle = FlatStyle.Flat;
            button11.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button11.ForeColor = SystemColors.Control;
            button11.Location = new Point(5, 41);
            button11.Name = "button11";
            button11.Size = new Size(215, 35);
            button11.TabIndex = 5;
            button11.Text = "Carga de Artículos";
            button11.UseVisualStyleBackColor = true;
            // 
            // btnVerLista
            // 
            btnVerLista.FlatAppearance.BorderSize = 0;
            btnVerLista.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 153, 51);
            btnVerLista.FlatStyle = FlatStyle.Flat;
            btnVerLista.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnVerLista.ForeColor = SystemColors.Control;
            btnVerLista.Location = new Point(5, 289);
            btnVerLista.Name = "btnVerLista";
            btnVerLista.Padding = new Padding(1);
            btnVerLista.Size = new Size(215, 35);
            btnVerLista.TabIndex = 5;
            btnVerLista.Text = "Ver listado";
            btnVerLista.UseVisualStyleBackColor = true;
            btnVerLista.Click += btnVerLista_Click;
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
            // panel15
            // 
            panel15.BackColor = Color.Gray;
            panel15.Controls.Add(panel16);
            panel15.Controls.Add(panel18);
            panel15.Controls.Add(button13);
            panel15.Controls.Add(button14);
            panel15.Controls.Add(panel19);
            panel15.Controls.Add(button16);
            panel15.Location = new Point(-2, 327);
            panel15.Name = "panel15";
            panel15.Padding = new Padding(1);
            panel15.Size = new Size(5, 35);
            panel15.TabIndex = 8;
            // 
            // panel16
            // 
            panel16.BackColor = Color.FromArgb(255, 153, 51);
            panel16.Controls.Add(panel17);
            panel16.Controls.Add(button12);
            panel16.Location = new Point(0, 70);
            panel16.Name = "panel16";
            panel16.Size = new Size(5, 35);
            panel16.TabIndex = 8;
            // 
            // panel17
            // 
            panel17.Location = new Point(-105, 0);
            panel17.Name = "panel17";
            panel17.Size = new Size(10, 23);
            panel17.TabIndex = 4;
            // 
            // button12
            // 
            button12.FlatAppearance.BorderSize = 0;
            button12.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 153, 51);
            button12.FlatStyle = FlatStyle.Flat;
            button12.ForeColor = SystemColors.Control;
            button12.Location = new Point(-105, 0);
            button12.Name = "button12";
            button12.Size = new Size(10, 23);
            button12.TabIndex = 3;
            button12.Text = "button12";
            button12.UseVisualStyleBackColor = true;
            // 
            // panel18
            // 
            panel18.Location = new Point(-105, 0);
            panel18.Name = "panel18";
            panel18.Size = new Size(10, 23);
            panel18.TabIndex = 4;
            // 
            // button13
            // 
            button13.FlatAppearance.BorderSize = 0;
            button13.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 153, 51);
            button13.FlatStyle = FlatStyle.Flat;
            button13.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button13.ForeColor = SystemColors.Control;
            button13.Location = new Point(3, 70);
            button13.Name = "button13";
            button13.Size = new Size(215, 35);
            button13.TabIndex = 7;
            button13.Text = "button13";
            button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            button14.FlatAppearance.BorderSize = 0;
            button14.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 153, 51);
            button14.FlatStyle = FlatStyle.Flat;
            button14.ForeColor = SystemColors.Control;
            button14.Location = new Point(-105, 0);
            button14.Name = "button14";
            button14.Size = new Size(10, 23);
            button14.TabIndex = 3;
            button14.Text = "button14";
            button14.UseVisualStyleBackColor = true;
            // 
            // panel19
            // 
            panel19.BackColor = Color.FromArgb(255, 153, 51);
            panel19.Controls.Add(panel20);
            panel19.Controls.Add(button15);
            panel19.Location = new Point(0, 41);
            panel19.Name = "panel19";
            panel19.Size = new Size(5, 35);
            panel19.TabIndex = 6;
            // 
            // panel20
            // 
            panel20.Location = new Point(-105, 0);
            panel20.Name = "panel20";
            panel20.Size = new Size(10, 23);
            panel20.TabIndex = 4;
            // 
            // button15
            // 
            button15.FlatAppearance.BorderSize = 0;
            button15.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 153, 51);
            button15.FlatStyle = FlatStyle.Flat;
            button15.ForeColor = SystemColors.Control;
            button15.Location = new Point(-105, 0);
            button15.Name = "button15";
            button15.Size = new Size(10, 23);
            button15.TabIndex = 3;
            button15.Text = "button15";
            button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            button16.FlatAppearance.BorderSize = 0;
            button16.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 153, 51);
            button16.FlatStyle = FlatStyle.Flat;
            button16.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button16.ForeColor = SystemColors.Control;
            button16.Location = new Point(5, 41);
            button16.Name = "button16";
            button16.Size = new Size(215, 35);
            button16.TabIndex = 5;
            button16.Text = "Carga de Artículos";
            button16.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            button17.FlatAppearance.BorderSize = 0;
            button17.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 153, 51);
            button17.FlatStyle = FlatStyle.Flat;
            button17.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button17.ForeColor = SystemColors.Control;
            button17.Location = new Point(3, 327);
            button17.Name = "button17";
            button17.Padding = new Padding(1);
            button17.Size = new Size(215, 35);
            button17.TabIndex = 7;
            button17.Text = "No ver listado";
            button17.UseVisualStyleBackColor = true;
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
            panel9.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel13.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)IcoMenu).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgPrincipal).EndInit();
            panel15.ResumeLayout(false);
            panel16.ResumeLayout(false);
            panel19.ResumeLayout(false);
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
        private Panel panel9;
        private Panel panel10;
        private Panel panel11;
        private Button button1;
        private Panel panel12;
        private Button button4;
        private Button button9;
        private Panel panel13;
        private Panel panel14;
        private Button button10;
        private Button button11;
        private Button btnVerLista;
        private Panel panel15;
        private Panel panel16;
        private Panel panel17;
        private Button button12;
        private Panel panel18;
        private Button button13;
        private Button button14;
        private Panel panel19;
        private Panel panel20;
        private Button button15;
        private Button button16;
        private Button button17;
    }
}