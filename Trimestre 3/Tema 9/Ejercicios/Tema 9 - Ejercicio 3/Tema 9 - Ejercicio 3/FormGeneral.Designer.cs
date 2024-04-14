namespace Tema_9___Ejercicio_3
{
    partial class FormGeneral
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGeneral));
            this.panelHijo = new System.Windows.Forms.Panel();
            this.panelInferior = new System.Windows.Forms.Panel();
            this.lblTodos = new System.Windows.Forms.Label();
            this.lblAnyadir = new System.Windows.Forms.Label();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.lblDatos = new System.Windows.Forms.Label();
            this.lblInicio = new System.Windows.Forms.Label();
            this.btnDatos = new System.Windows.Forms.Button();
            this.btnTodos = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.panelHijo.SuspendLayout();
            this.panelInferior.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHijo
            // 
            this.panelHijo.BackColor = System.Drawing.Color.Transparent;
            this.panelHijo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelHijo.BackgroundImage")));
            this.panelHijo.Controls.Add(this.panelInferior);
            this.panelHijo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHijo.Location = new System.Drawing.Point(0, 0);
            this.panelHijo.Name = "panelHijo";
            this.panelHijo.Size = new System.Drawing.Size(700, 500);
            this.panelHijo.TabIndex = 1;
            // 
            // panelInferior
            // 
            this.panelInferior.BackColor = System.Drawing.Color.Transparent;
            this.panelInferior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelInferior.Controls.Add(this.lblTodos);
            this.panelInferior.Controls.Add(this.lblAnyadir);
            this.panelInferior.Controls.Add(this.lblBuscar);
            this.panelInferior.Controls.Add(this.lblDatos);
            this.panelInferior.Controls.Add(this.lblInicio);
            this.panelInferior.Controls.Add(this.btnDatos);
            this.panelInferior.Controls.Add(this.btnTodos);
            this.panelInferior.Controls.Add(this.btnNuevo);
            this.panelInferior.Controls.Add(this.btnBuscar);
            this.panelInferior.Controls.Add(this.btnInicio);
            this.panelInferior.ForeColor = System.Drawing.Color.Transparent;
            this.panelInferior.Location = new System.Drawing.Point(57, 372);
            this.panelInferior.Name = "panelInferior";
            this.panelInferior.Size = new System.Drawing.Size(579, 116);
            this.panelInferior.TabIndex = 0;
            // 
            // lblTodos
            // 
            this.lblTodos.AutoSize = true;
            this.lblTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodos.ForeColor = System.Drawing.Color.Black;
            this.lblTodos.Location = new System.Drawing.Point(473, 96);
            this.lblTodos.Name = "lblTodos";
            this.lblTodos.Size = new System.Drawing.Size(78, 20);
            this.lblTodos.TabIndex = 9;
            this.lblTodos.Text = "Ver todos";
            this.lblTodos.Visible = false;
            // 
            // lblAnyadir
            // 
            this.lblAnyadir.AutoSize = true;
            this.lblAnyadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnyadir.ForeColor = System.Drawing.Color.Black;
            this.lblAnyadir.Location = new System.Drawing.Point(366, 96);
            this.lblAnyadir.Name = "lblAnyadir";
            this.lblAnyadir.Size = new System.Drawing.Size(55, 20);
            this.lblAnyadir.TabIndex = 8;
            this.lblAnyadir.Text = "Añadir";
            this.lblAnyadir.Visible = false;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.ForeColor = System.Drawing.Color.Black;
            this.lblBuscar.Location = new System.Drawing.Point(259, 96);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(59, 20);
            this.lblBuscar.TabIndex = 7;
            this.lblBuscar.Text = "Buscar";
            this.lblBuscar.Visible = false;
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatos.ForeColor = System.Drawing.Color.Black;
            this.lblDatos.Location = new System.Drawing.Point(155, 96);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(52, 20);
            this.lblDatos.TabIndex = 6;
            this.lblDatos.Text = "Datos";
            this.lblDatos.Visible = false;
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicio.ForeColor = System.Drawing.Color.Black;
            this.lblInicio.Location = new System.Drawing.Point(43, 96);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(46, 20);
            this.lblInicio.TabIndex = 5;
            this.lblInicio.Text = "Inicio";
            this.lblInicio.Visible = false;
            // 
            // btnDatos
            // 
            this.btnDatos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDatos.BackColor = System.Drawing.Color.Transparent;
            this.btnDatos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDatos.BackgroundImage")));
            this.btnDatos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDatos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDatos.FlatAppearance.BorderSize = 0;
            this.btnDatos.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnDatos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDatos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatos.Location = new System.Drawing.Point(141, 20);
            this.btnDatos.Name = "btnDatos";
            this.btnDatos.Size = new System.Drawing.Size(75, 65);
            this.btnDatos.TabIndex = 4;
            this.btnDatos.UseVisualStyleBackColor = false;
            this.btnDatos.Click += new System.EventHandler(this.btnDatos_Click);
            this.btnDatos.MouseEnter += new System.EventHandler(this.btnDatos_MouseEnter);
            this.btnDatos.MouseLeave += new System.EventHandler(this.btnDatos_MouseLeave);
            // 
            // btnTodos
            // 
            this.btnTodos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTodos.BackColor = System.Drawing.Color.Transparent;
            this.btnTodos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTodos.BackgroundImage")));
            this.btnTodos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTodos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTodos.FlatAppearance.BorderSize = 0;
            this.btnTodos.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnTodos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnTodos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTodos.Location = new System.Drawing.Point(476, 20);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(75, 65);
            this.btnTodos.TabIndex = 3;
            this.btnTodos.UseVisualStyleBackColor = false;
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
            this.btnTodos.MouseEnter += new System.EventHandler(this.btnTodos_MouseEnter);
            this.btnTodos.MouseLeave += new System.EventHandler(this.btnTodos_MouseLeave);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNuevo.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNuevo.BackgroundImage")));
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Location = new System.Drawing.Point(361, 20);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 65);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            this.btnNuevo.MouseEnter += new System.EventHandler(this.btnNuevo_MouseEnter);
            this.btnNuevo.MouseLeave += new System.EventHandler(this.btnNuevo_MouseLeave);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.BackgroundImage")));
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(249, 20);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 65);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            this.btnBuscar.MouseEnter += new System.EventHandler(this.btnBuscar_MouseEnter);
            this.btnBuscar.MouseLeave += new System.EventHandler(this.btnBuscar_MouseLeave);
            // 
            // btnInicio
            // 
            this.btnInicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInicio.BackColor = System.Drawing.Color.Transparent;
            this.btnInicio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInicio.BackgroundImage")));
            this.btnInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnInicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Location = new System.Drawing.Point(29, 20);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(75, 65);
            this.btnInicio.TabIndex = 0;
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            this.btnInicio.MouseEnter += new System.EventHandler(this.btnInicio_MouseEnter);
            this.btnInicio.MouseLeave += new System.EventHandler(this.btnInicio_MouseLeave);
            // 
            // FormGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.panelHijo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "FormGeneral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PharmaDAM";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormGeneral_FormClosing);
            this.Load += new System.EventHandler(this.FormGeneral_Load);
            this.panelHijo.ResumeLayout(false);
            this.panelInferior.ResumeLayout(false);
            this.panelInferior.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHijo;
        private System.Windows.Forms.Panel panelInferior;
        private System.Windows.Forms.Button btnTodos;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnDatos;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.Label lblTodos;
        private System.Windows.Forms.Label lblAnyadir;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Label lblDatos;
    }
}

