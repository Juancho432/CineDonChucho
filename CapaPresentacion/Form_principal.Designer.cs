namespace CapaPresentacion
{
    partial class Form_principal
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_duracion = new System.Windows.Forms.TextBox();
            this.cb_genero = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.timpicker_horaFuncion = new System.Windows.Forms.DateTimePicker();
            this.datepicker_fecha = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.button_guardar = new System.Windows.Forms.Button();
            this.button_limpiar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dgv_listado_peliculas = new System.Windows.Forms.DataGridView();
            this.Column_codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_duracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_fechaFuncion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_horaFuncion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_busqueda = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listado_peliculas)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(-2, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1013, 751);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button_limpiar);
            this.tabPage1.Controls.Add(this.button_guardar);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.datepicker_fecha);
            this.tabPage1.Controls.Add(this.timpicker_horaFuncion);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.cb_genero);
            this.tabPage1.Controls.Add(this.txt_duracion);
            this.tabPage1.Controls.Add(this.txt_nombre);
            this.tabPage1.Controls.Add(this.txt_codigo);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1005, 722);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Registrar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txt_busqueda);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.dgv_listado_peliculas);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1005, 722);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Buscar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1005, 615);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Listar";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(341, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registrar película ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(305, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(340, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese la información de la película:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(192, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Código:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(192, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(191, 358);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Duración (min):";
            // 
            // txt_codigo
            // 
            this.txt_codigo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo.Location = new System.Drawing.Point(380, 227);
            this.txt_codigo.Multiline = true;
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(249, 32);
            this.txt_codigo.TabIndex = 5;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.Location = new System.Drawing.Point(380, 288);
            this.txt_nombre.Multiline = true;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(249, 32);
            this.txt_nombre.TabIndex = 6;
            // 
            // txt_duracion
            // 
            this.txt_duracion.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_duracion.Location = new System.Drawing.Point(380, 350);
            this.txt_duracion.Multiline = true;
            this.txt_duracion.Name = "txt_duracion";
            this.txt_duracion.Size = new System.Drawing.Size(249, 32);
            this.txt_duracion.TabIndex = 7;
            // 
            // cb_genero
            // 
            this.cb_genero.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_genero.FormattingEnabled = true;
            this.cb_genero.Items.AddRange(new object[] {
            "Acción",
            "Aventura",
            "Comedia",
            "Drama",
            "Terror",
            "Romance",
            "Ciencia ficción"});
            this.cb_genero.Location = new System.Drawing.Point(380, 414);
            this.cb_genero.Name = "cb_genero";
            this.cb_genero.Size = new System.Drawing.Size(249, 32);
            this.cb_genero.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(192, 422);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "Género:";
            // 
            // timpicker_horaFuncion
            // 
            this.timpicker_horaFuncion.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timpicker_horaFuncion.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timpicker_horaFuncion.Location = new System.Drawing.Point(565, 548);
            this.timpicker_horaFuncion.Name = "timpicker_horaFuncion";
            this.timpicker_horaFuncion.ShowUpDown = true;
            this.timpicker_horaFuncion.Size = new System.Drawing.Size(143, 29);
            this.timpicker_horaFuncion.TabIndex = 10;
            // 
            // datepicker_fecha
            // 
            this.datepicker_fecha.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datepicker_fecha.Location = new System.Drawing.Point(195, 548);
            this.datepicker_fecha.Name = "datepicker_fecha";
            this.datepicker_fecha.Size = new System.Drawing.Size(308, 29);
            this.datepicker_fecha.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(191, 487);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(229, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "Día y hora de la función:";
            // 
            // button_guardar
            // 
            this.button_guardar.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_guardar.Location = new System.Drawing.Point(325, 632);
            this.button_guardar.Name = "button_guardar";
            this.button_guardar.Size = new System.Drawing.Size(108, 36);
            this.button_guardar.TabIndex = 13;
            this.button_guardar.Text = "Guardar";
            this.button_guardar.UseVisualStyleBackColor = true;
            // 
            // button_limpiar
            // 
            this.button_limpiar.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_limpiar.Location = new System.Drawing.Point(510, 632);
            this.button_limpiar.Name = "button_limpiar";
            this.button_limpiar.Size = new System.Drawing.Size(135, 36);
            this.button_limpiar.TabIndex = 14;
            this.button_limpiar.Text = "Limpiar campos";
            this.button_limpiar.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.ForestGreen;
            this.label8.Location = new System.Drawing.Point(341, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(254, 41);
            this.label8.TabIndex = 1;
            this.label8.Text = "Buscar película ";
            // 
            // dgv_listado_peliculas
            // 
            this.dgv_listado_peliculas.AllowUserToAddRows = false;
            this.dgv_listado_peliculas.AllowUserToDeleteRows = false;
            this.dgv_listado_peliculas.AllowUserToResizeColumns = false;
            this.dgv_listado_peliculas.AllowUserToResizeRows = false;
            this.dgv_listado_peliculas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_listado_peliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listado_peliculas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_codigo,
            this.Column_nombre,
            this.Column_duracion,
            this.Column_genero,
            this.Column_fechaFuncion,
            this.Column_horaFuncion});
            this.dgv_listado_peliculas.Location = new System.Drawing.Point(59, 213);
            this.dgv_listado_peliculas.Name = "dgv_listado_peliculas";
            this.dgv_listado_peliculas.ReadOnly = true;
            this.dgv_listado_peliculas.RowHeadersVisible = false;
            this.dgv_listado_peliculas.RowHeadersWidth = 51;
            this.dgv_listado_peliculas.RowTemplate.Height = 24;
            this.dgv_listado_peliculas.Size = new System.Drawing.Size(855, 363);
            this.dgv_listado_peliculas.TabIndex = 2;
            // 
            // Column_codigo
            // 
            this.Column_codigo.HeaderText = "Código";
            this.Column_codigo.MinimumWidth = 6;
            this.Column_codigo.Name = "Column_codigo";
            this.Column_codigo.ReadOnly = true;
            // 
            // Column_nombre
            // 
            this.Column_nombre.HeaderText = "Nombre";
            this.Column_nombre.MinimumWidth = 6;
            this.Column_nombre.Name = "Column_nombre";
            this.Column_nombre.ReadOnly = true;
            // 
            // Column_duracion
            // 
            this.Column_duracion.HeaderText = "Duración (min)";
            this.Column_duracion.MinimumWidth = 6;
            this.Column_duracion.Name = "Column_duracion";
            this.Column_duracion.ReadOnly = true;
            // 
            // Column_genero
            // 
            this.Column_genero.HeaderText = "Género";
            this.Column_genero.MinimumWidth = 6;
            this.Column_genero.Name = "Column_genero";
            this.Column_genero.ReadOnly = true;
            // 
            // Column_fechaFuncion
            // 
            this.Column_fechaFuncion.HeaderText = "Fecha Función";
            this.Column_fechaFuncion.MinimumWidth = 6;
            this.Column_fechaFuncion.Name = "Column_fechaFuncion";
            this.Column_fechaFuncion.ReadOnly = true;
            // 
            // Column_horaFuncion
            // 
            this.Column_horaFuncion.HeaderText = "Hora función";
            this.Column_horaFuncion.MinimumWidth = 6;
            this.Column_horaFuncion.Name = "Column_horaFuncion";
            this.Column_horaFuncion.ReadOnly = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(114, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(363, 24);
            this.label9.TabIndex = 3;
            this.label9.Text = "Ingrese código o nombre de la película:";
            // 
            // txt_busqueda
            // 
            this.txt_busqueda.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_busqueda.Location = new System.Drawing.Point(502, 124);
            this.txt_busqueda.Multiline = true;
            this.txt_busqueda.Name = "txt_busqueda";
            this.txt_busqueda.Size = new System.Drawing.Size(288, 32);
            this.txt_busqueda.TabIndex = 6;
            // 
            // Form_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 748);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form_principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cines Don Chucho";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listado_peliculas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_duracion;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_genero;
        private System.Windows.Forms.DateTimePicker timpicker_horaFuncion;
        private System.Windows.Forms.DateTimePicker datepicker_fecha;
        private System.Windows.Forms.Button button_limpiar;
        private System.Windows.Forms.Button button_guardar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgv_listado_peliculas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_duracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_fechaFuncion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_horaFuncion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_busqueda;
    }
}