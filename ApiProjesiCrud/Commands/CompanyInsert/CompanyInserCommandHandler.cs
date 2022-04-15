using ApiProjesiCrud.Dtos;
using ApiProjesiCrud.Repository.Abstract;
using MediatR;

namespace ApiProjesiCrud.Commands.CompanyInsert
{
    public class CompanyInserCommandHandler : IRequestHandler<CompanyInsertCommand, ResponseDto<int>>
    {
        private readonly ICompanyRepository _companyRepository;
        private readonly IMediator _mediatR;

        public CompanyInserCommandHandler(ICompanyRepository companyRepository, IMediator mediatR)
        {
            _companyRepository = companyRepository;
            _mediatR = mediatR;
        }

        public async Task<ResponseDto<int>> Handle(CompanyInsertCommand request, CancellationToken cancellationToken)
        {
            var id = await _companyRepository.Save(request);
            return ResponseDto<int>.Success(id, 201);
        }
    }
}
