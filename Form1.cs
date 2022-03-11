using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz_de_Entrada_GANCEDO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool ValidaLayoutTXT(string ArchivoTXT)
        {
            bool validacion = false;

            if (File.Exists(ArchivoTXT))
            {
                StreamReader reader = new StreamReader(ArchivoTXT);

                string linea1;
                string[] datosLinea;
                string seccion = "";
                int type = 0;

                Comprobante comprobante = new Comprobante();
                Concepto concepto = new Concepto();

                while ((linea1 = reader.ReadLine()) != null)
                {

                    datosLinea = linea1.Split('=');

                    if (datosLinea.Length == 2)
                    {
                        bool isNumeric = int.TryParse(datosLinea[1], out _);
                        type = isNumeric ? 1 : 0;
                    }
                    else {
                        seccion = datosLinea[0];
                    }


                    switch (seccion)
                    {
                        case "COMPROBANTE":
                            {
                                    comprobante.Emisor_RFC = LeerDato(reader, type);
                                    comprobante.DocumentoModelo = LeerDato(reader, type);
                                    comprobante.Concepto = LeerDato(reader, type);
                                    comprobante.TipoDeComprobante = LeerDato(reader, type);
                                    comprobante.Version = LeerDato(reader, type);
                                    comprobante.Fecha = Convert.ToDateTime(LeerDato(reader, type));
                                    comprobante.Hora = Convert.ToDateTime(LeerDato(reader, type));
                                    comprobante.Serie = LeerDato(reader, type);
                                    comprobante.Folio = Convert.ToInt32(LeerDato(reader, type));
                                    comprobante.FormaPago = LeerDato(reader, type);
                                    comprobante.MetodoPago = LeerDato(reader, type);
                                    comprobante.Referencia = LeerDato(reader, type);
                                    comprobante.Observacion = LeerDato(reader, type);
                                    comprobante.LugarExpedicion = LeerDato(reader, type);
                                    comprobante.Moneda = LeerDato(reader, type);
                                    comprobante.TipoCambio = Convert.ToDecimal(LeerDato(reader, type));
                                    comprobante.Subtotal = Convert.ToDecimal(LeerDato(reader, type));
                                    comprobante.Descuento = Convert.ToDecimal(LeerDato(reader, type));
                                    comprobante.Total = Convert.ToDecimal(LeerDato(reader, type));
                                break;
                            }
                        case "CONCEPTO":
                            {

                                    concepto.Codigo = LeerDato(reader, type);
                                    concepto.NoIdentificacion = LeerDato(reader, type);
                                    concepto.ClaveProdServ = LeerDato(reader, type);
                                    concepto.Descripcion = LeerDato(reader, type);
                                    concepto.ClaveUnidad = LeerDato(reader, type);
                                    concepto.Unidad = LeerDato(reader, type);
                                    concepto.Cantidad = Convert.ToDecimal(LeerDato(reader, type));
                                    concepto.ValorUnitario = Convert.ToDecimal(LeerDato(reader, type));
                                    concepto.DescuentoPorcentaje = Convert.ToDecimal(LeerDato(reader, type));
                                    concepto.DescuentoImporte = Convert.ToDecimal(LeerDato(reader, type));
                                    concepto.Importe = Convert.ToDecimal(LeerDato(reader, type));
                                    concepto.CONCEPTOIVA = Convert.ToInt32(LeerDato(reader, type));
                                    concepto.BaseIVA = Convert.ToDecimal(LeerDato(reader, type));
                                    concepto.TasaIVA = Convert.ToDecimal(LeerDato(reader, type));
                                    concepto.ImporteIVA = Convert.ToDecimal(LeerDato(reader, type));
                                    concepto.CONCEPTOISR = Convert.ToInt32(LeerDato(reader, type));
                                    concepto.BaseISR = Convert.ToDecimal(LeerDato(reader, type));
                                    concepto.TasaISR = Convert.ToDecimal(LeerDato(reader, type));
                                    concepto.ImporteISR = Convert.ToDecimal(LeerDato(reader, type));
                                    concepto.CONCEPTOIEPS = Convert.ToInt32(LeerDato(reader, type));
                                    concepto.BaseIEPS = Convert.ToDecimal(LeerDato(reader, type));
                                    concepto.TasaIEPS = Convert.ToDecimal(LeerDato(reader, type));
                                    concepto.ImporteIEPS = Convert.ToDecimal(LeerDato(reader, type));
                                    concepto.RETENCIONIVA = Convert.ToInt32(LeerDato(reader, type));
                                    concepto.BaseRetencionIVA = Convert.ToDecimal(LeerDato(reader, type));
                                    concepto.TasaRetencionISR = Convert.ToDecimal(LeerDato(reader, type));
                                    concepto.ImporteRetencionIVA = Convert.ToDecimal(LeerDato(reader, type));
                                    concepto.RETENCIONISR = Convert.ToInt32(LeerDato(reader, type));
                                    concepto.BaseRetencionISR = Convert.ToDecimal(LeerDato(reader, type));
                                    concepto.TasaRetencionISR = Convert.ToDecimal(LeerDato(reader, type));
                                    concepto.ImporteRetencionISR = Convert.ToDecimal(LeerDato(reader, type));

                                break;
                            }
                        default:
                            {
                                break;
                            }
                    }
                }

                //this.list.Add(factura);

                reader.Close();
                return validacion;
            }
            else
            {
                return validacion;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = textBox1.Text;

            //Carga la lista de archivos txt
            string[] archivosTXT = Directory.GetFiles(path, "*.txt");

            //Procedure para cada archivo encontrado
            foreach (string archivoTXT in archivosTXT)
            {
                bool validacion = false;
                validacion = ValidaLayoutTXT(archivoTXT);

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private string LeerDato(StreamReader reader, int tipo)
        {
            string dato = "";

            string linea = reader.ReadLine();
            string[] datosLinea = linea.Split('=');

            dato = datosLinea[1].Trim();

            if (tipo == 1)
            {
                if (dato == "")
                {
                    dato = "0";
                }
            }

            return dato;
        }
    }
}
