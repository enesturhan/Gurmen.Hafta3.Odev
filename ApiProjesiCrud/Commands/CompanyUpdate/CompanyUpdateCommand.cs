using ApiProjesiCrud.Dtos;
using MediatR;

namespace ApiProjesiCrud.Commands.CompanyUpdate
{
    public class CompanyUpdateCommand : IRequest<ResponseDto<NoContent>>
    {
        public CompanyDto updateCompany { get; set; }
    }
}
