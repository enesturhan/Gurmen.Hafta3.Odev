using ApiProjesiCrud.Dtos;
using MediatR;

namespace ApiProjesiCrud.Commands.CompanyDelete
{
    public class CompanyDeleteCommand: IRequest<ResponseDto<NoContent>>
    {
        public int Id { get; set; }

    }
}
