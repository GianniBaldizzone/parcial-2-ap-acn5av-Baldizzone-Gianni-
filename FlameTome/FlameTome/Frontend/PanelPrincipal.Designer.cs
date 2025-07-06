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
            panel1 = new Panel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
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
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.DarkOrange;
            panel1.Location = new Point(220, 59);
            panel1.Name = "panel1";
            panel1.Size = new Size(1225, 595);
            panel1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Location = new Point(25, 224);
            button1.Name = "button1";
            button1.Size = new Size(178, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.Location = new Point(25, 262);
            button2.Name = "button2";
            button2.Size = new Size(178, 23);
            button2.TabIndex = 3;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.Location = new Point(25, 301);
            button3.Name = "button3";
            button3.Size = new Size(178, 23);
            button3.TabIndex = 4;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.Location = new Point(25, 340);
            button4.Name = "button4";
            button4.Size = new Size(178, 23);
            button4.TabIndex = 5;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.None;
            button5.Location = new Point(25, 379);
            button5.Name = "button5";
            button5.Size = new Size(178, 23);
            button5.TabIndex = 6;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.None;
            button6.Location = new Point(25, 420);
            button6.Name = "button6";
            button6.Size = new Size(178, 23);
            button6.TabIndex = 7;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
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
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
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
        private Panel panel1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button btn_cerrarsesion;
        private Label lbl_rol;
        private Label lbl_usuario;
    }
}