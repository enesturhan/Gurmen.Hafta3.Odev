namespace ApiProjesiCrud.Models
{
    public class Invoice
    {
        public Company Exporter { get; private set; } // hizmet sunan
        public Company Consignee { get; private set; } // Hizmet alan

        public string InvoiceNumber { get; private set; }
        public string FormattedInvoiceDate { get; private set; }

        public decimal TotalPrice { get; private set; }
        public decimal ItemTotalPrice { get; private set; } // CommondityItems total price alanı için kullandık. Vergileri bu fiyata ekleyip InvoicePrice yani total Price bulacağız. Veriglendirmelerin vergi oranlarına göre fiyat karşılıkları bu alan üzerinden hesaplanır.


        private List<Commondity> commondities = new List<Commondity>();
        public IReadOnlyList<Commondity> Commondities => commondities;

        private List<InvoiceTax> invoiceTaxes = new List<InvoiceTax>();
        public IReadOnlyList<InvoiceTax> InvoiceTaxes => invoiceTaxes;

    }
}
