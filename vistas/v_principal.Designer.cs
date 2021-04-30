
namespace vistas
{
    partial class v_principal
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
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnVer = new System.Windows.Forms.Button();
            this.pnlVer = new System.Windows.Forms.Panel();
            this.btnMarcas = new System.Windows.Forms.Button();
            this.btnCategorias = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlAdministracion = new System.Windows.Forms.Panel();
            this.btnNuevaMarca = new System.Windows.Forms.Button();
            this.btnNuevaCategoria = new System.Windows.Forms.Button();
            this.btnNuevoProducto = new System.Windows.Forms.Button();
            this.btnAdministracion = new System.Windows.Forms.Button();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlTitulo.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlVer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlAdministracion.SuspendLayout();
            this.pnlContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(15)))), ((int)(((byte)(4)))));
            this.pnlTitulo.Controls.Add(this.label1);
            this.pnlTitulo.Controls.Add(this.button1);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(920, 24);
            this.pnlTitulo.TabIndex = 1;
            this.pnlTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTitulo_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(10, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Admin*Data";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(886, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 24);
            this.button1.TabIndex = 2;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 163);
            this.panel3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::vistas.Properties.Resources.logo1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnVer
            // 
            this.btnVer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVer.FlatAppearance.BorderSize = 0;
            this.btnVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVer.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnVer.ForeColor = System.Drawing.Color.Red;
            this.btnVer.Location = new System.Drawing.Point(0, 163);
            this.btnVer.Name = "btnVer";
            this.btnVer.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnVer.Size = new System.Drawing.Size(200, 33);
            this.btnVer.TabIndex = 1;
            this.btnVer.Text = "Ver";
            this.btnVer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlVer
            // 
            this.pnlVer.BackColor = System.Drawing.Color.DimGray;
            this.pnlVer.Controls.Add(this.btnMarcas);
            this.pnlVer.Controls.Add(this.btnCategorias);
            this.pnlVer.Controls.Add(this.btnProductos);
            this.pnlVer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlVer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlVer.Location = new System.Drawing.Point(0, 196);
            this.pnlVer.Name = "pnlVer";
            this.pnlVer.Size = new System.Drawing.Size(200, 99);
            this.pnlVer.TabIndex = 2;
            this.pnlVer.Visible = false;
            this.pnlVer.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // btnMarcas
            // 
            this.btnMarcas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMarcas.FlatAppearance.BorderSize = 0;
            this.btnMarcas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarcas.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnMarcas.ForeColor = System.Drawing.Color.Silver;
            this.btnMarcas.Location = new System.Drawing.Point(0, 66);
            this.btnMarcas.Name = "btnMarcas";
            this.btnMarcas.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnMarcas.Size = new System.Drawing.Size(200, 33);
            this.btnMarcas.TabIndex = 4;
            this.btnMarcas.Text = "Marcas";
            this.btnMarcas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMarcas.UseVisualStyleBackColor = true;
            // 
            // btnCategorias
            // 
            this.btnCategorias.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCategorias.FlatAppearance.BorderSize = 0;
            this.btnCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategorias.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnCategorias.ForeColor = System.Drawing.Color.Silver;
            this.btnCategorias.Location = new System.Drawing.Point(0, 33);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnCategorias.Size = new System.Drawing.Size(200, 33);
            this.btnCategorias.TabIndex = 3;
            this.btnCategorias.Text = "Categorias";
            this.btnCategorias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategorias.UseVisualStyleBackColor = true;
            // 
            // btnProductos
            // 
            this.btnProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnProductos.ForeColor = System.Drawing.Color.Silver;
            this.btnProductos.Location = new System.Drawing.Point(0, 0);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnProductos.Size = new System.Drawing.Size(200, 33);
            this.btnProductos.TabIndex = 2;
            this.btnProductos.Text = "Productos";
            this.btnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pnlAdministracion);
            this.panel1.Controls.Add(this.btnAdministracion);
            this.panel1.Controls.Add(this.pnlVer);
            this.panel1.Controls.Add(this.btnVer);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 501);
            this.panel1.TabIndex = 0;
            // 
            // pnlAdministracion
            // 
            this.pnlAdministracion.BackColor = System.Drawing.Color.DimGray;
            this.pnlAdministracion.Controls.Add(this.btnNuevaMarca);
            this.pnlAdministracion.Controls.Add(this.btnNuevaCategoria);
            this.pnlAdministracion.Controls.Add(this.btnNuevoProducto);
            this.pnlAdministracion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlAdministracion.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAdministracion.Location = new System.Drawing.Point(0, 328);
            this.pnlAdministracion.Name = "pnlAdministracion";
            this.pnlAdministracion.Size = new System.Drawing.Size(200, 99);
            this.pnlAdministracion.TabIndex = 4;
            this.pnlAdministracion.Visible = false;
            // 
            // btnNuevaMarca
            // 
            this.btnNuevaMarca.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNuevaMarca.FlatAppearance.BorderSize = 0;
            this.btnNuevaMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaMarca.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnNuevaMarca.ForeColor = System.Drawing.Color.Silver;
            this.btnNuevaMarca.Location = new System.Drawing.Point(0, 66);
            this.btnNuevaMarca.Name = "btnNuevaMarca";
            this.btnNuevaMarca.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnNuevaMarca.Size = new System.Drawing.Size(200, 33);
            this.btnNuevaMarca.TabIndex = 4;
            this.btnNuevaMarca.Text = "Nueva Marca";
            this.btnNuevaMarca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevaMarca.UseVisualStyleBackColor = true;
            this.btnNuevaMarca.Click += new System.EventHandler(this.btnNuevaMarca_Click);
            // 
            // btnNuevaCategoria
            // 
            this.btnNuevaCategoria.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNuevaCategoria.FlatAppearance.BorderSize = 0;
            this.btnNuevaCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaCategoria.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnNuevaCategoria.ForeColor = System.Drawing.Color.Silver;
            this.btnNuevaCategoria.Location = new System.Drawing.Point(0, 33);
            this.btnNuevaCategoria.Name = "btnNuevaCategoria";
            this.btnNuevaCategoria.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnNuevaCategoria.Size = new System.Drawing.Size(200, 33);
            this.btnNuevaCategoria.TabIndex = 3;
            this.btnNuevaCategoria.Text = "Nueva Categoría";
            this.btnNuevaCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevaCategoria.UseVisualStyleBackColor = true;
            this.btnNuevaCategoria.Click += new System.EventHandler(this.btnNuevaCategoria_Click);
            // 
            // btnNuevoProducto
            // 
            this.btnNuevoProducto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNuevoProducto.FlatAppearance.BorderSize = 0;
            this.btnNuevoProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoProducto.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnNuevoProducto.ForeColor = System.Drawing.Color.Silver;
            this.btnNuevoProducto.Location = new System.Drawing.Point(0, 0);
            this.btnNuevoProducto.Name = "btnNuevoProducto";
            this.btnNuevoProducto.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnNuevoProducto.Size = new System.Drawing.Size(200, 33);
            this.btnNuevoProducto.TabIndex = 2;
            this.btnNuevoProducto.Text = "Nuevo Producto";
            this.btnNuevoProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoProducto.UseVisualStyleBackColor = true;
            this.btnNuevoProducto.Click += new System.EventHandler(this.btnNuevoProducto_Click);
            // 
            // btnAdministracion
            // 
            this.btnAdministracion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdministracion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdministracion.FlatAppearance.BorderSize = 0;
            this.btnAdministracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdministracion.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnAdministracion.ForeColor = System.Drawing.Color.Red;
            this.btnAdministracion.Location = new System.Drawing.Point(0, 295);
            this.btnAdministracion.Name = "btnAdministracion";
            this.btnAdministracion.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnAdministracion.Size = new System.Drawing.Size(200, 33);
            this.btnAdministracion.TabIndex = 3;
            this.btnAdministracion.Text = "Administracion";
            this.btnAdministracion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdministracion.UseVisualStyleBackColor = true;
            this.btnAdministracion.Click += new System.EventHandler(this.btnAdministracion_Click);
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.Controls.Add(this.pictureBox2);
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(200, 24);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(720, 501);
            this.pnlContenedor.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Image = global::vistas.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(161, 105);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(398, 270);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // v_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(920, 525);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "v_principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "v_principal";
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlVer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnlAdministracion.ResumeLayout(false);
            this.pnlContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Panel pnlVer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.Button btnMarcas;
        private System.Windows.Forms.Button btnCategorias;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlAdministracion;
        private System.Windows.Forms.Button btnNuevaMarca;
        private System.Windows.Forms.Button btnNuevaCategoria;
        private System.Windows.Forms.Button btnNuevoProducto;
        private System.Windows.Forms.Button btnAdministracion;
    }
}