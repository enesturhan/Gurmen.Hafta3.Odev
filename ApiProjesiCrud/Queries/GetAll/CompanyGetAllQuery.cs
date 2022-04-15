using ApiProjesiCrud.Dtos;
using MediatR;

namespace ApiProjesiCrud.Queries.GetAll
{
    public class CompanyGetAllQuery: IRequest<ResponseDto<List<CompanyDto>>>
    {

    }
}
