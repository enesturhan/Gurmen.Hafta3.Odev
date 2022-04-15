namespace ApiProjesiCrud.Models
{


    public enum TaxType
    {
        International=1,
        Income=2,
        Outcome=3
    }
    public class Tax
    {
        public Tax(int ıd, string name, float rate, string description, TaxType type)
        {
            Id = ıd;
            Name = name;
            Rate = rate;
            Description = description;
            Type = type;
        }

        public int Id { get;private set; }
        public string Name { get; private set; }

        public float Rate { get; private set; }
        public string Description { get; private set; }

        public TaxType Type { get; private set; }

        
    }
}
