namespace ApiProjesiCrud.Models
{
    public class Country
    {
        public string Name { get; private set; }
        public string Code { get; private set; }

        public Currency Currency { get; private set; }

        // HashSet ile çalışıyorsak IReadOnlySet interface kullanmalıyız.
        public IReadOnlySet<Tax> Taxes => taxes;


        // aynı vergi eklenemesin
        //unique bir referans degeri icin hashset
        private HashSet<Tax> taxes = new HashSet<Tax>();

        public Country(string name, string code, Currency currency)
        {
            Name = name;
            Code = code;
            Currency = currency;
        }


    }
}
