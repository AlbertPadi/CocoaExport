﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class RegistroCertificaciones : ClaseMaestra
    {
        Conexion con = new Conexion();
        public int CertificacionID { get; set; }
        public string Descripcion { get; set; }

        public RegistroCertificaciones()
        {
            this.CertificacionID = 0;
            this.Descripcion = "";
        }

        public RegistroCertificaciones(int certificacionid, string descripcion)
        {
            this.CertificacionID = certificacionid;
            this.Descripcion = descripcion;
        }

        public override bool Borrar()
        {
            bool retorno = false;
            try
            {
                retorno = con.Ejecutar(String.Format("Delete from Certificaciones where CertificacionId={0}", this.CertificacionID));
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return retorno;
        }
    

        public override bool Buscar(int IdBuscado)
        {
            DataTable dt;

            dt = con.getDatos(String.Format("select *from Certificaciones where CertificacionId= {0}", IdBuscado));
            if (dt.Rows.Count > 0)
            {
                this.Descripcion = dt.Rows[0]["Nombre"].ToString();
            }

            return dt.Rows.Count > 0;
        }

        public override bool Editar()
        {
            bool retorno = false;
            try
            {
                retorno = con.Ejecutar(String.Format("Update Certificaciones Set Descripcion='{0}' where CertificacionId={1}", this.CertificacionID, this.CertificacionID));
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return retorno;
        }

        public override bool Insertar()
        {
            bool retorno = false;
            try
            {
                retorno = con.Ejecutar(String.Format("Insert Into Certificaciones(Descripcion) Values('{0}')", this.Descripcion));
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return retorno;
        }

        public override DataTable Listar(string campos, string Filtro)
        {
            throw new NotImplementedException();
        }
    }
}
