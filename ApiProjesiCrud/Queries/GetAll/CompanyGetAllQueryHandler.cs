using ApiProjesiCrud.Dtos;
using ApiProjesiCrud.Repository.Abstract;
using AutoMapper;
using MediatR;

namespace ApiProjesiCrud.Queries.GetAll
{
    public class CompanyGetAllQueryHandler : IRequestHandler<CompanyGetAllQuery, ResponseDto<List<CompanyDto>>>
    {
        private readonly ICompanyRepository _companyRepository;
        private readonly IMapper _mapper;

        public CompanyGetAllQueryHandler(ICompanyRepository companyRepository, IMapper mapper)
        {
            _companyRepository = companyRepository;
            _mapper = mapper;
        }

        public async Task<ResponseDto<List<CompanyDto>>> Handle(CompanyGetAllQuery request, CancellationToken cancellationToken)
        {
            var companies = await _companyRepository.GetAll();
            return ResponseDto<List<CompanyDto>>.Success(_mapper.Map<List<CompanyDto>>(companies),200);

        }
    }
}
