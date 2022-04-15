using ApiProjesiCrud.Dtos;
using ApiProjesiCrud.Repository.Abstract;
using MediatR;

namespace ApiProjesiCrud.Commands.CompanyUpdate
{
    public class CompanyUpdateCommandHandler : IRequestHandler<CompanyUpdateCommand, ResponseDto<NoContent>>
    {

        private readonly ICompanyRepository _companyRepository;

        public CompanyUpdateCommandHandler(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }


        public async Task<ResponseDto<NoContent>> Handle(CompanyUpdateCommand request, CancellationToken cancellationToken)
        {

            var result = await _companyRepository.Update(request);

            if (!result)
            {

                return ResponseDto<NoContent>.Fail("update işlemi başarısız", 500);


            }

            return ResponseDto<NoContent>.Success(204);
        }
    }
}
