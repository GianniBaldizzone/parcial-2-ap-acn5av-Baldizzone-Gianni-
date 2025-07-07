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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            tabla_usuarios = new Guna.UI2.WinForms.Guna2DataGridView();
            id = new DataGridViewTextBoxColumn();
            nombre_usuario = new DataGridViewTextBoxColumn();
            contraseña = new DataGridViewTextBoxColumn();
            fecha_creacion = new DataGridViewTextBoxColumn();
            fecha_modificacion = new DataGridViewTextBoxColumn();
            id_rol = new DataGridViewTextBoxColumn();
            activo = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)tabla_usuarios).BeginInit();
            SuspendLayout();
            // 
            // tabla_usuarios
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(189, 223, 251);
            tabla_usuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            tabla_usuarios.Anchor = AnchorStyles.None;
            tabla_usuarios.BackgroundColor = Color.PowderBlue;
            tabla_usuarios.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(33, 150, 242);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            tabla_usuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            tabla_usuarios.ColumnHeadersHeight = 17;
            tabla_usuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            tabla_usuarios.Columns.AddRange(new DataGridViewColumn[] { id, nombre_usuario, contraseña, fecha_creacion, fecha_modificacion, id_rol, activo });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(211, 233, 252);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(107, 185, 246);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            tabla_usuarios.DefaultCellStyle = dataGridViewCellStyle3;
            tabla_usuarios.GridColor = Color.FromArgb(187, 222, 251);
            tabla_usuarios.Location = new Point(79, 68);
            tabla_usuarios.Name = "tabla_usuarios";
            tabla_usuarios.RowHeadersVisible = false;
            tabla_usuarios.Size = new Size(784, 449);
            tabla_usuarios.TabIndex = 1;
            tabla_usuarios.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Blue;
            tabla_usuarios.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(189, 223, 251);
            tabla_usuarios.ThemeStyle.AlternatingRowsStyle.Font = null;
            tabla_usuarios.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            tabla_usuarios.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            tabla_usuarios.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            tabla_usuarios.ThemeStyle.BackColor = Color.PowderBlue;
            tabla_usuarios.ThemeStyle.GridColor = Color.FromArgb(187, 222, 251);
            tabla_usuarios.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(33, 150, 242);
            tabla_usuarios.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            tabla_usuarios.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            tabla_usuarios.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            tabla_usuarios.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            tabla_usuarios.ThemeStyle.HeaderStyle.Height = 17;
            tabla_usuarios.ThemeStyle.ReadOnly = false;
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
            id.Width = 40;
            // 
            // nombre_usuario
            // 
            nombre_usuario.HeaderText = "nombre_usuario";
            nombre_usuario.Name = "nombre_usuario";
            // 
            // contraseña
            // 
            contraseña.HeaderText = "contraseña";
            contraseña.Name = "contraseña";
            // 
            // fecha_creacion
            // 
            fecha_creacion.HeaderText = "fecha_creacion";
            fecha_creacion.Name = "fecha_creacion";
            // 
            // fecha_modificacion
            // 
            fecha_modificacion.HeaderText = "fecha_modificacion";
            fecha_modificacion.Name = "fecha_modificacion";
            // 
            // id_rol
            // 
            id_rol.HeaderText = "id_rol";
            id_rol.Name = "id_rol";
            // 
            // activo
            // 
            activo.HeaderText = "activo";
            activo.Name = "activo";
            // 
            // PanelUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabla_usuarios);
            Name = "PanelUsuarios";
            Size = new Size(966, 593);
            ((System.ComponentModel.ISupportInitialize)tabla_usuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView tabla_usuarios;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn nombre_usuario;
        private DataGridViewTextBoxColumn contraseña;
        private DataGridViewTextBoxColumn fecha_creacion;
        private DataGridViewTextBoxColumn fecha_modificacion;
        private DataGridViewTextBoxColumn id_rol;
        private DataGridViewTextBoxColumn activo;
    }
}
