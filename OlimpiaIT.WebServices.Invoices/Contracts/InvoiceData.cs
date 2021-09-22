using OlimpiaIT.WebServices.Invoices.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace OlimpiaIT.WebServices.Invoices.Contracts
{
    [DataContract]
    public class InvoiceData
    {
        [DataMember] public int Id { get; set; }
        [DataMember] public string NIT { get; set; }
        [DataMember] public string Descripcion { get; set; }
        [DataMember] public double ValorTotal { get; set; }
        [DataMember] public double ProcentajeIVA { get; set; }
    }

    [DataContract]
    public class ResultadoValidacionFactura
    {
        [DataMember] public List<ResultData> Mensajes { get; set; }
        [DataMember] public bool FacturasValidas { get; set; }
        [DataMember] public double TotalFacturas { get; set; }
    }
}