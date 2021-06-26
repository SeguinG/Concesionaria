﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concesionaria
{
    public class clsBase_Datos
    {
        List<clsVehiculos> listaVehiculos;
        List<clsDistribuidores> listaDistribuidores;
        public clsBase_Datos()
        {
            listaVehiculos = new List<clsVehiculos>();
            listaDistribuidores = new List<clsDistribuidores>();
        }
        #region Propiedades

        public int CantidadVehiculos
        {
            get
            {
                return listaVehiculos.Count;
            }
        }
        public int CantidadDistribuidores
        {
            get
            {
                return listaDistribuidores.Count;
            }
        }
        #endregion

        #region Metodos

        public bool existeCuitDistribuidor(string cuit)
        {
            clsDistribuidores distribuidor;
            bool existe = false;

            distribuidor = new clsDistribuidores(cuit, "", false);
            if (listaDistribuidores.Contains(distribuidor))
            {
                existe = true;
            }
            return existe;
        }

        public bool existeRazonDistribuidor(string razon)
        {
            bool existe = false;
            List<string> razonSocial;
            razonSocial = listaRazonDistribuidores();

            if (razonSocial.Contains(razon))
            {
                existe = true;
            }
            return existe;
        }
        public bool existeAuto(int codigo)
        {
            clsAutos auto;
            bool existe = false;

            auto = new clsAutos(codigo);
            if (listaVehiculos.Contains(auto))
            {
                existe = true;
            }
            return existe;
        }
        public bool existeCamioneta(int codigo)
        {
            clsCamionetas camioneta;
            bool existe = false;

            camioneta = new clsCamionetas(codigo);
            if (listaVehiculos.Contains(camioneta))
            {
                existe = true;
            }
            return existe;
        }

        public bool esDistribuidorInternacional(string cuit)
        {
            clsDistribuidores distribuidor = new clsDistribuidores(cuit, "", false);
            int indice = listaDistribuidores.IndexOf(distribuidor);
            if (indice >= 0)
            {
                distribuidor = listaDistribuidores[indice];
            }
            return distribuidor.INTERNACIONAL;
        }
        public List<string> listaRazonDistribuidores()
        {
            List<string> lista;
            lista = new List<string>();

            foreach (clsDistribuidores distribuidor in listaDistribuidores)
            {
                lista.Add(distribuidor.RAZONSOCIAL);
            }

            return lista;
        }

        public List<string> listarDistribuidores(string procedencia)
        {
            List<string> lista;
            lista = new List<string>();
            if (procedencia == "Internacional")
            {
                foreach (clsDistribuidores distribuidor in listaDistribuidores)
                {
                    if (distribuidor.INTERNACIONAL)
                    {
                        lista.Add(distribuidor.ToString());
                    }
                }
            }
            else if (procedencia == "Nacional")
            {
                foreach (clsDistribuidores distribuidor in listaDistribuidores)
                {
                    if (!distribuidor.INTERNACIONAL)
                    {
                        lista.Add(distribuidor.ToString());
                    }
                }
            }
            else
            {
                foreach (clsDistribuidores distribuidor in listaDistribuidores)
                {
                    lista.Add(distribuidor.ToString());
                }
            }

            return lista;
        }
        public List<string> listarVehiculos(string tipo_Vehiculo, string marca, string distribuidor, bool Condicion, bool cuatroXcuatro, string gama)
        {
            List<string> lista;
            lista = new List<string>();

            bool controlTipoVehiculo, controlMarca, controlDistribuidor, controlCondicion, controlCuaXcua, controlGama;
            
            foreach (clsVehiculos vehiculos in listaVehiculos)
            {
                controlTipoVehiculo = false;
                controlMarca = false;
                controlDistribuidor = false;
                controlCondicion = false;
                controlCuaXcua = false;
                controlGama = false;

                if (tipo_Vehiculo == "Todos") //control vehiculo
                {
                    controlTipoVehiculo = true;
                }
                else if (tipo_Vehiculo == "Auto")
                {
                    controlTipoVehiculo = vehiculos.GetType() == typeof(clsAutos);
                }
                else if (tipo_Vehiculo == "Camioneta")
                {
                    controlTipoVehiculo = vehiculos.GetType() == typeof(clsCamionetas);
                }

                switch (marca) //control marca
                {
                    case "Todos": controlMarca = true; break;
                    case "Chevrolet": controlMarca = marca == "Chevrolet"; break;
                    case "Ford": controlMarca = marca == "Ford"; break;
                    case "Renault": controlMarca = marca == "Renault"; break;
                    case "Volskwagen": controlMarca = marca == "Volskwagen"; break;

                }

                if (distribuidor == "Todos") //control distribuidor
                {
                    controlDistribuidor = true;
                }
                else
                {
                    clsDistribuidores dist = new clsDistribuidores(); 
                    controlDistribuidor = dist.Equals(distribuidor);
                }

                if (vehiculos.GetType() == typeof(clsAutos)) //control condicion y 4x4
                {
                    clsAutos auto = (clsAutos)vehiculos;
                    controlCondicion = auto.USADO == Condicion;
                    controlCuaXcua = true;                      
                }
                else
                {
                    clsCamionetas camionetas = (clsCamionetas)vehiculos;
                    controlCondicion = camionetas.USADO == Condicion;
                    controlCuaXcua = camionetas.CUATROXCUATRO == cuatroXcuatro;
                }

                if (gama == "Base") //control gama
                {
                    controlGama = true;
                }
                else if (gama == "Media")
                {
                    controlGama = true;
                }
                else if (gama == "Full")
                {
                    controlGama = true;
                }

                if (controlDistribuidor && controlMarca && controlTipoVehiculo && controlCondicion && controlCuaXcua && controlGama)
                {
                    lista.Add(vehiculos.ToString());
                }
            }
            return lista;
        }
        #endregion
    }




}