namespace FlameTome.Frontend
{
    partial class Login
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txt_password = new Guna.UI2.WinForms.Guna2TextBox();
            txt_user = new Guna.UI2.WinForms.Guna2TextBox();
            SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.ForeColor = Color.Blue;
            guna2HtmlLabel1.Location = new Point(286, 118);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(43, 17);
            guna2HtmlLabel1.TabIndex = 0;
            guna2HtmlLabel1.Text = "Usuario";
            guna2HtmlLabel1.Click += guna2HtmlLabel1_Click;
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.ForeColor = Color.Blue;
            guna2HtmlLabel2.Location = new Point(286, 210);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(63, 17);
            guna2HtmlLabel2.TabIndex = 1;
            guna2HtmlLabel2.Text = "Contraseña";
            // 
            // txt_password
            // 
            txt_password.CustomizableEdges = customizableEdges1;
            txt_password.DefaultText = "";
            txt_password.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txt_password.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txt_password.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txt_password.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txt_password.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_password.Font = new Font("Segoe UI", 9F);
            txt_password.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_password.Location = new Point(286, 245);
            txt_password.Name = "txt_password";
            txt_password.PlaceholderText = "";
            txt_password.SelectedText = "";
            txt_password.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txt_password.Size = new Size(200, 36);
            txt_password.TabIndex = 2;
            txt_password.TextChanged += txt_password_TextChanged;
            // 
            // txt_user
            // 
            txt_user.CustomizableEdges = customizableEdges3;
            txt_user.DefaultText = "";
            txt_user.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txt_user.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txt_user.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txt_user.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txt_user.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_user.Font = new Font("Segoe UI", 9F);
            txt_user.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_user.Location = new Point(286, 158);
            txt_user.Name = "txt_user";
            txt_user.PlaceholderText = "";
            txt_user.SelectedText = "";
            txt_user.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txt_user.Size = new Size(200, 36);
            txt_user.TabIndex = 3;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(6F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(782, 480);
            Controls.Add(txt_user);
            Controls.Add(txt_password);
            Controls.Add(guna2HtmlLabel2);
            Controls.Add(guna2HtmlLabel1);
            Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2TextBox txt_password;
        private Guna.UI2.WinForms.Guna2TextBox txt_user;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
       
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
    }
}