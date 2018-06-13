namespace ultimo_lab
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup6 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup7 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup8 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            this.label_bienvenida = new System.Windows.Forms.Label();
            this.panel_bienvenida = new System.Windows.Forms.Panel();
            this.timer_bienvenido = new System.Windows.Forms.Timer(this.components);
            this.panel_menu = new System.Windows.Forms.Panel();
            this.listBox_search = new System.Windows.Forms.ListBox();
            this.button_salir = new System.Windows.Forms.Button();
            this.button_productores = new System.Windows.Forms.Button();
            this.button_directores = new System.Windows.Forms.Button();
            this.button_actores = new System.Windows.Forms.Button();
            this.button_peliculas = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel_peliculas = new System.Windows.Forms.Panel();
            this.button_volver = new System.Windows.Forms.Button();
            this.listBox_peliculas = new System.Windows.Forms.ListBox();
            this.listView_pelis = new System.Windows.Forms.ListView();
            this.column_nombrepeli = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Dirpeli = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_fechapeli = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_descripcion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_presupuesto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_estudio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel_actores = new System.Windows.Forms.Panel();
            this.button_volver2 = new System.Windows.Forms.Button();
            this.listBoxActores = new System.Windows.Forms.ListBox();
            this.panel_directores = new System.Windows.Forms.Panel();
            this.button_volver3 = new System.Windows.Forms.Button();
            this.listBox_actores = new System.Windows.Forms.ListBox();
            this.panel_productores = new System.Windows.Forms.Panel();
            this.button_volver4 = new System.Windows.Forms.Button();
            this.listBox_productores = new System.Windows.Forms.ListBox();
            this.listView_prod = new System.Windows.Forms.ListView();
            this.column_nombreprod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_apellidoprod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_fechaprod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_bioprod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView_dir = new System.Windows.Forms.ListView();
            this.column_nombredir = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_apellidodir = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_fechadir = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_biodir = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView_act = new System.Windows.Forms.ListView();
            this.column_nombreact = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_apellidoact = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_fechaact = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_bioact = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listBox_peliculasprod = new System.Windows.Forms.ListBox();
            this.listBox_peliculasact = new System.Windows.Forms.ListBox();
            this.panel_bienvenida.SuspendLayout();
            this.panel_menu.SuspendLayout();
            this.panel_peliculas.SuspendLayout();
            this.panel_actores.SuspendLayout();
            this.panel_directores.SuspendLayout();
            this.panel_productores.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_bienvenida
            // 
            this.label_bienvenida.AutoSize = true;
            this.label_bienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_bienvenida.Location = new System.Drawing.Point(-7, 9);
            this.label_bienvenida.Name = "label_bienvenida";
            this.label_bienvenida.Size = new System.Drawing.Size(479, 82);
            this.label_bienvenida.TabIndex = 0;
            this.label_bienvenida.Text = "BIENVENIDO";
            this.label_bienvenida.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel_bienvenida
            // 
            this.panel_bienvenida.Controls.Add(this.label_bienvenida);
            this.panel_bienvenida.Location = new System.Drawing.Point(2, 0);
            this.panel_bienvenida.Name = "panel_bienvenida";
            this.panel_bienvenida.Size = new System.Drawing.Size(486, 136);
            this.panel_bienvenida.TabIndex = 1;
            // 
            // timer_bienvenido
            // 
            this.timer_bienvenido.Enabled = true;
            this.timer_bienvenido.Interval = 5000;
            this.timer_bienvenido.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel_menu
            // 
            this.panel_menu.Controls.Add(this.listBox_search);
            this.panel_menu.Controls.Add(this.button_salir);
            this.panel_menu.Controls.Add(this.button_productores);
            this.panel_menu.Controls.Add(this.button_directores);
            this.panel_menu.Controls.Add(this.button_actores);
            this.panel_menu.Controls.Add(this.button_peliculas);
            this.panel_menu.Controls.Add(this.textBox1);
            this.panel_menu.Location = new System.Drawing.Point(494, 9);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(1175, 256);
            this.panel_menu.TabIndex = 2;
            this.panel_menu.Visible = false;
            // 
            // listBox_search
            // 
            this.listBox_search.FormattingEnabled = true;
            this.listBox_search.ItemHeight = 20;
            this.listBox_search.Location = new System.Drawing.Point(881, 13);
            this.listBox_search.Name = "listBox_search";
            this.listBox_search.Size = new System.Drawing.Size(256, 184);
            this.listBox_search.TabIndex = 2;
            this.listBox_search.SelectedIndexChanged += new System.EventHandler(this.listBox_search_SelectedIndexChanged);
            // 
            // button_salir
            // 
            this.button_salir.Location = new System.Drawing.Point(881, 203);
            this.button_salir.Name = "button_salir";
            this.button_salir.Size = new System.Drawing.Size(256, 39);
            this.button_salir.TabIndex = 1;
            this.button_salir.Text = "Salir";
            this.button_salir.UseVisualStyleBackColor = true;
            this.button_salir.Click += new System.EventHandler(this.button_salir_Click);
            // 
            // button_productores
            // 
            this.button_productores.Location = new System.Drawing.Point(589, 133);
            this.button_productores.Name = "button_productores";
            this.button_productores.Size = new System.Drawing.Size(131, 43);
            this.button_productores.TabIndex = 1;
            this.button_productores.Text = "Productores";
            this.button_productores.UseVisualStyleBackColor = true;
            this.button_productores.Click += new System.EventHandler(this.button_productores_Click);
            // 
            // button_directores
            // 
            this.button_directores.Location = new System.Drawing.Point(434, 133);
            this.button_directores.Name = "button_directores";
            this.button_directores.Size = new System.Drawing.Size(131, 43);
            this.button_directores.TabIndex = 1;
            this.button_directores.Text = "Directores";
            this.button_directores.UseVisualStyleBackColor = true;
            this.button_directores.Click += new System.EventHandler(this.button_directores_Click);
            // 
            // button_actores
            // 
            this.button_actores.Location = new System.Drawing.Point(272, 133);
            this.button_actores.Name = "button_actores";
            this.button_actores.Size = new System.Drawing.Size(131, 43);
            this.button_actores.TabIndex = 1;
            this.button_actores.Text = "Actores";
            this.button_actores.UseVisualStyleBackColor = true;
            this.button_actores.Click += new System.EventHandler(this.button_actores_Click);
            // 
            // button_peliculas
            // 
            this.button_peliculas.Location = new System.Drawing.Point(120, 133);
            this.button_peliculas.Name = "button_peliculas";
            this.button_peliculas.Size = new System.Drawing.Size(131, 43);
            this.button_peliculas.TabIndex = 1;
            this.button_peliculas.Text = "Peliculas";
            this.button_peliculas.UseVisualStyleBackColor = true;
            this.button_peliculas.Click += new System.EventHandler(this.button_peliculas_Click);
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.Location = new System.Drawing.Point(73, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(686, 26);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "🔎 Search...";
            this.textBox1.Click += new System.EventHandler(this.txtbox_click);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel_peliculas
            // 
            this.panel_peliculas.Controls.Add(this.button_volver);
            this.panel_peliculas.Controls.Add(this.listBox_peliculas);
            this.panel_peliculas.Controls.Add(this.listView_pelis);
            this.panel_peliculas.Location = new System.Drawing.Point(9, 430);
            this.panel_peliculas.Name = "panel_peliculas";
            this.panel_peliculas.Size = new System.Drawing.Size(1185, 247);
            this.panel_peliculas.TabIndex = 3;
            this.panel_peliculas.Visible = false;
            // 
            // button_volver
            // 
            this.button_volver.Location = new System.Drawing.Point(881, 205);
            this.button_volver.Name = "button_volver";
            this.button_volver.Size = new System.Drawing.Size(256, 39);
            this.button_volver.TabIndex = 2;
            this.button_volver.Text = "Volver";
            this.button_volver.UseVisualStyleBackColor = true;
            this.button_volver.Click += new System.EventHandler(this.button_volver_Click);
            // 
            // listBox_peliculas
            // 
            this.listBox_peliculas.FormattingEnabled = true;
            this.listBox_peliculas.ItemHeight = 20;
            this.listBox_peliculas.Location = new System.Drawing.Point(881, 17);
            this.listBox_peliculas.Name = "listBox_peliculas";
            this.listBox_peliculas.Size = new System.Drawing.Size(256, 184);
            this.listBox_peliculas.TabIndex = 1;
            this.listBox_peliculas.SelectedIndexChanged += new System.EventHandler(this.listBox_peliculas_SelectedIndexChanged);
            this.listBox_peliculas.DoubleClick += new System.EventHandler(this.peliculas_dobleclick);
            // 
            // listView_pelis
            // 
            this.listView_pelis.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_nombrepeli,
            this.column_Dirpeli,
            this.column_fechapeli,
            this.column_descripcion,
            this.column_presupuesto,
            this.column_estudio});
            listViewGroup5.Header = "ListViewGroup";
            listViewGroup5.Name = "Nombre";
            this.listView_pelis.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup5});
            this.listView_pelis.Location = new System.Drawing.Point(47, 94);
            this.listView_pelis.Name = "listView_pelis";
            this.listView_pelis.Size = new System.Drawing.Size(810, 107);
            this.listView_pelis.TabIndex = 0;
            this.listView_pelis.UseCompatibleStateImageBehavior = false;
            this.listView_pelis.View = System.Windows.Forms.View.Details;
            // 
            // column_nombrepeli
            // 
            this.column_nombrepeli.Text = "Nombre";
            this.column_nombrepeli.Width = 130;
            // 
            // column_Dirpeli
            // 
            this.column_Dirpeli.Text = "Director";
            this.column_Dirpeli.Width = 143;
            // 
            // column_fechapeli
            // 
            this.column_fechapeli.Text = "fecha";
            this.column_fechapeli.Width = 130;
            // 
            // column_descripcion
            // 
            this.column_descripcion.Text = "descripcion";
            this.column_descripcion.Width = 159;
            // 
            // column_presupuesto
            // 
            this.column_presupuesto.Text = "Presupuesto";
            this.column_presupuesto.Width = 116;
            // 
            // column_estudio
            // 
            this.column_estudio.Text = "Estudio";
            this.column_estudio.Width = 127;
            // 
            // panel_actores
            // 
            this.panel_actores.Controls.Add(this.listBox_peliculasact);
            this.panel_actores.Controls.Add(this.button_volver2);
            this.panel_actores.Controls.Add(this.listBoxActores);
            this.panel_actores.Controls.Add(this.listView_act);
            this.panel_actores.Location = new System.Drawing.Point(170, 407);
            this.panel_actores.Name = "panel_actores";
            this.panel_actores.Size = new System.Drawing.Size(1185, 247);
            this.panel_actores.TabIndex = 3;
            this.panel_actores.Visible = false;
            // 
            // button_volver2
            // 
            this.button_volver2.Location = new System.Drawing.Point(881, 205);
            this.button_volver2.Name = "button_volver2";
            this.button_volver2.Size = new System.Drawing.Size(256, 39);
            this.button_volver2.TabIndex = 2;
            this.button_volver2.Text = "Volver";
            this.button_volver2.UseVisualStyleBackColor = true;
            this.button_volver2.Click += new System.EventHandler(this.button_volver_Click);
            // 
            // listBoxActores
            // 
            this.listBoxActores.FormattingEnabled = true;
            this.listBoxActores.ItemHeight = 20;
            this.listBoxActores.Location = new System.Drawing.Point(881, 17);
            this.listBoxActores.Name = "listBoxActores";
            this.listBoxActores.Size = new System.Drawing.Size(256, 184);
            this.listBoxActores.TabIndex = 1;
            this.listBoxActores.SelectedIndexChanged += new System.EventHandler(this.listBox_peliculas_SelectedIndexChanged);
            this.listBoxActores.DoubleClick += new System.EventHandler(this.peliculas_dobleclick);
            // 
            // panel_directores
            // 
            this.panel_directores.Controls.Add(this.button_volver3);
            this.panel_directores.Controls.Add(this.listBox_actores);
            this.panel_directores.Controls.Add(this.listView_dir);
            this.panel_directores.Location = new System.Drawing.Point(351, 365);
            this.panel_directores.Name = "panel_directores";
            this.panel_directores.Size = new System.Drawing.Size(1185, 247);
            this.panel_directores.TabIndex = 3;
            this.panel_directores.Visible = false;
            // 
            // button_volver3
            // 
            this.button_volver3.Location = new System.Drawing.Point(881, 205);
            this.button_volver3.Name = "button_volver3";
            this.button_volver3.Size = new System.Drawing.Size(256, 39);
            this.button_volver3.TabIndex = 2;
            this.button_volver3.Text = "Volver";
            this.button_volver3.UseVisualStyleBackColor = true;
            this.button_volver3.Click += new System.EventHandler(this.button_volver_Click);
            // 
            // listBox_actores
            // 
            this.listBox_actores.FormattingEnabled = true;
            this.listBox_actores.ItemHeight = 20;
            this.listBox_actores.Location = new System.Drawing.Point(881, 17);
            this.listBox_actores.Name = "listBox_actores";
            this.listBox_actores.Size = new System.Drawing.Size(256, 184);
            this.listBox_actores.TabIndex = 1;
            this.listBox_actores.SelectedIndexChanged += new System.EventHandler(this.listBox_peliculas_SelectedIndexChanged);
            this.listBox_actores.DoubleClick += new System.EventHandler(this.peliculas_dobleclick);
            // 
            // panel_productores
            // 
            this.panel_productores.Controls.Add(this.listBox_peliculasprod);
            this.panel_productores.Controls.Add(this.button_volver4);
            this.panel_productores.Controls.Add(this.listBox_productores);
            this.panel_productores.Controls.Add(this.listView_prod);
            this.panel_productores.Location = new System.Drawing.Point(567, 271);
            this.panel_productores.Name = "panel_productores";
            this.panel_productores.Size = new System.Drawing.Size(1185, 247);
            this.panel_productores.TabIndex = 3;
            this.panel_productores.Visible = false;
            // 
            // button_volver4
            // 
            this.button_volver4.Location = new System.Drawing.Point(881, 205);
            this.button_volver4.Name = "button_volver4";
            this.button_volver4.Size = new System.Drawing.Size(256, 39);
            this.button_volver4.TabIndex = 2;
            this.button_volver4.Text = "Volver";
            this.button_volver4.UseVisualStyleBackColor = true;
            this.button_volver4.Click += new System.EventHandler(this.button_volver_Click);
            // 
            // listBox_productores
            // 
            this.listBox_productores.FormattingEnabled = true;
            this.listBox_productores.ItemHeight = 20;
            this.listBox_productores.Location = new System.Drawing.Point(881, 17);
            this.listBox_productores.Name = "listBox_productores";
            this.listBox_productores.Size = new System.Drawing.Size(256, 184);
            this.listBox_productores.TabIndex = 1;
            this.listBox_productores.SelectedIndexChanged += new System.EventHandler(this.listBox_prod_SelectedIndexChanged);
            this.listBox_productores.DoubleClick += new System.EventHandler(this.peliculas_dobleclick);
            // 
            // listView_prod
            // 
            this.listView_prod.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_nombreprod,
            this.column_apellidoprod,
            this.column_fechaprod,
            this.column_bioprod});
            listViewGroup6.Header = "ListViewGroup";
            listViewGroup6.Name = "Nombre";
            this.listView_prod.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup6});
            this.listView_prod.Location = new System.Drawing.Point(47, 17);
            this.listView_prod.Name = "listView_prod";
            this.listView_prod.Size = new System.Drawing.Size(810, 107);
            this.listView_prod.TabIndex = 0;
            this.listView_prod.UseCompatibleStateImageBehavior = false;
            this.listView_prod.View = System.Windows.Forms.View.Details;
            this.listView_prod.SelectedIndexChanged += new System.EventHandler(this.listView4_SelectedIndexChanged);
            // 
            // column_nombreprod
            // 
            this.column_nombreprod.Text = "Nombre";
            this.column_nombreprod.Width = 130;
            // 
            // column_apellidoprod
            // 
            this.column_apellidoprod.Text = "Apellido";
            this.column_apellidoprod.Width = 143;
            // 
            // column_fechaprod
            // 
            this.column_fechaprod.Text = "fecha";
            this.column_fechaprod.Width = 130;
            // 
            // column_bioprod
            // 
            this.column_bioprod.Text = "Biografia";
            this.column_bioprod.Width = 397;
            // 
            // listView_dir
            // 
            this.listView_dir.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_nombredir,
            this.column_apellidodir,
            this.column_fechadir,
            this.column_biodir});
            listViewGroup7.Header = "ListViewGroup";
            listViewGroup7.Name = "Nombre";
            this.listView_dir.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup7});
            this.listView_dir.Location = new System.Drawing.Point(38, 89);
            this.listView_dir.Name = "listView_dir";
            this.listView_dir.Size = new System.Drawing.Size(810, 107);
            this.listView_dir.TabIndex = 0;
            this.listView_dir.UseCompatibleStateImageBehavior = false;
            this.listView_dir.View = System.Windows.Forms.View.Details;
            // 
            // column_nombredir
            // 
            this.column_nombredir.Text = "Nombre";
            this.column_nombredir.Width = 130;
            // 
            // column_apellidodir
            // 
            this.column_apellidodir.Text = "Apellido";
            this.column_apellidodir.Width = 143;
            // 
            // column_fechadir
            // 
            this.column_fechadir.Text = "fecha";
            this.column_fechadir.Width = 130;
            // 
            // column_biodir
            // 
            this.column_biodir.Text = "Biografia";
            this.column_biodir.Width = 397;
            // 
            // listView_act
            // 
            this.listView_act.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_nombreact,
            this.column_apellidoact,
            this.column_fechaact,
            this.column_bioact});
            listViewGroup8.Header = "ListViewGroup";
            listViewGroup8.Name = "Nombre";
            this.listView_act.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup8});
            this.listView_act.Location = new System.Drawing.Point(41, 26);
            this.listView_act.Name = "listView_act";
            this.listView_act.Size = new System.Drawing.Size(810, 107);
            this.listView_act.TabIndex = 0;
            this.listView_act.UseCompatibleStateImageBehavior = false;
            this.listView_act.View = System.Windows.Forms.View.Details;
            // 
            // column_nombreact
            // 
            this.column_nombreact.Text = "Nombre";
            this.column_nombreact.Width = 130;
            // 
            // column_apellidoact
            // 
            this.column_apellidoact.Text = "Apellido";
            this.column_apellidoact.Width = 143;
            // 
            // column_fechaact
            // 
            this.column_fechaact.Text = "fecha";
            this.column_fechaact.Width = 130;
            // 
            // column_bioact
            // 
            this.column_bioact.Text = "Biografia";
            this.column_bioact.Width = 397;
            // 
            // listBox_peliculasprod
            // 
            this.listBox_peliculasprod.FormattingEnabled = true;
            this.listBox_peliculasprod.ItemHeight = 20;
            this.listBox_peliculasprod.Location = new System.Drawing.Point(47, 140);
            this.listBox_peliculasprod.Name = "listBox_peliculasprod";
            this.listBox_peliculasprod.Size = new System.Drawing.Size(810, 84);
            this.listBox_peliculasprod.TabIndex = 3;
            // 
            // listBox_peliculasact
            // 
            this.listBox_peliculasact.FormattingEnabled = true;
            this.listBox_peliculasact.ItemHeight = 20;
            this.listBox_peliculasact.Location = new System.Drawing.Point(41, 140);
            this.listBox_peliculasact.Name = "listBox_peliculasact";
            this.listBox_peliculasact.Size = new System.Drawing.Size(810, 84);
            this.listBox_peliculasact.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1797, 743);
            this.Controls.Add(this.panel_productores);
            this.Controls.Add(this.panel_directores);
            this.Controls.Add(this.panel_actores);
            this.Controls.Add(this.panel_peliculas);
            this.Controls.Add(this.panel_menu);
            this.Controls.Add(this.panel_bienvenida);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel_bienvenida.ResumeLayout(false);
            this.panel_bienvenida.PerformLayout();
            this.panel_menu.ResumeLayout(false);
            this.panel_menu.PerformLayout();
            this.panel_peliculas.ResumeLayout(false);
            this.panel_actores.ResumeLayout(false);
            this.panel_directores.ResumeLayout(false);
            this.panel_productores.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_bienvenida;
        private System.Windows.Forms.Panel panel_bienvenida;
        private System.Windows.Forms.Timer timer_bienvenido;
        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Button button_salir;
        private System.Windows.Forms.Button button_productores;
        private System.Windows.Forms.Button button_directores;
        private System.Windows.Forms.Button button_actores;
        private System.Windows.Forms.Button button_peliculas;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox_search;
        private System.Windows.Forms.Panel panel_peliculas;
        private System.Windows.Forms.Button button_volver;
        private System.Windows.Forms.ListBox listBox_peliculas;
        private System.Windows.Forms.ListView listView_pelis;
        private System.Windows.Forms.ColumnHeader column_nombrepeli;
        private System.Windows.Forms.ColumnHeader column_Dirpeli;
        private System.Windows.Forms.ColumnHeader column_fechapeli;
        private System.Windows.Forms.ColumnHeader column_descripcion;
        private System.Windows.Forms.ColumnHeader column_presupuesto;
        private System.Windows.Forms.ColumnHeader column_estudio;
        private System.Windows.Forms.Panel panel_actores;
        private System.Windows.Forms.Button button_volver2;
        private System.Windows.Forms.ListBox listBoxActores;
        private System.Windows.Forms.Panel panel_directores;
        private System.Windows.Forms.Button button_volver3;
        private System.Windows.Forms.ListBox listBox_actores;
        private System.Windows.Forms.Panel panel_productores;
        private System.Windows.Forms.Button button_volver4;
        private System.Windows.Forms.ListBox listBox_productores;
        private System.Windows.Forms.ListView listView_prod;
        private System.Windows.Forms.ColumnHeader column_nombreprod;
        private System.Windows.Forms.ColumnHeader column_apellidoprod;
        private System.Windows.Forms.ColumnHeader column_fechaprod;
        private System.Windows.Forms.ColumnHeader column_bioprod;
        private System.Windows.Forms.ListView listView_act;
        private System.Windows.Forms.ColumnHeader column_nombreact;
        private System.Windows.Forms.ColumnHeader column_apellidoact;
        private System.Windows.Forms.ColumnHeader column_fechaact;
        private System.Windows.Forms.ColumnHeader column_bioact;
        private System.Windows.Forms.ListView listView_dir;
        private System.Windows.Forms.ColumnHeader column_nombredir;
        private System.Windows.Forms.ColumnHeader column_apellidodir;
        private System.Windows.Forms.ColumnHeader column_fechadir;
        private System.Windows.Forms.ColumnHeader column_biodir;
        private System.Windows.Forms.ListBox listBox_peliculasact;
        private System.Windows.Forms.ListBox listBox_peliculasprod;
    }
}

