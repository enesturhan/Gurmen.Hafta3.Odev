using ApiProjesiCrud.Models;

namespace ApiProjesiCrud.Dtos
{
    public class CompanyDto
    {
        public int Id { get;private set; }
        public string Name { get; private set; }
        public string TaxNumber { get; private set; }
        public string Country { get; private set; }
        public string Address { get; private set; }
        public string PhoneNumber { get; private set; }

       
    }
}
