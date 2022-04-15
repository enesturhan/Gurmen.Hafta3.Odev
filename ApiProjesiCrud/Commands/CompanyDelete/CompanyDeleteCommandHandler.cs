using ApiProjesiCrud.Dtos;
using ApiProjesiCrud.Repository.Abstract;
using MediatR;

namespace ApiProjesiCrud.Commands.CompanyDelete
{
    public class CompanyDeleteCommandHandler : IRequestHandler<CompanyDeleteCommand, ResponseDto<NoContent>>
    {

        private readonly ICompanyRepository _companyRepository;

        public CompanyDeleteCommandHandler(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }

        public async Task<ResponseDto<NoContent>> Handle(CompanyDeleteCommand request, CancellationToken cancellationToken)
        {
            var result = await _companyRepository.Delete(request);

            if (!result)
            {

                return ResponseDto<NoContent>.Fail("silme işlemi başarısız", 500);


            }

            return ResponseDto<NoContent>.Success(204);
        }
    }
}
