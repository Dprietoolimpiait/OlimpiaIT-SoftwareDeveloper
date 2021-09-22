using OlimpiaIT.WebServices.Invoices.Contracts;
using OlimpiaIT.WebServices.Invoices.Manager;
using System.Collections.Generic;
using System.ServiceModel;

namespace OlimpiaIT.WebServices.Invoices
{
    [ServiceContract]
    public interface IFactura
    {

        [OperationContract]
        ResultadoValidacionFactura CalcularTotalFacturas(List<InvoiceData> facturas);

        [OperationContract]
        ResultData ValidarFactura(InvoiceData factura);

        [OperationContract]
        double CalcularValorIVA(InvoiceData factura);
    }
}
