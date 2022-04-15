using ApiProjesiCrud.Events;
using MediatR;

namespace ApiProjesiCrud.EventsHandler
{
    public class CompanyCreatedSendSmsHandler : INotificationHandler<CompanyCreatedEvent>
    {

        private readonly ILogger<CompanyCreatedSendSmsHandler> _logger;

        public CompanyCreatedSendSmsHandler(ILogger<CompanyCreatedSendSmsHandler> logger)
        {
            _logger = logger;
        }

        public Task Handle(CompanyCreatedEvent notification, CancellationToken cancellationToken)
        {
            _logger.LogInformation($"Email Gönderildi : Company id={notification.CompanyId} Company Açıklaması : {notification.Description}");

            return Task.CompletedTask;
        }
    }
}
