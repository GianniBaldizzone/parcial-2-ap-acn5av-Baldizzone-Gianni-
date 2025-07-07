namespace FlameTome.Frontend
{
    partial class PanelUsuarios
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            tabla_usuarios = new Guna.UI2.WinForms.Guna2DataGridView();
            id = new DataGridViewTextBoxColumn();
            nombre_usuario = new DataGridViewTextBoxColumn();
            contraseña = new DataGridViewTextBoxColumn();
            fecha_creacion = new DataGridViewTextBoxColumn();
            fecha_modificacion = new DataGridViewTextBoxColumn();
            id_rol = new DataGridViewTextBoxColumn();
            activo = new DataGridViewTextBoxColumn();
            btn_crear = new Button();
            btnSiguiente = new Button();
            btnAnterior = new Button();
            lbl_pagina = new Label();
            ((System.ComponentModel.ISupportInitialize)tabla_usuarios).BeginInit();
            SuspendLayout();
            // 
            // tabla_usuarios
            // 
            tabla_usuarios.AllowUserToAddRows = false;
            tabla_usuarios.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(189, 223, 251);
            tabla_usuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            tabla_usuarios.Anchor = AnchorStyles.None;
            tabla_usuarios.BackgroundColor = Color.LightCyan;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(33, 150, 242);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            tabla_usuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            tabla_usuarios.ColumnHeadersHeight = 17;
            tabla_usuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            tabla_usuarios.Columns.AddRange(new DataGridViewColumn[] { id, nombre_usuario, contraseña, fecha_creacion, fecha_modificacion, id_rol, activo });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(211, 233, 252);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(107, 185, 246);
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            tabla_usuarios.DefaultCellStyle = dataGridViewCellStyle6;
            tabla_usuarios.GridColor = Color.White;
            tabla_usuarios.Location = new Point(79, 68);
            tabla_usuarios.Name = "tabla_usuarios";
            tabla_usuarios.ReadOnly = true;
            tabla_usuarios.RowHeadersVisible = false;
            tabla_usuarios.Size = new Size(784, 449);
            tabla_usuarios.TabIndex = 1;
            tabla_usuarios.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Blue;
            tabla_usuarios.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(189, 223, 251);
            tabla_usuarios.ThemeStyle.AlternatingRowsStyle.Font = null;
            tabla_usuarios.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            tabla_usuarios.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            tabla_usuarios.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            tabla_usuarios.ThemeStyle.BackColor = Color.LightCyan;
            tabla_usuarios.ThemeStyle.GridColor = Color.White;
            tabla_usuarios.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(33, 150, 242);
            tabla_usuarios.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            tabla_usuarios.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            tabla_usuarios.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            tabla_usuarios.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            tabla_usuarios.ThemeStyle.HeaderStyle.Height = 17;
            tabla_usuarios.ThemeStyle.ReadOnly = true;
            tabla_usuarios.ThemeStyle.RowsStyle.BackColor = Color.FromArgb(211, 233, 252);
            tabla_usuarios.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            tabla_usuarios.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            tabla_usuarios.ThemeStyle.RowsStyle.ForeColor = Color.Black;
            tabla_usuarios.ThemeStyle.RowsStyle.Height = 25;
            tabla_usuarios.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(107, 185, 246);
            tabla_usuarios.ThemeStyle.RowsStyle.SelectionForeColor = Color.Black;
            // 
            // id
            // 
            id.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            id.HeaderText = "id";
            id.Name = "id";
            id.ReadOnly = true;
            id.Resizable = DataGridViewTriState.True;
            id.Width = 40;
            // 
            // nombre_usuario
            // 
            nombre_usuario.HeaderText = "nombre_usuario";
            nombre_usuario.Name = "nombre_usuario";
            nombre_usuario.ReadOnly = true;
            // 
            // contraseña
            // 
            contraseña.HeaderText = "contraseña";
            contraseña.Name = "contraseña";
            contraseña.ReadOnly = true;
            // 
            // fecha_creacion
            // 
            fecha_creacion.HeaderText = "fecha_creacion";
            fecha_creacion.Name = "fecha_creacion";
            fecha_creacion.ReadOnly = true;
            // 
            // fecha_modificacion
            // 
            fecha_modificacion.HeaderText = "fecha_modificacion";
            fecha_modificacion.Name = "fecha_modificacion";
            fecha_modificacion.ReadOnly = true;
            // 
            // id_rol
            // 
            id_rol.HeaderText = "id_rol";
            id_rol.Name = "id_rol";
            id_rol.ReadOnly = true;
            // 
            // activo
            // 
            activo.HeaderText = "activo";
            activo.Name = "activo";
            activo.ReadOnly = true;
            // 
            // btn_crear
            // 
            btn_crear.Anchor = AnchorStyles.None;
            btn_crear.BackColor = Color.DeepSkyBlue;
            btn_crear.Font = new Font("Swis721 BlkCn BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_crear.ForeColor = SystemColors.ButtonHighlight;
            btn_crear.Location = new Point(685, 3);
            btn_crear.Name = "btn_crear";
            btn_crear.Size = new Size(178, 42);
            btn_crear.TabIndex = 2;
            btn_crear.Text = "Crear usuario";
            btn_crear.UseVisualStyleBackColor = false;
            // 
            // btnSiguiente
            // 
            btnSiguiente.BackColor = Color.DeepSkyBlue;
            btnSiguiente.Font = new Font("Swis721 BlkCn BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSiguiente.ForeColor = SystemColors.ButtonHighlight;
            btnSiguiente.Location = new Point(755, 533);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(108, 32);
            btnSiguiente.TabIndex = 3;
            btnSiguiente.Text = "Siguiente";
            btnSiguiente.UseVisualStyleBackColor = false;
            btnSiguiente.Click += btnSiguiente_Click_1;
            // 
            // btnAnterior
            // 
            btnAnterior.BackColor = Color.DeepSkyBlue;
            btnAnterior.Font = new Font("Swis721 BlkCn BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAnterior.ForeColor = SystemColors.ButtonFace;
            btnAnterior.Location = new Point(545, 533);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(116, 32);
            btnAnterior.TabIndex = 4;
            btnAnterior.Text = "Anterior";
            btnAnterior.UseVisualStyleBackColor = false;
            btnAnterior.Click += btnAnterior_Click_1;
            // 
            // lbl_pagina
            // 
            lbl_pagina.AutoSize = true;
            lbl_pagina.Font = new Font("Swis721 BlkCn BT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_pagina.ForeColor = SystemColors.ButtonHighlight;
            lbl_pagina.Location = new Point(676, 543);
            lbl_pagina.Name = "lbl_pagina";
            lbl_pagina.Size = new Size(31, 15);
            lbl_pagina.TabIndex = 5;
            lbl_pagina.Text = "label";
            // 
            // PanelUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbl_pagina);
            Controls.Add(btnAnterior);
            Controls.Add(btnSiguiente);
            Controls.Add(btn_crear);
            Controls.Add(tabla_usuarios);
            Name = "PanelUsuarios";
            Size = new Size(966, 593);
            ((System.ComponentModel.ISupportInitialize)tabla_usuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView tabla_usuarios;
        private Button btn_crear;
        private DataGridViewTextBoxColumn nombre_usuario;
        private DataGridViewTextBoxColumn contraseña;
        private DataGridViewTextBoxColumn fecha_creacion;
        private DataGridViewTextBoxColumn fecha_modificacion;
        private DataGridViewTextBoxColumn id_rol;
        private DataGridViewTextBoxColumn activo;
        private DataGridViewTextBoxColumn id;
        private Button btnSiguiente;
        private Button btnAnterior;
        private Label lbl_pagina;
    }
}
