using System;
using System.Collections.Generic;

namespace Interfaz_de_Entrada_GANCEDO
{
    public class Comprobante
    {
        public int idComprobante;
        public int idEmisor;
        public string Emisor_RFC;
        public string DocumentoModelo;
        public string Concepto;
        public string TipoDeComprobante;
        public string Version;
        public DateTime Fecha;
        public DateTime Hora;
        public string Serie;
        public int Folio;
        public string FormaPago;
        public string MetodoPago;
        public string Referencia;
        public string Observacion;
        public string LugarExpedicion;
        public string Moneda;
        public decimal TipoCambio;
        public decimal Subtotal;
        public decimal Descuento;
        public decimal Total;
        public string TextoExtra1;
        public string TextoExtra2;
        public string TextoExtra3;
        public DateTime FechaExtra;
        public decimal ImporteExtra1;
        public decimal ImporteExtra2;
        public decimal ImporteExtra3;
        public decimal ImporteExtra4;
        public decimal ImporteIVA0;
        public decimal ImporteIVA16;
        public decimal ImporteISR;
        public decimal ImporteIEPS8;
        public decimal ImporteIEPS26;
        public decimal ImporteIEPS30;
        public decimal ImporteIEPS53;
        public decimal RetencionIVA;
        public decimal RetencionISR;
        public string Receptor_Codigo;
        public string Receptor_RFC;
        public string Receptor_RazonSocial;
        public string Receptor_UsoCFDI;
        public string Receptor_eMail;
        public string Receptor_Pais;
        public string Receptor_Estado;
        public string Receptor_Municipio;
        public string Receptor_Ciudad;
        public string Receptor_CodigoPostal;
        public string Receptor_Colonia;
        public string Receptor_Calle;
        public string Receptor_NoExt;
        public string Receptor_NoInt;
        public int PEPSICOADENDA;
        //public Pepsico AddendaPepsico;
        public int DONATARIOS;
        //public Donatarios ComplementoDonatarios;
        public List<Concepto> conceptos;
        public int TIMBREFISCALDIGITAL;
        //public TimbreFiscalDigital tfd;
        public string responseValue;
        public string responseData;
        public string xmlData;
        public string pdfData;


        public Comprobante()
        {
            this.idComprobante = 0;
            this.idEmisor = 0;
            this.Emisor_RFC = "";
            this.DocumentoModelo = "";
            this.Concepto = "";
            this.TipoDeComprobante = "";
            this.Version = "";
            this.Fecha = DateTime.Now;
            this.Hora = DateTime.Now;
            this.Serie = "";
            this.Folio = 0;
            this.FormaPago = "";
            this.MetodoPago = "";
            this.Referencia = "";
            this.Observacion = "";
            this.LugarExpedicion = "";
            this.Moneda = "";
            this.TipoCambio = 0;
            this.Subtotal = 0;
            this.Descuento = 0;
            this.Total = 0;
            this.TextoExtra1 = "";
            this.TextoExtra2 = "";
            this.TextoExtra3 = "";
            this.FechaExtra = DateTime.Now;
            this.ImporteExtra1 = 0;
            this.ImporteExtra2 = 0;
            this.ImporteExtra3 = 0;
            this.ImporteExtra4 = 0;
            this.ImporteIVA0 = 0;
            this.ImporteIVA16 = 0;
            this.ImporteISR = 0;
            this.ImporteIEPS8 = 0;
            this.ImporteIEPS26 = 0;
            this.ImporteIEPS30 = 0;
            this.ImporteIEPS53 = 0;
            this.RetencionIVA = 0;
            this.RetencionISR = 0;
            this.Receptor_Codigo = "";
            this.Receptor_RFC = "";
            this.Receptor_RazonSocial = "";
            this.Receptor_UsoCFDI = "";
            this.Receptor_eMail = "";
            this.Receptor_Pais = "";
            this.Receptor_Estado = "";
            this.Receptor_Municipio = "";
            this.Receptor_Ciudad = "";
            this.Receptor_CodigoPostal = "";
            this.Receptor_Colonia = "";
            this.Receptor_Calle = "";
            this.Receptor_NoExt = "";
            this.Receptor_NoInt = "";

            this.PEPSICOADENDA = 0;
            this.DONATARIOS = 0;
            this.TIMBREFISCALDIGITAL = 0;
            //conceptos = new List<Concepto>();
        }
    }
}
