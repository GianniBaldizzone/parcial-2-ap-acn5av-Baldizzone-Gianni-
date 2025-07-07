namespace FlameTome.Frontend
{
    partial class PanelPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelPrincipal));
            pictureBox1 = new PictureBox();
            panel_contenedor = new Panel();
            btn_bibliotecas = new Button();
            btn_categorias = new Button();
            btn_series = new Button();
            btn_mangas = new Button();
            btn_usuarios = new Button();
            btn_cerrarsesion = new Button();
            lbl_usuario = new Label();
            lbl_rol = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(25, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(178, 180);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel_contenedor
            // 
            panel_contenedor.Anchor = AnchorStyles.None;
            panel_contenedor.BackColor = Color.DarkOrange;
            panel_contenedor.Location = new Point(220, 59);
            panel_contenedor.Name = "panel_contenedor";
            panel_contenedor.Size = new Size(1225, 595);
            panel_contenedor.TabIndex = 2;
            // 
            // btn_bibliotecas
            // 
            btn_bibliotecas.Anchor = AnchorStyles.None;
            btn_bibliotecas.BackColor = Color.DarkOrange;
            btn_bibliotecas.Font = new Font("Swis721 BlkCn BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_bibliotecas.ForeColor = SystemColors.ButtonHighlight;
            btn_bibliotecas.Location = new Point(25, 220);
            btn_bibliotecas.Name = "btn_bibliotecas";
            btn_bibliotecas.Size = new Size(178, 42);
            btn_bibliotecas.TabIndex = 0;
            btn_bibliotecas.Text = "Bibliotecas";
            btn_bibliotecas.UseVisualStyleBackColor = false;
            // 
            // btn_categorias
            // 
            btn_categorias.Anchor = AnchorStyles.None;
            btn_categorias.BackColor = Color.DarkOrange;
            btn_categorias.Font = new Font("Swis721 BlkCn BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_categorias.ForeColor = SystemColors.ButtonHighlight;
            btn_categorias.Location = new Point(25, 279);
            btn_categorias.Name = "btn_categorias";
            btn_categorias.Size = new Size(178, 36);
            btn_categorias.TabIndex = 3;
            btn_categorias.Text = "Categorias";
            btn_categorias.UseVisualStyleBackColor = false;
            // 
            // btn_series
            // 
            btn_series.Anchor = AnchorStyles.None;
            btn_series.BackColor = Color.DarkOrange;
            btn_series.Font = new Font("Swis721 BlkCn BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_series.ForeColor = SystemColors.ButtonHighlight;
            btn_series.Location = new Point(25, 329);
            btn_series.Name = "btn_series";
            btn_series.Size = new Size(178, 37);
            btn_series.TabIndex = 4;
            btn_series.Text = "Series";
            btn_series.UseVisualStyleBackColor = false;
            // 
            // btn_mangas
            // 
            btn_mangas.Anchor = AnchorStyles.None;
            btn_mangas.BackColor = Color.DarkOrange;
            btn_mangas.Font = new Font("Swis721 BlkCn BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_mangas.ForeColor = SystemColors.ButtonHighlight;
            btn_mangas.Location = new Point(25, 384);
            btn_mangas.Name = "btn_mangas";
            btn_mangas.Size = new Size(178, 38);
            btn_mangas.TabIndex = 5;
            btn_mangas.Text = "Mangas";
            btn_mangas.UseVisualStyleBackColor = false;
            // 
            // btn_usuarios
            // 
            btn_usuarios.Anchor = AnchorStyles.None;
            btn_usuarios.BackColor = Color.DodgerBlue;
            btn_usuarios.Font = new Font("Swis721 BlkCn BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_usuarios.ForeColor = SystemColors.ButtonHighlight;
            btn_usuarios.Image = (Image)resources.GetObject("btn_usuarios.Image");
            btn_usuarios.ImageAlign = ContentAlignment.MiddleLeft;
            btn_usuarios.Location = new Point(25, 541);
            btn_usuarios.Name = "btn_usuarios";
            btn_usuarios.Size = new Size(178, 43);
            btn_usuarios.TabIndex = 6;
            btn_usuarios.Text = "Usuarios";
            btn_usuarios.UseVisualStyleBackColor = false;
            btn_usuarios.Click += btn_usuarios_Click;
            // 
            // btn_cerrarsesion
            // 
            btn_cerrarsesion.Anchor = AnchorStyles.None;
            btn_cerrarsesion.BackColor = Color.Red;
            btn_cerrarsesion.Font = new Font("Swis721 BlkCn BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_cerrarsesion.ForeColor = SystemColors.ButtonHighlight;
            btn_cerrarsesion.Image = (Image)resources.GetObject("btn_cerrarsesion.Image");
            btn_cerrarsesion.ImageAlign = ContentAlignment.MiddleLeft;
            btn_cerrarsesion.Location = new Point(25, 602);
            btn_cerrarsesion.Name = "btn_cerrarsesion";
            btn_cerrarsesion.Size = new Size(178, 52);
            btn_cerrarsesion.TabIndex = 8;
            btn_cerrarsesion.Text = "Cerrar sesión";
            btn_cerrarsesion.UseVisualStyleBackColor = false;
            btn_cerrarsesion.Click += btn_cerrarsesion_Click;
            // 
            // lbl_usuario
            // 
            lbl_usuario.Anchor = AnchorStyles.None;
            lbl_usuario.AutoSize = true;
            lbl_usuario.BackColor = Color.SandyBrown;
            lbl_usuario.Font = new Font("Swis721 BlkCn BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_usuario.ForeColor = SystemColors.ButtonHighlight;
            lbl_usuario.Location = new Point(220, 23);
            lbl_usuario.Name = "lbl_usuario";
            lbl_usuario.Size = new Size(85, 19);
            lbl_usuario.TabIndex = 0;
            lbl_usuario.Text = "Bienvenido ";
            // 
            // lbl_rol
            // 
            lbl_rol.Anchor = AnchorStyles.None;
            lbl_rol.AutoSize = true;
            lbl_rol.BackColor = Color.SandyBrown;
            lbl_rol.Font = new Font("Swis721 BlkCn BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_rol.ForeColor = SystemColors.ButtonHighlight;
            lbl_rol.Location = new Point(1313, 23);
            lbl_rol.Name = "lbl_rol";
            lbl_rol.Size = new Size(132, 19);
            lbl_rol.TabIndex = 9;
            lbl_rol.Text = "Rol: Administrador";
            lbl_rol.TextAlign = ContentAlignment.BottomRight;
            // 
            // PanelPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1472, 729);
            Controls.Add(lbl_rol);
            Controls.Add(lbl_usuario);
            Controls.Add(btn_cerrarsesion);
            Controls.Add(btn_usuarios);
            Controls.Add(btn_mangas);
            Controls.Add(btn_series);
            Controls.Add(btn_categorias);
            Controls.Add(btn_bibliotecas);
            Controls.Add(panel_contenedor);
            Controls.Add(pictureBox1);
            Name = "PanelPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PanelPrincipal";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel_contenedor;
        private Button btn_bibliotecas;
        private Button btn_categorias;
        private Button btn_series;
        private Button btn_mangas;
        private Button btn_usuarios;
        private Button btn_cerrarsesion;
        private Label lbl_rol;
        private Label lbl_usuario;
    }
}