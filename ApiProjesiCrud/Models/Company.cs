namespace ApiProjesiCrud.Models
{
    public struct Address
    {
        public string ZipCode { get; set; }
        public string CityName { get; set; }
        public string StreetName { get; set; }
    }

    public class Company
    {
        public Company(string name, string taxNumber)
        {
            Name = name;
            TaxNumber = taxNumber;
        }

        public int Id { get;private set; }
        public string Name { get; private set; }
        public string TaxNumber { get; private set; }
        public Country Country { get; private set; }
        public Address Address { get; private set; }
        public string PhoneNumber { get; private set; }
    }
}
