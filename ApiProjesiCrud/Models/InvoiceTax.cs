namespace ApiProjesiCrud.Models
{
    public class InvoiceTax
    {
        public string Name { get; private set; } // verginin adı
        public float TaxRate { get; private set; } // vergi oranı
        public decimal TaxValue { get; private set; } // vergi oranı yansıltılmış değer
    }
}
