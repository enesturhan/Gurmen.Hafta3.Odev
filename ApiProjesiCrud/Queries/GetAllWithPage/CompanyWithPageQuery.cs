using ApiProjesiCrud.Dtos;
using MediatR;

namespace ApiProjesiCrud.Queries.GetAllWithPage
{
    public class CompanyWithPageQuery : IRequest<ResponseDto<List<CompanyDto>>>
    {
        public int Page { get; set; }
        public int PageSize { get; set; }
    }
}
