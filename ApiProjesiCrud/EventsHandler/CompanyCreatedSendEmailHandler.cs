using ApiProjesiCrud.Events;
using MediatR;

namespace ApiProjesiCrud.EventsHandler
{
    public class CompanyCreatedSendEmailHandler : INotificationHandler<CompanyCreatedEvent>
    {

        private readonly ILogger<CompanyCreatedSendEmailHandler> _logger;

        public CompanyCreatedSendEmailHandler(ILogger<CompanyCreatedSendEmailHandler> logger)
        {
            _logger = logger;
        }

        public Task Handle(CompanyCreatedEvent notification, CancellationToken cancellationToken)
        {
            _logger.LogInformation($"Sms Gönderildi : Company id={notification.CompanyId} Company Açıklaması : {notification.Description}");

            return Task.CompletedTask;
        }
    }
}
