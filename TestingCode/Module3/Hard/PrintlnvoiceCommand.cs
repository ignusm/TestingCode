using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingCode.Module3.Hard
{
    public class PrintlnvoiceCommand
    {
        public void Execute(int invoiceId)
        {
            var database = new Database();
            var invoice = database.GetInvoice(invoiceId);
            Printer.WriteLine("Invoice ID: " + invoice.Id);
            Printer.WriteLine("Total: $" + invoice.Total);

            var dateTime = DateTime.Now;

            Printer.WriteLine("Printed: "+dateTime.ToShortDateString());
        }
    }
}
