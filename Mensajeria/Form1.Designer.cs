
namespace Mensajeria
{
    partial class Form1
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Testt",
            "Test"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Contacto",
            "Mensaje"}, -1);
            this.bttnHome = new System.Windows.Forms.Button();
            this.lblMensajeria = new System.Windows.Forms.Label();
            this.bttnVentas = new System.Windows.Forms.Button();
            this.bttnCompras = new System.Windows.Forms.Button();
            this.bttnContactos = new System.Windows.Forms.Button();
            this.pnlContactos = new System.Windows.Forms.Panel();
            this.txtBuscarContacto = new System.Windows.Forms.TextBox();
            this.bttnModificarContacto = new System.Windows.Forms.Button();
            this.bttnBorrarContacto = new System.Windows.Forms.Button();
            this.bttnNuevoContacto = new System.Windows.Forms.Button();
            this.lsViewContactos = new System.Windows.Forms.ListView();
            this.columnNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTelefono = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCorreo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlModContacto = new System.Windows.Forms.Panel();
            this.bttnSubirFoto = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblModContacto = new System.Windows.Forms.Label();
            this.bttnCnlModContacto = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCorreoContacto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTelefonoContacto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApellidoContacto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreContacto = new System.Windows.Forms.TextBox();
            this.bttnModContacto = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlContactos.SuspendLayout();
            this.pnlModContacto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bttnHome
            // 
            this.bttnHome.BackColor = System.Drawing.Color.Transparent;
            this.bttnHome.FlatAppearance.BorderSize = 0;
            this.bttnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.bttnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnHome.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnHome.Location = new System.Drawing.Point(21, 58);
            this.bttnHome.Name = "bttnHome";
            this.bttnHome.Size = new System.Drawing.Size(64, 44);
            this.bttnHome.TabIndex = 52;
            this.bttnHome.Text = "Home";
            this.bttnHome.UseVisualStyleBackColor = false;
            // 
            // lblMensajeria
            // 
            this.lblMensajeria.AutoSize = true;
            this.lblMensajeria.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajeria.Location = new System.Drawing.Point(115, 33);
            this.lblMensajeria.Name = "lblMensajeria";
            this.lblMensajeria.Size = new System.Drawing.Size(124, 25);
            this.lblMensajeria.TabIndex = 50;
            this.lblMensajeria.Text = "Mensajería";
            // 
            // bttnVentas
            // 
            this.bttnVentas.BackColor = System.Drawing.Color.Transparent;
            this.bttnVentas.FlatAppearance.BorderSize = 0;
            this.bttnVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.bttnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnVentas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnVentas.Location = new System.Drawing.Point(12, 204);
            this.bttnVentas.Name = "bttnVentas";
            this.bttnVentas.Size = new System.Drawing.Size(86, 25);
            this.bttnVentas.TabIndex = 47;
            this.bttnVentas.Text = "Ventas";
            this.bttnVentas.UseVisualStyleBackColor = false;
            // 
            // bttnCompras
            // 
            this.bttnCompras.BackColor = System.Drawing.Color.Transparent;
            this.bttnCompras.FlatAppearance.BorderSize = 0;
            this.bttnCompras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.bttnCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnCompras.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnCompras.Location = new System.Drawing.Point(12, 173);
            this.bttnCompras.Name = "bttnCompras";
            this.bttnCompras.Size = new System.Drawing.Size(86, 25);
            this.bttnCompras.TabIndex = 46;
            this.bttnCompras.Text = "Compras";
            this.bttnCompras.UseVisualStyleBackColor = false;
            // 
            // bttnContactos
            // 
            this.bttnContactos.BackColor = System.Drawing.Color.Transparent;
            this.bttnContactos.FlatAppearance.BorderSize = 0;
            this.bttnContactos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.bttnContactos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnContactos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnContactos.Location = new System.Drawing.Point(21, 108);
            this.bttnContactos.Name = "bttnContactos";
            this.bttnContactos.Size = new System.Drawing.Size(64, 48);
            this.bttnContactos.TabIndex = 45;
            this.bttnContactos.Text = "Contactos";
            this.bttnContactos.UseVisualStyleBackColor = false;
            // 
            // pnlContactos
            // 
            this.pnlContactos.BackColor = System.Drawing.Color.White;
            this.pnlContactos.Controls.Add(this.bttnNuevoContacto);
            this.pnlContactos.Controls.Add(this.bttnModificarContacto);
            this.pnlContactos.Controls.Add(this.bttnBorrarContacto);
            this.pnlContactos.Controls.Add(this.lsViewContactos);
            this.pnlContactos.Controls.Add(this.txtBuscarContacto);
            this.pnlContactos.Location = new System.Drawing.Point(104, 61);
            this.pnlContactos.Name = "pnlContactos";
            this.pnlContactos.Size = new System.Drawing.Size(560, 327);
            this.pnlContactos.TabIndex = 48;
            // 
            // txtBuscarContacto
            // 
            this.txtBuscarContacto.Location = new System.Drawing.Point(333, 16);
            this.txtBuscarContacto.Name = "txtBuscarContacto";
            this.txtBuscarContacto.Size = new System.Drawing.Size(214, 20);
            this.txtBuscarContacto.TabIndex = 4;
            this.txtBuscarContacto.TextChanged += new System.EventHandler(this.txtBuscarContacto_TextChanged);
            // 
            // bttnModificarContacto
            // 
            this.bttnModificarContacto.BackColor = System.Drawing.Color.Transparent;
            this.bttnModificarContacto.FlatAppearance.BorderSize = 0;
            this.bttnModificarContacto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnModificarContacto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnModificarContacto.ForeColor = System.Drawing.Color.Black;
            this.bttnModificarContacto.Location = new System.Drawing.Point(108, 13);
            this.bttnModificarContacto.Name = "bttnModificarContacto";
            this.bttnModificarContacto.Size = new System.Drawing.Size(86, 25);
            this.bttnModificarContacto.TabIndex = 3;
            this.bttnModificarContacto.Text = "Modificar";
            this.bttnModificarContacto.UseVisualStyleBackColor = false;
            this.bttnModificarContacto.Click += new System.EventHandler(this.bttnModificarContacto_Click);
            // 
            // bttnBorrarContacto
            // 
            this.bttnBorrarContacto.BackColor = System.Drawing.Color.Transparent;
            this.bttnBorrarContacto.FlatAppearance.BorderSize = 0;
            this.bttnBorrarContacto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.bttnBorrarContacto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnBorrarContacto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnBorrarContacto.ForeColor = System.Drawing.Color.Black;
            this.bttnBorrarContacto.Location = new System.Drawing.Point(200, 13);
            this.bttnBorrarContacto.Name = "bttnBorrarContacto";
            this.bttnBorrarContacto.Size = new System.Drawing.Size(86, 25);
            this.bttnBorrarContacto.TabIndex = 2;
            this.bttnBorrarContacto.Text = "Borrar";
            this.bttnBorrarContacto.UseVisualStyleBackColor = false;
            this.bttnBorrarContacto.Click += new System.EventHandler(this.bttnBorrarContacto_Click);
            // 
            // bttnNuevoContacto
            // 
            this.bttnNuevoContacto.BackColor = System.Drawing.Color.Transparent;
            this.bttnNuevoContacto.FlatAppearance.BorderSize = 0;
            this.bttnNuevoContacto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.bttnNuevoContacto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnNuevoContacto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnNuevoContacto.ForeColor = System.Drawing.Color.Black;
            this.bttnNuevoContacto.Location = new System.Drawing.Point(16, 13);
            this.bttnNuevoContacto.Name = "bttnNuevoContacto";
            this.bttnNuevoContacto.Size = new System.Drawing.Size(86, 25);
            this.bttnNuevoContacto.TabIndex = 1;
            this.bttnNuevoContacto.Text = "Nuevo";
            this.bttnNuevoContacto.UseVisualStyleBackColor = false;
            this.bttnNuevoContacto.Click += new System.EventHandler(this.bttnNuevoContacto_Click);
            // 
            // lsViewContactos
            // 
            this.lsViewContactos.AccessibleDescription = "";
            this.lsViewContactos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsViewContactos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNombre,
            this.columnTelefono,
            this.columnCorreo});
            this.lsViewContactos.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsViewContactos.FullRowSelect = true;
            this.lsViewContactos.HideSelection = false;
            this.lsViewContactos.Location = new System.Drawing.Point(16, 42);
            this.lsViewContactos.Name = "lsViewContactos";
            this.lsViewContactos.Size = new System.Drawing.Size(531, 268);
            this.lsViewContactos.TabIndex = 0;
            this.lsViewContactos.UseCompatibleStateImageBehavior = false;
            this.lsViewContactos.View = System.Windows.Forms.View.Details;
            this.lsViewContactos.Click += new System.EventHandler(this.lsViewContactos_Click);
            // 
            // columnNombre
            // 
            this.columnNombre.Text = "Nombre";
            this.columnNombre.Width = 150;
            // 
            // columnTelefono
            // 
            this.columnTelefono.Text = "Teléfono";
            this.columnTelefono.Width = 150;
            // 
            // columnCorreo
            // 
            this.columnCorreo.Text = "Correo";
            this.columnCorreo.Width = 150;
            // 
            // pnlModContacto
            // 
            this.pnlModContacto.Controls.Add(this.bttnSubirFoto);
            this.pnlModContacto.Controls.Add(this.pictureBox1);
            this.pnlModContacto.Controls.Add(this.lblModContacto);
            this.pnlModContacto.Controls.Add(this.bttnCnlModContacto);
            this.pnlModContacto.Controls.Add(this.label6);
            this.pnlModContacto.Controls.Add(this.txtCorreoContacto);
            this.pnlModContacto.Controls.Add(this.label5);
            this.pnlModContacto.Controls.Add(this.txtTelefonoContacto);
            this.pnlModContacto.Controls.Add(this.label3);
            this.pnlModContacto.Controls.Add(this.txtApellidoContacto);
            this.pnlModContacto.Controls.Add(this.label2);
            this.pnlModContacto.Controls.Add(this.txtNombreContacto);
            this.pnlModContacto.Controls.Add(this.bttnModContacto);
            this.pnlModContacto.Location = new System.Drawing.Point(104, 61);
            this.pnlModContacto.Name = "pnlModContacto";
            this.pnlModContacto.Size = new System.Drawing.Size(560, 327);
            this.pnlModContacto.TabIndex = 49;
            // 
            // bttnSubirFoto
            // 
            this.bttnSubirFoto.BackColor = System.Drawing.Color.Transparent;
            this.bttnSubirFoto.FlatAppearance.BorderSize = 0;
            this.bttnSubirFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnSubirFoto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnSubirFoto.Location = new System.Drawing.Point(418, 160);
            this.bttnSubirFoto.Name = "bttnSubirFoto";
            this.bttnSubirFoto.Size = new System.Drawing.Size(100, 25);
            this.bttnSubirFoto.TabIndex = 23;
            this.bttnSubirFoto.Text = "Subir Foto";
            this.bttnSubirFoto.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(418, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 108);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // lblModContacto
            // 
            this.lblModContacto.AutoSize = true;
            this.lblModContacto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModContacto.Location = new System.Drawing.Point(26, 25);
            this.lblModContacto.Name = "lblModContacto";
            this.lblModContacto.Size = new System.Drawing.Size(127, 19);
            this.lblModContacto.TabIndex = 21;
            this.lblModContacto.Text = "Crear Contacto";
            // 
            // bttnCnlModContacto
            // 
            this.bttnCnlModContacto.BackColor = System.Drawing.Color.Transparent;
            this.bttnCnlModContacto.FlatAppearance.BorderSize = 0;
            this.bttnCnlModContacto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnCnlModContacto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnCnlModContacto.Location = new System.Drawing.Point(289, 285);
            this.bttnCnlModContacto.Name = "bttnCnlModContacto";
            this.bttnCnlModContacto.Size = new System.Drawing.Size(86, 25);
            this.bttnCnlModContacto.TabIndex = 18;
            this.bttnCnlModContacto.Text = "Cancelar";
            this.bttnCnlModContacto.UseVisualStyleBackColor = false;
            this.bttnCnlModContacto.Click += new System.EventHandler(this.bttnCnlModContacto_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Correo:";
            // 
            // txtCorreoContacto
            // 
            this.txtCorreoContacto.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreoContacto.Location = new System.Drawing.Point(116, 160);
            this.txtCorreoContacto.Name = "txtCorreoContacto";
            this.txtCorreoContacto.Size = new System.Drawing.Size(196, 22);
            this.txtCorreoContacto.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Teléfono:";
            // 
            // txtTelefonoContacto
            // 
            this.txtTelefonoContacto.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonoContacto.Location = new System.Drawing.Point(116, 131);
            this.txtTelefonoContacto.Name = "txtTelefonoContacto";
            this.txtTelefonoContacto.Size = new System.Drawing.Size(196, 22);
            this.txtTelefonoContacto.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Apellido:";
            // 
            // txtApellidoContacto
            // 
            this.txtApellidoContacto.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoContacto.Location = new System.Drawing.Point(116, 102);
            this.txtApellidoContacto.Name = "txtApellidoContacto";
            this.txtApellidoContacto.Size = new System.Drawing.Size(196, 22);
            this.txtApellidoContacto.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre:";
            // 
            // txtNombreContacto
            // 
            this.txtNombreContacto.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreContacto.Location = new System.Drawing.Point(116, 73);
            this.txtNombreContacto.Name = "txtNombreContacto";
            this.txtNombreContacto.Size = new System.Drawing.Size(196, 22);
            this.txtNombreContacto.TabIndex = 6;
            // 
            // bttnModContacto
            // 
            this.bttnModContacto.BackColor = System.Drawing.Color.Transparent;
            this.bttnModContacto.FlatAppearance.BorderSize = 0;
            this.bttnModContacto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnModContacto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnModContacto.Location = new System.Drawing.Point(197, 285);
            this.bttnModContacto.Name = "bttnModContacto";
            this.bttnModContacto.Size = new System.Drawing.Size(86, 25);
            this.bttnModContacto.TabIndex = 5;
            this.bttnModContacto.Text = "Crear";
            this.bttnModContacto.UseVisualStyleBackColor = false;
            this.bttnModContacto.Click += new System.EventHandler(this.bttnModContacto_Click);
            // 
            // listView1
            // 
            this.listView1.AccessibleDescription = "";
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.listView1.Location = new System.Drawing.Point(876, 120);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(216, 268);
            this.listView1.TabIndex = 53;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Tile;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nombre";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Teléfono";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Correo";
            this.columnHeader3.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 413);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.bttnHome);
            this.Controls.Add(this.lblMensajeria);
            this.Controls.Add(this.bttnVentas);
            this.Controls.Add(this.bttnCompras);
            this.Controls.Add(this.bttnContactos);
            this.Controls.Add(this.pnlContactos);
            this.Controls.Add(this.pnlModContacto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlContactos.ResumeLayout(false);
            this.pnlContactos.PerformLayout();
            this.pnlModContacto.ResumeLayout(false);
            this.pnlModContacto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnHome;
        private System.Windows.Forms.Label lblMensajeria;
        private System.Windows.Forms.Button bttnVentas;
        private System.Windows.Forms.Button bttnCompras;
        private System.Windows.Forms.Button bttnContactos;
        private System.Windows.Forms.Panel pnlContactos;
        private System.Windows.Forms.TextBox txtBuscarContacto;
        private System.Windows.Forms.Button bttnModificarContacto;
        private System.Windows.Forms.Button bttnBorrarContacto;
        private System.Windows.Forms.Button bttnNuevoContacto;
        private System.Windows.Forms.ListView lsViewContactos;
        private System.Windows.Forms.ColumnHeader columnNombre;
        private System.Windows.Forms.ColumnHeader columnTelefono;
        private System.Windows.Forms.ColumnHeader columnCorreo;
        private System.Windows.Forms.Panel pnlModContacto;
        private System.Windows.Forms.Label lblModContacto;
        private System.Windows.Forms.Button bttnCnlModContacto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCorreoContacto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTelefonoContacto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtApellidoContacto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreContacto;
        private System.Windows.Forms.Button bttnModContacto;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bttnSubirFoto;
    }
}

