using MediatR;

namespace ApiProjesiCrud.Events
{
    public class CompanyCreatedEvent:INotification
    {
        public int CompanyId { get; set; }
        public string Description { get; set; }

    }
}
