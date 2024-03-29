﻿
namespace Concesionaria
{
    partial class FAutos
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtFechaCompra = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.tPatente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.checkUsado = new System.Windows.Forms.CheckBox();
            this.cbModelo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbDistribuidores = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mtPrecioCosto = new System.Windows.Forms.MaskedTextBox();
            this.dtFechaFabricacion = new System.Windows.Forms.DateTimePicker();
            this.cbGama = new System.Windows.Forms.ComboBox();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bAceptar = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.epPatente = new System.Windows.Forms.ErrorProvider(this.components);
            this.ttipPatente = new System.Windows.Forms.ToolTip(this.components);
            this.ttipPrecio = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epPatente)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.dtFechaCompra);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.tPatente);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.checkUsado);
            this.panel1.Controls.Add(this.cbModelo);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cbDistribuidores);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.mtPrecioCosto);
            this.panel1.Controls.Add(this.dtFechaFabricacion);
            this.panel1.Controls.Add(this.cbGama);
            this.panel1.Controls.Add(this.cbMarca);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 255);
            this.panel1.TabIndex = 0;
            // 
            // dtFechaCompra
            // 
            this.dtFechaCompra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaCompra.Location = new System.Drawing.Point(133, 201);
            this.dtFechaCompra.Name = "dtFechaCompra";
            this.dtFechaCompra.Size = new System.Drawing.Size(97, 20);
            this.dtFechaCompra.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Fecha de Compra:";
            // 
            // tPatente
            // 
            this.tPatente.Location = new System.Drawing.Point(134, 22);
            this.tPatente.MaxLength = 7;
            this.tPatente.Name = "tPatente";
            this.tPatente.Size = new System.Drawing.Size(96, 20);
            this.tPatente.TabIndex = 1;
            this.tPatente.Text = "Ingrese patente...";
            this.tPatente.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tPatente_MouseClick);
            this.tPatente.MouseHover += new System.EventHandler(this.tPatente_MouseHover);
            this.tPatente.Validating += new System.ComponentModel.CancelEventHandler(this.tPatente_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(80, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Patente:";
            // 
            // checkUsado
            // 
            this.checkUsado.AutoSize = true;
            this.checkUsado.Location = new System.Drawing.Point(304, 228);
            this.checkUsado.Name = "checkUsado";
            this.checkUsado.Size = new System.Drawing.Size(57, 17);
            this.checkUsado.TabIndex = 9;
            this.checkUsado.Text = "Usado";
            this.checkUsado.UseVisualStyleBackColor = true;
            // 
            // cbModelo
            // 
            this.cbModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModelo.FormattingEnabled = true;
            this.cbModelo.Items.AddRange(new object[] {
            "Chevrolet",
            "Ford",
            "Renault",
            "Volskwagen"});
            this.cbModelo.Location = new System.Drawing.Point(133, 80);
            this.cbModelo.Name = "cbModelo";
            this.cbModelo.Size = new System.Drawing.Size(228, 21);
            this.cbModelo.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(82, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Modelo:";
            // 
            // cbDistribuidores
            // 
            this.cbDistribuidores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDistribuidores.FormattingEnabled = true;
            this.cbDistribuidores.Items.AddRange(new object[] {
            "Gama Base",
            "Gama Media",
            "Gama Full"});
            this.cbDistribuidores.Location = new System.Drawing.Point(133, 140);
            this.cbDistribuidores.Name = "cbDistribuidores";
            this.cbDistribuidores.Size = new System.Drawing.Size(228, 21);
            this.cbDistribuidores.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Distribuidores:";
            // 
            // mtPrecioCosto
            // 
            this.mtPrecioCosto.Location = new System.Drawing.Point(133, 225);
            this.mtPrecioCosto.Mask = "9999990.00";
            this.mtPrecioCosto.Name = "mtPrecioCosto";
            this.mtPrecioCosto.PromptChar = '#';
            this.mtPrecioCosto.Size = new System.Drawing.Size(72, 20);
            this.mtPrecioCosto.TabIndex = 8;
            this.mtPrecioCosto.MouseHover += new System.EventHandler(this.mtPrecioCosto_MouseHover);
            // 
            // dtFechaFabricacion
            // 
            this.dtFechaFabricacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaFabricacion.Location = new System.Drawing.Point(133, 175);
            this.dtFechaFabricacion.Name = "dtFechaFabricacion";
            this.dtFechaFabricacion.Size = new System.Drawing.Size(97, 20);
            this.dtFechaFabricacion.TabIndex = 6;
            this.dtFechaFabricacion.ValueChanged += new System.EventHandler(this.dtFechaFabricacion_ValueChanged);
            // 
            // cbGama
            // 
            this.cbGama.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGama.FormattingEnabled = true;
            this.cbGama.Items.AddRange(new object[] {
            "Base",
            "Media",
            "Full"});
            this.cbGama.Location = new System.Drawing.Point(133, 109);
            this.cbGama.Name = "cbGama";
            this.cbGama.Size = new System.Drawing.Size(228, 21);
            this.cbGama.TabIndex = 4;
            // 
            // cbMarca
            // 
            this.cbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Items.AddRange(new object[] {
            "Chevrolet",
            "Ford",
            "Renault",
            "Volskwagen"});
            this.cbMarca.Location = new System.Drawing.Point(133, 53);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(228, 21);
            this.cbMarca.TabIndex = 2;
            this.cbMarca.SelectedIndexChanged += new System.EventHandler(this.cbMarca_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Precio de costo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Fecha de Fabricacion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Gama:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marca:";
            // 
            // bAceptar
            // 
            this.bAceptar.Location = new System.Drawing.Point(180, 281);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(75, 23);
            this.bAceptar.TabIndex = 10;
            this.bAceptar.Text = "button1";
            this.bAceptar.UseVisualStyleBackColor = true;
            this.bAceptar.Click += new System.EventHandler(this.bAceptar_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancelar.Location = new System.Drawing.Point(298, 281);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 11;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // epPatente
            // 
            this.epPatente.ContainerControl = this;
            // 
            // FAutos
            // 
            this.AcceptButton = this.bAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bCancelar;
            this.ClientSize = new System.Drawing.Size(412, 317);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bAceptar);
            this.Controls.Add(this.panel1);
            this.Name = "FAutos";
            this.Text = "Autos";
            this.Load += new System.EventHandler(this.FAutos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epPatente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.ComboBox cbGama;
        private System.Windows.Forms.DateTimePicker dtFechaFabricacion;
        private System.Windows.Forms.MaskedTextBox mtPrecioCosto;
        private System.Windows.Forms.CheckBox checkUsado;
        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.ComboBox cbDistribuidores;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbModelo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tPatente;
        private System.Windows.Forms.ErrorProvider epPatente;
        private System.Windows.Forms.ToolTip ttipPatente;
        private System.Windows.Forms.ToolTip ttipPrecio;
        private System.Windows.Forms.DateTimePicker dtFechaCompra;
        private System.Windows.Forms.Label label8;
    }
}