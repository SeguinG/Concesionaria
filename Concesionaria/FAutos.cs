﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bcLibreriaConsecionaria;

namespace Concesionaria
{
    public partial class FAutos : Form
    {
        #region Inicializacion Form
        clsBase_Datos datos;
        bool agregarVehiculo;
        string codigoVehiculos;
        string formato = "0000";
        string pat;
        #endregion

        #region Metodos
        private void completarFiltroModelo()
        {
            cbModelo.Items.Clear();

            if (cbMarca.Text == "Todos")
            {
                cbModelo.Enabled = false;

                cbModelo.Items.Add("Agile");
                cbModelo.Items.Add("Aveo");
                cbModelo.Items.Add("Camaro");
                cbModelo.Items.Add("Corsa Classic");
                cbModelo.Items.Add("Onix");
                cbModelo.Items.Add("Clio");
                cbModelo.Items.Add("Fluence");
                cbModelo.Items.Add("Kwid");
                cbModelo.Items.Add("Logan");
                cbModelo.Items.Add("Sandero");
                cbModelo.Items.Add("Fiesta");
                cbModelo.Items.Add("Focus");
                cbModelo.Items.Add("Ka");
                cbModelo.Items.Add("Mondeo");
                cbModelo.Items.Add("Mustang");
                cbModelo.Items.Add("Fox");
                cbModelo.Items.Add("Gol");
                cbModelo.Items.Add("Golf");
                cbModelo.Items.Add("Passat");
                cbModelo.Items.Add("Polo");

            }
            else if (cbMarca.Text == "Chevrolet")
            {
                cbModelo.Items.Add("Agile");
                cbModelo.Items.Add("Aveo");
                cbModelo.Items.Add("Camaro");
                cbModelo.Items.Add("Corsa Classic");
                cbModelo.Items.Add("Onix");
            }

            else if (cbMarca.Text == "Renault")
            {
                cbModelo.Items.Add("Clio");
                cbModelo.Items.Add("Fluence");
                cbModelo.Items.Add("Kwid");
                cbModelo.Items.Add("Logan");
                cbModelo.Items.Add("Sandero");
            }
            else if (cbMarca.Text == "Ford")
            {
                cbModelo.Items.Add("Fiesta");
                cbModelo.Items.Add("Focus");
                cbModelo.Items.Add("Ka");
                cbModelo.Items.Add("Mondeo");
                cbModelo.Items.Add("Mustang");
            }
            else if (cbMarca.Text == "Volskwagen")
            {
                cbModelo.Items.Add("Fox");
                cbModelo.Items.Add("Gol");
                cbModelo.Items.Add("Golf");
                cbModelo.Items.Add("Passat");
                cbModelo.Items.Add("Polo");
            }

            cbModelo.SelectedIndex = 0;
        }

        private int calcularCantPuertas(string modelo)
        {
            int cantPuertas = 0;

            if (modelo == "Agile" || modelo == "Corsa Classic" || modelo == "Onix" || modelo == "Clio" || modelo == "Kwid"
                || modelo == "Sandero" || modelo == "Fiesta" || modelo == "Focus" || modelo == "Ka" || modelo == "Fox"
                || modelo == "Gol" || modelo == "Golf" || modelo == "Polo")
            {
                cantPuertas = 5;
            }
            else 
            {
                cantPuertas = 4;
            }

            return cantPuertas;
        }
        
        #endregion

        public FAutos(clsBase_Datos conexion, int codVehiculo)
        {
            InitializeComponent();
            datos = conexion;
            codigoVehiculos = codVehiculo.ToString(formato);
            agregarVehiculo = true;
        }

        public FAutos(clsBase_Datos conexion, string patente, int codVehiculo)
        {
            InitializeComponent();
            datos = conexion;
            agregarVehiculo = false;
            pat = patente;
            codigoVehiculos = codVehiculo.ToString(formato);
        }

        private void FAutos_Load(object sender, EventArgs e)
        {
            List<string> listaDistribuidores = datos.listarDistribuidores("");
            cbDistribuidores.Items.Clear();
            foreach (string cadena in listaDistribuidores)
            { 
                cbDistribuidores.Items.Add(cadena);
            }
            if (agregarVehiculo)
            {
                Text = "Agregar";
                bAceptar.Text = "Agregar";
                tPatente.Focus();
                tPatente.Text = "Ingrese patente...";
                cbMarca.SelectedIndex = 0;
                cbGama.SelectedIndex = 0;
                dtFechaFabricacion.Value = DateTime.Today;
                mtPrecioCosto.Clear();
                checkUsado.Checked = false;
                cbDistribuidores.SelectedIndex = 0;
            }
            else
            {
                Text = "Modificar";
                bAceptar.Text = "Modificar";
                tPatente.Text = pat;
                tPatente.Enabled = false;
                cbMarca.Text = datos.datosAuto(pat).MARCA;
                cbGama.Text = datos.datosAuto(pat).GAMA;
                cbModelo.Text = datos.datosAuto(pat).MODELO;
                dtFechaFabricacion.Value = datos.datosAuto(pat).FECHAFABRICACION;
                dtFechaCompra.Value = datos.datosAuto(pat).FECHACOMPRA;
                string formatoPrecio = "0000000.00";
                mtPrecioCosto.Text = Convert.ToString(datos.datosAuto(pat).PRECIOCOSTO.ToString(formatoPrecio));
                checkUsado.Checked = datos.datosAuto(pat).USADO;
                cbDistribuidores.Text = datos.datosAuto(pat).DISTRIBUIDOR.ToString();
            }
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            string nuevaMarca = cbMarca.SelectedIndex != -1 ? cbMarca.Text : "";
            string nuevaGama = cbGama.SelectedIndex != -1 ? cbGama.Text : "";
            string nuevoModelo = cbModelo.SelectedIndex != -1 ? cbModelo.Text : "";
            int cantPuertas = calcularCantPuertas(nuevoModelo);
            DateTime nuevaFechaFab = dtFechaFabricacion.Value.Date;
            DateTime nuevafechaCompra = dtFechaCompra.Value.Date;
            double nuevoPrecio = mtPrecioCosto.MaskCompleted ? Convert.ToDouble(mtPrecioCosto.Text) : 0;
            bool usado = checkUsado.Checked;
            double porcentajeGanancia = 0.35;
            string tipoAuto = "Auto";
            string cuitDist = cbDistribuidores.SelectedItem.ToString().Substring(6, 11);
            string nuevaPatente = tPatente.Text.Trim().ToUpper();
            string razonSocialDist = datos.getRazonSocial(cuitDist);
            bool esInternacionalDist = datos.esDistribuidorInternacional(cuitDist);

            if (!clsVehiculos.patenteValida(nuevaPatente))
            {
                MessageBox.Show("Ingrese una patente valida", "Patente Invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tPatente.Focus();
            }
            else if (nuevaMarca == "")
            {
                MessageBox.Show("Ingrese una marca valida", "Marca Incompleta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (nuevoModelo == "")
            {
                MessageBox.Show("Ingrese un modelo valido", "Modelo Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (nuevoPrecio == 0)
            {
                MessageBox.Show("Ingrese un valor valido para el precio", "Precio Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtPrecioCosto.Focus();
            }
            else if (agregarVehiculo)
            {

                if (datos.existePatenteVehiculo(nuevaPatente))
                {
                    MessageBox.Show("La patente ingresada ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tPatente.Focus();
                }
                else
                {
                    datos.insertarAuto(cantPuertas, nuevaMarca, nuevoModelo, nuevaGama, nuevaFechaFab, nuevafechaCompra, usado, nuevoPrecio, porcentajeGanancia, codigoVehiculos, tipoAuto, nuevaPatente, cuitDist, razonSocialDist, esInternacionalDist);
                    DialogResult = DialogResult.OK;
                }
            }
            else
            {
                datos.modificarAuto(cantPuertas, nuevaMarca, nuevoModelo, nuevaGama, nuevaFechaFab, nuevafechaCompra, usado, nuevoPrecio, porcentajeGanancia, codigoVehiculos, tipoAuto, nuevaPatente, cuitDist, razonSocialDist, esInternacionalDist);
                DialogResult = DialogResult.OK;
            }
        }

        private void cbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            completarFiltroModelo();
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tPatente_Validating(object sender, CancelEventArgs e)
        {
            epPatente.Clear();
            if (!clsVehiculos.patenteValida(tPatente.Text.Trim()))
                epPatente.SetError(tPatente, "La patente no es valida. Complete correctamente la misma");
        }

        private void tPatente_MouseClick(object sender, MouseEventArgs e)
        {
            tPatente.Clear();
        }

        private void tPatente_MouseHover(object sender, EventArgs e)
        {
            ttipPatente.SetToolTip(tPatente, "Formato de patente: <AA123AA>");
        }

        private void mtPrecioCosto_MouseHover(object sender, EventArgs e)
        {
            ttipPrecio.SetToolTip(mtPrecioCosto, "Debe ingresar un precio mínimo de $1,00");
        }

        private void dtFechaFabricacion_ValueChanged(object sender, EventArgs e)
        {
            dtFechaCompra.MinDate = dtFechaFabricacion.Value;
        }
    }
}
