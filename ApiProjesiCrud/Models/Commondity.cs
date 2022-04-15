namespace ApiProjesiCrud.Models
{
    public enum ServiceUnit
    {
        Daily = 1,
        Monthly = 2,
        Hourly = 3,
        Item = 4,
    }
    public class Commondity
    {
        public int SequenceNumber { get; private set; }
        public string Description { get; private set; } // Tasarım Hizmeti
        public int Quantity { get; private set; } // miktar
        public decimal UnitPrice { get; private set; } // Birim fiyat

        public ServiceUnit ServiceUnit { get; private set; }

        public decimal ListPrice
        {
            get
            {
                return Quantity * UnitPrice;
            }
        }

        public Commondity(string description, int quantity, decimal unitPrice, ServiceUnit unit)
        {
            this.Description = description;
            this.Quantity = quantity;
            this.UnitPrice = unitPrice;
            this.ServiceUnit = unit;
        }

        public void SetSequenceNumber(int sequence)
        {
            this.SequenceNumber = sequence;
        }
    }
}
