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
            this.label_bienvenida = new System.Windows.Forms.Label();
            this.panel_bienvenida = new System.Windows.Forms.Panel();
            this.timer_bienvenido = new System.Windows.Forms.Timer(this.components);
            this.panel_menu = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_peliculas = new System.Windows.Forms.Button();
            this.button_actores = new System.Windows.Forms.Button();
            this.button_directores = new System.Windows.Forms.Button();
            this.button_productores = new System.Windows.Forms.Button();
            this.button_estudios = new System.Windows.Forms.Button();
            this.listBox_search = new System.Windows.Forms.ListBox();
            this.panel_bienvenida.SuspendLayout();
            this.panel_menu.SuspendLayout();
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
            this.panel_menu.Controls.Add(this.button_estudios);
            this.panel_menu.Controls.Add(this.button_productores);
            this.panel_menu.Controls.Add(this.button_directores);
            this.panel_menu.Controls.Add(this.button_actores);
            this.panel_menu.Controls.Add(this.button_peliculas);
            this.panel_menu.Controls.Add(this.textBox1);
            this.panel_menu.Location = new System.Drawing.Point(2, 142);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(1225, 256);
            this.panel_menu.TabIndex = 2;
            this.panel_menu.Visible = false;
            this.panel_menu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_menu_Paint);
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
            // button_peliculas
            // 
            this.button_peliculas.Location = new System.Drawing.Point(57, 142);
            this.button_peliculas.Name = "button_peliculas";
            this.button_peliculas.Size = new System.Drawing.Size(131, 43);
            this.button_peliculas.TabIndex = 1;
            this.button_peliculas.Text = "Peliculas";
            this.button_peliculas.UseVisualStyleBackColor = true;
            // 
            // button_actores
            // 
            this.button_actores.Location = new System.Drawing.Point(209, 142);
            this.button_actores.Name = "button_actores";
            this.button_actores.Size = new System.Drawing.Size(131, 43);
            this.button_actores.TabIndex = 1;
            this.button_actores.Text = "Actores";
            this.button_actores.UseVisualStyleBackColor = true;
            // 
            // button_directores
            // 
            this.button_directores.Location = new System.Drawing.Point(371, 142);
            this.button_directores.Name = "button_directores";
            this.button_directores.Size = new System.Drawing.Size(131, 43);
            this.button_directores.TabIndex = 1;
            this.button_directores.Text = "Directores";
            this.button_directores.UseVisualStyleBackColor = true;
            // 
            // button_productores
            // 
            this.button_productores.Location = new System.Drawing.Point(526, 142);
            this.button_productores.Name = "button_productores";
            this.button_productores.Size = new System.Drawing.Size(131, 43);
            this.button_productores.TabIndex = 1;
            this.button_productores.Text = "Productores";
            this.button_productores.UseVisualStyleBackColor = true;
            // 
            // button_estudios
            // 
            this.button_estudios.Location = new System.Drawing.Point(684, 142);
            this.button_estudios.Name = "button_estudios";
            this.button_estudios.Size = new System.Drawing.Size(131, 43);
            this.button_estudios.TabIndex = 1;
            this.button_estudios.Text = "Estudios";
            this.button_estudios.UseVisualStyleBackColor = true;
            // 
            // listBox_search
            // 
            this.listBox_search.FormattingEnabled = true;
            this.listBox_search.ItemHeight = 20;
            this.listBox_search.Location = new System.Drawing.Point(881, 13);
            this.listBox_search.Name = "listBox_search";
            this.listBox_search.Size = new System.Drawing.Size(314, 224);
            this.listBox_search.TabIndex = 2;
            this.listBox_search.SelectedIndexChanged += new System.EventHandler(this.listBox_search_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1797, 743);
            this.Controls.Add(this.panel_menu);
            this.Controls.Add(this.panel_bienvenida);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel_bienvenida.ResumeLayout(false);
            this.panel_bienvenida.PerformLayout();
            this.panel_menu.ResumeLayout(false);
            this.panel_menu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_bienvenida;
        private System.Windows.Forms.Panel panel_bienvenida;
        private System.Windows.Forms.Timer timer_bienvenido;
        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Button button_estudios;
        private System.Windows.Forms.Button button_productores;
        private System.Windows.Forms.Button button_directores;
        private System.Windows.Forms.Button button_actores;
        private System.Windows.Forms.Button button_peliculas;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox_search;
    }
}

