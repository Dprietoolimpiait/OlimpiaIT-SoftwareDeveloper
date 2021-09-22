using OlimpiaIT.WebServices.Invoices.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OlimpiaIT.WebServices.Invoices.Manager
{
    internal static class InvoiceServiceManager
    {
        public static ResultData ValidarFactura(InvoiceData factura)
        {
            var resultData = new ResultData();

            if (factura != null)
            {
                //Validamos el ID de la factura
                if (factura.Id < 0)
                    resultData.Mensajes.Add("El Id debe ser un valor entero positivo");

                //Validamos el NIT de la factura
                if (!string.IsNullOrEmpty(factura.NIT))
                {
                    int nit;
                    if (int.TryParse(factura.NIT.Trim(), out nit))
                    {
                        //Validamos que el NIT sea un entero positivo
                        if (nit < 0)
                            resultData.Mensajes.Add("El NIT debe ser un valor entero positivo");
                    }
                    else
                    {
                        resultData.Mensajes.Add("El NIT debe contener sólo valores numéricos");
                    }
                }
                else
                {
                    resultData.Mensajes.Add("El NIT es requerido");
                }

                //Validamos el valor de la factura
                if (factura.ValorTotal < 0)
                    resultData.Mensajes.Add("El valor total debe ser positivo");

                //Validamos el valor IVA
                if (factura.ProcentajeIVA < 0 || factura.ProcentajeIVA > 100)
                    resultData.Mensajes.Add("El valor del Iva es un valor entre 0(%) y 100(%)");

            }
            resultData.IsValid = resultData.Mensajes.Count == 0;
            return resultData;
        }

        public static List<ResultData> ValidarFacturas(List<InvoiceData> facturas)
        {
            //Validamos que la factura no esté vacía
            if (facturas == null || facturas.Count == 0)
            {
                var result = new ResultData();
                result.IsValid = false;
                result.Mensajes.Add("El listado de facturas debe contener al menos una factura");
                return new List<ResultData> { result };
            }

            //Valdidar duplicados en la lista
            var duplicados = facturas.GroupBy(x => x.Id)
                                     .Where(group => group.Count() > 1)
                                     .Select(group => group.Key)
                                     .ToList();

            if (duplicados.Any())
            {
                var result = new ResultData();
                result.IsValid = false;
                result.Mensajes.Add("El listado de facturas debe contener Id que sean unicos");
                return new List<ResultData> { result };
            }

            var facturasValidadas = new List<ResultData>();
            facturas.ForEach(factura =>
            {
                facturasValidadas.Add(ValidarFactura(factura));
            });

            return facturasValidadas;
        }

        public static double SumarTotalFacturas(List<InvoiceData> facturas)
        {
            double totalFacturas = 0;
            totalFacturas = facturas.Select(x =>
                    new
                    {
                        ValorIVA = CalcualarValorIVA(x),
                        Total = x.ValorTotal
                    }).Sum(f => f.Total + f.ValorIVA);

            return totalFacturas;
        }

        public static double CalcualarValorIVA(InvoiceData factura)
        {
            return (factura.ValorTotal) * ((factura.ProcentajeIVA / 100));
        }
    }
}