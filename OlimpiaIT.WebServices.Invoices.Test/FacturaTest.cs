using Microsoft.VisualStudio.TestTools.UnitTesting;
using OlimpiaIT.WebServices.Invoices.Test.WSFacturas;
using System;
using System.Collections.Generic;

namespace OlimpiaIT.WebServices.Invoices.Test
{
    [TestClass]
    public class FacturaTest
    {
        [TestMethod]
        public void FacturasValidas()
        {
            using (FacturaClient client = new FacturaClient())
            {
                List<InvoiceData> facturas = new List<InvoiceData>()
                {
                    new InvoiceData{ Descripcion = "Factura 1", Id = 1, NIT = "45646", ProcentajeIVA = 19, ValorTotal = 10000 },
                    new InvoiceData{ Descripcion = "Factura 2", Id = 2, NIT = "456461", ProcentajeIVA = 19, ValorTotal = 15000 },
                    new InvoiceData{ Descripcion = "Factura 3", Id = 3, NIT = "456462", ProcentajeIVA = 19, ValorTotal = 20000 }
                };
                var validacion = client.CalcularTotalFacturas(facturas.ToArray());
                Assert.IsTrue(validacion.FacturasValidas && validacion.TotalFacturas > 0);
            }
        }

        [TestMethod]
        public void FacturasDuplicadas()
        {
            using (FacturaClient client = new FacturaClient())
            {
                List<InvoiceData> facturas = new List<InvoiceData>()
                {
                    new InvoiceData{ Descripcion = "Factura 1", Id = 1, NIT = "45646", ProcentajeIVA = 19, ValorTotal = 10000 },
                    new InvoiceData{ Descripcion = "Factura 2", Id = 1, NIT = "456461", ProcentajeIVA = 19, ValorTotal = 15000 },
                    new InvoiceData{ Descripcion = "Factura 3", Id = 3, NIT = "456462", ProcentajeIVA = 19, ValorTotal = 20000 }
                };
                var validacion = client.CalcularTotalFacturas(facturas.ToArray());
                Assert.IsFalse(validacion.FacturasValidas);
            }
        }

        [TestMethod]
        public void FacturasInvalidas()
        {
            using (FacturaClient client = new FacturaClient())
            {
                List<InvoiceData> facturas = new List<InvoiceData>()
                {
                    new InvoiceData{ Descripcion = "Factura 1", Id = -1, NIT = "45646", ProcentajeIVA = 19, ValorTotal = 10000 },
                    new InvoiceData{ Descripcion = "Factura 2", Id = 2, NIT = "456461.", ProcentajeIVA = 101, ValorTotal = -15000 },
                    new InvoiceData{ Descripcion = "Factura 3", Id = 3, NIT = "456462", ProcentajeIVA = 19, ValorTotal = 20000 }
                };
                var validacion = client.CalcularTotalFacturas(facturas.ToArray());
                Assert.IsFalse(validacion.FacturasValidas);
            }
        }

        [TestMethod]
        public void FacturasNulas()
        {
            using (FacturaClient client = new FacturaClient())
            {
                List<InvoiceData> facturas = null;
                var validacion = client.CalcularTotalFacturas(facturas?.ToArray());
                Assert.IsFalse(validacion.FacturasValidas);
            }
        }

        [TestMethod]
        public void FacturasVacias()
        {
            using (FacturaClient client = new FacturaClient())
            {
                List<InvoiceData> facturas = new List<InvoiceData>();
                var validacion = client.CalcularTotalFacturas(facturas?.ToArray());
                Assert.IsFalse(validacion.FacturasValidas);
            }
        }

        [TestMethod]
        public void FacturaValida()
        {
            using (FacturaClient client = new FacturaClient())
            {
                InvoiceData factura = new InvoiceData() { Descripcion = "Factura 1", Id = 1, NIT = "45646", ProcentajeIVA = 19, ValorTotal = 10000 };
                var validacion = client.ValidarFactura(factura);
                Assert.IsTrue(validacion.IsValid);
            }
        }

        [TestMethod]
        public void FacturaNoValida()
        {
            using (FacturaClient client = new FacturaClient())
            {
                InvoiceData factura = new InvoiceData();
                var validacion = client.ValidarFactura(factura);
                Assert.IsFalse(validacion.IsValid);
            }
        }

        [TestMethod]
        public void ValorIVAFactura()
        {
            using (FacturaClient client = new FacturaClient())
            {
                InvoiceData factura = new InvoiceData() { Descripcion = "Factura 1", Id = 1, NIT = "45646", ProcentajeIVA = 19, ValorTotal = 10000 };
                var totalIVA = client.CalcularValorIVA(factura);
                Assert.IsTrue(totalIVA > 0);
            }
        }
    }
}
