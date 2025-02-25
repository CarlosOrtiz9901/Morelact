﻿using Proyecto_Web.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using Proyecto_Web.Modelos;
using Proyecto_Web.Conection;

namespace Proyecto_Web.Modelos
{
    public class PROVEEDOR
    {
        private IDatos dat = new Datos();
        string NOM_PROVEEDOR;

        public PROVEEDOR(){
            NOM_PROVEEDOR = null;
        }

        public PROVEEDOR(string n){
            NOM_PROVEEDOR = n;
        }

        public bool RegistrarProveedor(string cedula, string NOM1, string NOM2, string APE1, string APE2, string CELULAR, string NACIMIENTO, string DIRECCION, string DETALLES, char SEXO, string correo, string contrasena)
        {
            try
            {
                return dat.OperarDatos("CALL INSE_PERSONA ('" + cedula + "', '" + NOM1 + "', '" + NOM2 + "', '" + APE1 + "', '" + APE2 + "', '" + CELULAR + "', '" + NACIMIENTO + "', '" + DIRECCION + "', '" + DETALLES + "', '" + SEXO + "', '" + correo + "', '" + contrasena + "', '" + "5" + "');");
            }
            catch (Exception)
            {
                return false;
            }
        }


        public bool RegistrarPruebas(string IP_PRUEBA, string FECHA, string OBSER, string PESO, string COLOR, string OLOR, string SABOR, string TEXTURA, string GRASA, string VITAMINA, string MINERALES, string PH,string LACTICO,string AGUA,string CLORUROS,string SACAROSA, string ANTI)
        {
            try
            {
                return dat.OperarDatos("CALL INSE_PRUEBA ('" + IP_PRUEBA + "', '" + FECHA + "', '" + OBSER + "', '" + PESO + "', '" + COLOR + "', '" + OLOR + "', '" + SABOR + "', '" + TEXTURA + "', '" + GRASA + "', '" + VITAMINA + "', '" + MINERALES + "', '" + PH + "', '" + LACTICO + "', '" + AGUA + "', '" + CLORUROS + "', '" + SACAROSA +  "', '" + ANTI + "');");
            }
            catch (Exception)
            {
                return false;
            }
        }

        public DataTable ConsultarProvedoresAll(){
            try
            {
                return dat.ConsultarDatos("CALL CONS_TODOS_PROVEEDORES ();");
            }
            catch (Exception io)
            {
                estructura err = new estructura();
                return err.GetError(io.Message);
            }
        }

        public DataTable ConsultarTODAS_PRUEBAS()
        {
            try
            {
                return dat.ConsultarDatos("CALL CONS_RESULDADOS_PRUEBA ();");
            }
            catch (Exception io)
            {
                estructura err = new estructura();
                return err.GetError(io.Message);
            }
        }
        public DataTable ConsultarNumero_pruebas()
        {
            try
            {
                return dat.ConsultarDatos("CALL CANT_PRUEBAS ();");
            }
            catch (Exception io)
            {
                estructura err = new estructura();
                return err.GetError(io.Message);
            }
        }

        public DataTable ConsultarProvedores_ID(string id){
            try
            {
                return dat.ConsultarDatos("CALL CONS_PROVEEDOR_ID ('" + id + "');");
            }
            catch (Exception io)
            {
                estructura err = new estructura();
                return err.GetError(io.Message);
            }
        }

        public DataTable ConsultarProvedoresAll2(){
            try
            {
                return dat.ConsultarDatos("CALL CONS_PROVEEDOR_ALL ();");
            }
            catch (Exception io)
            {
                estructura err = new estructura();
                return err.GetError(io.Message);
            }
        }
       

     public DataTable ActualizarEstado_Proveedor(string id, string ESTADO)
        {
            try
            {
                return dat.OperarProcedimiento("CALL  UPDA_ESTADO_PROVEEDOR ('"+ id + "','" + ESTADO + "');");
            }
            catch (Exception io)
            {
                estructura err = new estructura();
                return err.GetError(io.Message);
            }

        }

        public DataTable ActualizarProveedor(int id, string cedula, string nom1, string nom2, string ape1, string ape2, string celular, string direccion, string detalle,string contra, string estado, string nom_finca,string ubicacion,string dimencion,string cant_leche,string fecha_entrega)
        {
            try
            {
                return dat.OperarProcedimiento("CALL UPDA_PROVEEDOR ('" + id + "', '" + cedula + "', '" + nom1 + "', '" + nom2 + "', '" + ape1 + "', '" + ape2 + "', '" + celular + "', '" + direccion + "','" + detalle  + "', '" + contra + "', '" + estado + "', '" + nom_finca + "', '" + ubicacion + "','" + dimencion + "','" + cant_leche + "','" + fecha_entrega + "');");
            }
            catch (Exception io)
            {
                estructura err = new estructura();
                return err.GetError(io.Message);
            }

        }
    }
}
