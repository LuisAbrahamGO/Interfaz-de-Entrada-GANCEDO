using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz_de_Entrada_GANCEDO
{
    public class Concepto
    {
        public int idConcepto;
        public int idComprobante;
        public string Codigo;
        public string NoIdentificacion;
        public string ClaveProdServ;
        public string Descripcion;
        public string ClaveUnidad;
        public string Unidad;
        public decimal Cantidad;
        public decimal ValorUnitario;
        public decimal DescuentoPorcentaje;
        public decimal DescuentoImporte;
        public decimal Importe;
        public int CONCEPTOIVA;
        public decimal BaseIVA;
        public decimal TasaIVA;
        public decimal ImporteIVA;
        public int CONCEPTOISR;
        public decimal BaseISR;
        public decimal TasaISR;
        public decimal ImporteISR;
        public int CONCEPTOIEPS;
        public decimal BaseIEPS;
        public decimal TasaIEPS;
        public decimal ImporteIEPS;
        public int RETENCIONIVA;
        public decimal BaseRetencionIVA;
        public decimal TasaRetencionIVA;
        public decimal ImporteRetencionIVA;
        public int RETENCIONISR;
        public decimal BaseRetencionISR;
        public decimal TasaRetencionISR;
        public decimal ImporteRetencionISR;

        public Concepto()
        {
            this.idConcepto = 0;
            this.idComprobante = 0;
            this.Codigo = "";
            this.NoIdentificacion = "";
            this.ClaveProdServ = "";
            this.Descripcion = "";
            this.ClaveUnidad = "";
            this.Unidad = "";
            this.Cantidad = 0;
            this.ValorUnitario = 0;
            this.DescuentoPorcentaje = 0;
            this.DescuentoImporte = 0;
            this.Importe = 0;
            this.CONCEPTOIVA = 0;
            this.BaseIVA = 0;
            this.TasaIVA = 0;
            this.ImporteIVA = 0;
            this.CONCEPTOISR = 0;
            this.BaseISR = 0;
            this.TasaISR = 0;
            this.ImporteISR = 0;
            this.CONCEPTOIEPS = 0;
            this.BaseIEPS = 0;
            this.TasaIEPS = 0;
            this.ImporteIEPS = 0;
            this.RETENCIONIVA = 0;
            this.BaseRetencionIVA = 0;
            this.TasaRetencionIVA = 0;
            this.ImporteRetencionIVA = 0;
            this.RETENCIONISR = 0;
            this.BaseRetencionISR = 0;
            this.TasaRetencionISR = 0;
            this.ImporteRetencionISR = 0;
        }

    }
}
