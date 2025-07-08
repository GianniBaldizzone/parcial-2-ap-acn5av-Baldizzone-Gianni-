namespace FlameTome.Frontend
{
    partial class PanelSeries
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
            lbl_pagina = new Label();
            btnAnterior = new Button();
            btnSiguiente = new Button();
            btn_crear = new Button();
            tabla_series = new Guna.UI2.WinForms.Guna2DataGridView();
            foto = new DataGridViewImageColumn();
            id = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            descripcion = new DataGridViewTextBoxColumn();
            fecha_modificacion = new DataGridViewTextBoxColumn();
            activo = new DataGridViewTextBoxColumn();
            id_categoria = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)tabla_series).BeginInit();
            SuspendLayout();
            // 
            // lbl_pagina
            // 
            lbl_pagina.AutoSize = true;
            lbl_pagina.Font = new Font("Swis721 BlkCn BT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_pagina.ForeColor = SystemColors.ButtonHighlight;
            lbl_pagina.Location = new Point(770, 552);
            lbl_pagina.Name = "lbl_pagina";
            lbl_pagina.Size = new Size(31, 15);
            lbl_pagina.TabIndex = 10;
            lbl_pagina.Text = "label";
            // 
            // btnAnterior
            // 
            btnAnterior.BackColor = Color.MediumSeaGreen;
            btnAnterior.Font = new Font("Swis721 BlkCn BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAnterior.ForeColor = SystemColors.ButtonFace;
            btnAnterior.Location = new Point(639, 542);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(116, 32);
            btnAnterior.TabIndex = 9;
            btnAnterior.Text = "Anterior";
            btnAnterior.UseVisualStyleBackColor = false;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // btnSiguiente
            // 
            btnSiguiente.BackColor = Color.MediumSeaGreen;
            btnSiguiente.Font = new Font("Swis721 BlkCn BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSiguiente.ForeColor = SystemColors.ButtonHighlight;
            btnSiguiente.Location = new Point(859, 542);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(108, 32);
            btnSiguiente.TabIndex = 8;
            btnSiguiente.Text = "Siguiente";
            btnSiguiente.UseVisualStyleBackColor = false;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // btn_crear
            // 
            btn_crear.Anchor = AnchorStyles.None;
            btn_crear.BackColor = Color.MediumSeaGreen;
            btn_crear.Font = new Font("Swis721 BlkCn BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_crear.ForeColor = SystemColors.ButtonHighlight;
            btn_crear.Location = new Point(789, 30);
            btn_crear.Name = "btn_crear";
            btn_crear.Size = new Size(178, 42);
            btn_crear.TabIndex = 7;
            btn_crear.Text = "Crear usuario";
            btn_crear.UseVisualStyleBackColor = false;
            btn_crear.Click += btn_crear_Click;
            // 
            // tabla_series
            // 
            tabla_series.AllowUserToAddRows = false;
            tabla_series.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(185, 226, 218);
            tabla_series.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            tabla_series.Anchor = AnchorStyles.None;
            tabla_series.BackgroundColor = Color.Honeydew;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(22, 160, 133);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            tabla_series.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            tabla_series.ColumnHeadersHeight = 17;
            tabla_series.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            tabla_series.Columns.AddRange(new DataGridViewColumn[] { foto, id, nombre, descripcion, fecha_modificacion, activo, id_categoria });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(208, 235, 230);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(99, 191, 173);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            tabla_series.DefaultCellStyle = dataGridViewCellStyle3;
            tabla_series.GridColor = Color.FromArgb(182, 224, 216);
            tabla_series.Location = new Point(34, 78);
            tabla_series.Name = "tabla_series";
            tabla_series.ReadOnly = true;
            tabla_series.RowHeadersVisible = false;
            tabla_series.Size = new Size(933, 449);
            tabla_series.TabIndex = 6;
            tabla_series.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.GreenSea;
            tabla_series.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(185, 226, 218);
            tabla_series.ThemeStyle.AlternatingRowsStyle.Font = null;
            tabla_series.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            tabla_series.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            tabla_series.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            tabla_series.ThemeStyle.BackColor = Color.Honeydew;
            tabla_series.ThemeStyle.GridColor = Color.FromArgb(182, 224, 216);
            tabla_series.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(22, 160, 133);
            tabla_series.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            tabla_series.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            tabla_series.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            tabla_series.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            tabla_series.ThemeStyle.HeaderStyle.Height = 17;
            tabla_series.ThemeStyle.ReadOnly = true;
            tabla_series.ThemeStyle.RowsStyle.BackColor = Color.FromArgb(208, 235, 230);
            tabla_series.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            tabla_series.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            tabla_series.ThemeStyle.RowsStyle.ForeColor = Color.Black;
            tabla_series.ThemeStyle.RowsStyle.Height = 25;
            tabla_series.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(99, 191, 173);
            tabla_series.ThemeStyle.RowsStyle.SelectionForeColor = Color.Black;
            // 
            // foto
            // 
            foto.HeaderText = "foto";
            foto.Name = "foto";
            foto.ReadOnly = true;
            foto.Resizable = DataGridViewTriState.True;
            foto.SortMode = DataGridViewColumnSortMode.Automatic;
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
            // nombre
            // 
            nombre.HeaderText = "nombre";
            nombre.Name = "nombre";
            nombre.ReadOnly = true;
            // 
            // descripcion
            // 
            descripcion.HeaderText = "descripcion";
            descripcion.Name = "descripcion";
            descripcion.ReadOnly = true;
            // 
            // fecha_modificacion
            // 
            fecha_modificacion.HeaderText = "fecha_modificacion";
            fecha_modificacion.Name = "fecha_modificacion";
            fecha_modificacion.ReadOnly = true;
            // 
            // activo
            // 
            activo.HeaderText = "activo";
            activo.Name = "activo";
            activo.ReadOnly = true;
            // 
            // id_categoria
            // 
            id_categoria.HeaderText = "id_categoria";
            id_categoria.Name = "id_categoria";
            id_categoria.ReadOnly = true;
            // 
            // PanelSeries
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbl_pagina);
            Controls.Add(btnAnterior);
            Controls.Add(btnSiguiente);
            Controls.Add(btn_crear);
            Controls.Add(tabla_series);
            Name = "PanelSeries";
            Size = new Size(1000, 605);
            ((System.ComponentModel.ISupportInitialize)tabla_series).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_pagina;
        private Button btnAnterior;
        private Button btnSiguiente;
        private Button btn_crear;
        private Guna.UI2.WinForms.Guna2DataGridView tabla_series;
        private DataGridViewImageColumn foto;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn descripcion;
        private DataGridViewTextBoxColumn fecha_modificacion;
        private DataGridViewTextBoxColumn activo;
        private DataGridViewTextBoxColumn id_categoria;
    }
}
