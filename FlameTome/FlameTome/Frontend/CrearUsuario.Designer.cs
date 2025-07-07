namespace FlameTome.Frontend
{
    partial class CrearUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearUsuario));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pictureBox1 = new PictureBox();
            txtUsuario = new Guna.UI2.WinForms.Guna2TextBox();
            idRolSeleccionado = new Guna.UI2.WinForms.Guna2ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            txtContraseña = new Guna.UI2.WinForms.Guna2TextBox();
            txtRepetirContraseña = new Guna.UI2.WinForms.Guna2TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(303, 118);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(284, 328);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtUsuario
            // 
            txtUsuario.CustomizableEdges = customizableEdges11;
            txtUsuario.DefaultText = "";
            txtUsuario.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtUsuario.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtUsuario.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtUsuario.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtUsuario.FillColor = Color.PapayaWhip;
            txtUsuario.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUsuario.Font = new Font("Swis721 BlkCn BT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUsuario.Location = new Point(66, 144);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderForeColor = Color.Black;
            txtUsuario.PlaceholderText = "";
            txtUsuario.SelectedText = "";
            txtUsuario.ShadowDecoration.CustomizableEdges = customizableEdges12;
            txtUsuario.Size = new Size(171, 29);
            txtUsuario.TabIndex = 1;
            // 
            // idRolSeleccionado
            // 
            idRolSeleccionado.BackColor = Color.Transparent;
            idRolSeleccionado.CustomizableEdges = customizableEdges13;
            idRolSeleccionado.DrawMode = DrawMode.OwnerDrawFixed;
            idRolSeleccionado.DropDownStyle = ComboBoxStyle.DropDownList;
            idRolSeleccionado.FillColor = Color.PapayaWhip;
            idRolSeleccionado.FocusedColor = Color.FromArgb(94, 148, 255);
            idRolSeleccionado.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            idRolSeleccionado.Font = new Font("Swis721 BlkCn BT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            idRolSeleccionado.ForeColor = Color.FromArgb(68, 88, 112);
            idRolSeleccionado.ItemHeight = 30;
            idRolSeleccionado.Location = new Point(66, 369);
            idRolSeleccionado.Name = "idRolSeleccionado";
            idRolSeleccionado.ShadowDecoration.CustomizableEdges = customizableEdges14;
            idRolSeleccionado.Size = new Size(140, 36);
            idRolSeleccionado.TabIndex = 4;
            idRolSeleccionado.SelectedIndexChanged += guna2ComboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Swis721 BlkCn BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkOrange;
            label1.Location = new Point(66, 122);
            label1.Name = "label1";
            label1.Size = new Size(60, 19);
            label1.TabIndex = 5;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Swis721 BlkCn BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkOrange;
            label2.Location = new Point(66, 197);
            label2.Name = "label2";
            label2.Size = new Size(85, 19);
            label2.TabIndex = 6;
            label2.Text = "Contraseña";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Swis721 BlkCn BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkOrange;
            label3.Location = new Point(66, 272);
            label3.Name = "label3";
            label3.Size = new Size(154, 19);
            label3.TabIndex = 7;
            label3.Text = "Confirmar contraseña";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Swis721 BlkCn BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkOrange;
            label4.Location = new Point(66, 347);
            label4.Name = "label4";
            label4.Size = new Size(30, 19);
            label4.TabIndex = 8;
            label4.Text = "Rol";
            // 
            // guna2GradientButton1
            // 
            guna2GradientButton1.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            guna2GradientButton1.CustomizableEdges = customizableEdges15;
            guna2GradientButton1.DisabledState.BorderColor = Color.DarkGray;
            guna2GradientButton1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2GradientButton1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2GradientButton1.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            guna2GradientButton1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2GradientButton1.FillColor = Color.DarkOrange;
            guna2GradientButton1.FillColor2 = Color.Red;
            guna2GradientButton1.Font = new Font("Swis721 BlkCn BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2GradientButton1.ForeColor = Color.White;
            guna2GradientButton1.Location = new Point(66, 454);
            guna2GradientButton1.Name = "guna2GradientButton1";
            guna2GradientButton1.ShadowDecoration.CustomizableEdges = customizableEdges16;
            guna2GradientButton1.Size = new Size(109, 45);
            guna2GradientButton1.TabIndex = 9;
            guna2GradientButton1.Text = "Guardar";
            guna2GradientButton1.Click += guna2GradientButton1_Click;
            // 
            // txtContraseña
            // 
            txtContraseña.CustomizableEdges = customizableEdges17;
            txtContraseña.DefaultText = "";
            txtContraseña.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtContraseña.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtContraseña.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtContraseña.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtContraseña.FillColor = Color.PapayaWhip;
            txtContraseña.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtContraseña.Font = new Font("Swis721 BlkCn BT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContraseña.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtContraseña.Location = new Point(66, 219);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PlaceholderForeColor = Color.Black;
            txtContraseña.PlaceholderText = "";
            txtContraseña.SelectedText = "";
            txtContraseña.ShadowDecoration.CustomizableEdges = customizableEdges18;
            txtContraseña.Size = new Size(171, 29);
            txtContraseña.TabIndex = 10;
            // 
            // txtRepetirContraseña
            // 
            txtRepetirContraseña.CustomizableEdges = customizableEdges19;
            txtRepetirContraseña.DefaultText = "";
            txtRepetirContraseña.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtRepetirContraseña.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtRepetirContraseña.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtRepetirContraseña.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtRepetirContraseña.FillColor = Color.PapayaWhip;
            txtRepetirContraseña.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtRepetirContraseña.Font = new Font("Swis721 BlkCn BT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRepetirContraseña.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtRepetirContraseña.Location = new Point(66, 294);
            txtRepetirContraseña.Name = "txtRepetirContraseña";
            txtRepetirContraseña.PlaceholderForeColor = Color.Black;
            txtRepetirContraseña.PlaceholderText = "";
            txtRepetirContraseña.SelectedText = "";
            txtRepetirContraseña.ShadowDecoration.CustomizableEdges = customizableEdges20;
            txtRepetirContraseña.Size = new Size(171, 29);
            txtRepetirContraseña.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Swis721 Blk BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkOrange;
            label5.Location = new Point(225, 46);
            label5.Name = "label5";
            label5.Size = new Size(129, 19);
            label5.TabIndex = 12;
            label5.Text = "Crear usuario";
            // 
            // CrearUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(599, 618);
            Controls.Add(label5);
            Controls.Add(txtRepetirContraseña);
            Controls.Add(txtContraseña);
            Controls.Add(guna2GradientButton1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(idRolSeleccionado);
            Controls.Add(txtUsuario);
            Controls.Add(pictureBox1);
            Name = "CrearUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CrearUsuario";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtUsuario;
        private Guna.UI2.WinForms.Guna2ComboBox idRolSeleccionado;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private Guna.UI2.WinForms.Guna2TextBox txtContraseña;
        private Guna.UI2.WinForms.Guna2TextBox txtRepetirContraseña;
        private Label label5;
    }
}