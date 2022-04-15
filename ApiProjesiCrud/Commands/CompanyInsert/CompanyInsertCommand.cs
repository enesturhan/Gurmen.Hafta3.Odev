using ApiProjesiCrud.Dtos;
using MediatR;

namespace ApiProjesiCrud.Commands.CompanyInsert
{
    public class CompanyInsertCommand:IRequest<ResponseDto<int>>
    {
        public CompanyDto newCompany { get; set; }

    }
}
