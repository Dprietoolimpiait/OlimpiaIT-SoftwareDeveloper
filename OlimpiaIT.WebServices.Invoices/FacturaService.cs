using OlimpiaIT.WebServices.Invoices.Contracts;
using OlimpiaIT.WebServices.Invoices.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace OlimpiaIT.WebServices.Invoices
{
    public class FacturaService : IFactura
    {
        public ResultadoValidacionFactura CalcularTotalFacturas(List<InvoiceData> facturas)
        {
            var result = new ResultadoValidacionFactura();
            try
            {
                var resultFacturas = InvoiceServiceManager.ValidarFacturas(facturas);
                if (!resultFacturas.Any(x => !x.IsValid))
                {
                    result.FacturasValidas = true;
                    result.Mensajes = null;
                    result.TotalFacturas = InvoiceServiceManager.SumarTotalFacturas(facturas);
                }
                else
                {
                    result.FacturasValidas = false;
                    result.Mensajes = resultFacturas;
                    result.TotalFacturas = 0;
                }

                return result;
            }
            catch (ApplicationException ex)
            {
                result.FacturasValidas = true;
                result.Mensajes = null;
                throw ex;
            }
            catch (Exception ex)
            {
                result.FacturasValidas = true;
                result.Mensajes = null;
                throw ex;
            }
        }

        public double CalcularValorIVA(InvoiceData factura)
        {
            double valorIVA = 0;
            var esFacturaValida = InvoiceServiceManager.ValidarFactura(factura).IsValid;
            if (esFacturaValida)
            {
                valorIVA = InvoiceServiceManager.CalcualarValorIVA(factura);
                return valorIVA;
            }

            return valorIVA;
        }

        public ResultData ValidarFactura(InvoiceData factura)
        {
            return InvoiceServiceManager.ValidarFactura(factura);
        }
    }
}
