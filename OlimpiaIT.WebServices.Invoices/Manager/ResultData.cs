using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OlimpiaIT.WebServices.Invoices.Manager
{
    public class ResultData
    {
        public bool IsValid { get; set; }
        public int IdFactura { get; set; }
        public List<string> Mensajes { get; set; }

        public ResultData()
        {
            Mensajes = new List<string>();
        }
    }
}