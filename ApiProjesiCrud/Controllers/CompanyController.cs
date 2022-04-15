using ApiProjesiCrud.Commands.CompanyDelete;
using ApiProjesiCrud.Commands.CompanyInsert;
using ApiProjesiCrud.Commands.CompanyUpdate;
using ApiProjesiCrud.Queries.GetAll;
using ApiProjesiCrud.Queries.GetAllWithPage;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ApiProjesiCrud.Controllers
{
    public class CompanyController:ControllerCustomBase
    {
        private readonly IMediator _mediator;

        public CompanyController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = await _mediator.Send(new CompanyGetAllQuery());
            return CreateActionResult(response);
        }

        [HttpGet("pages/{page}/{pagesize}")]
        public async Task<IActionResult> GetAllWithPage(int page, int pagesize)
        {

            var response = await _mediator.Send(new CompanyWithPageQuery() { Page = page, PageSize = pagesize });

            return CreateActionResult(response);

        }

        [HttpPost]
        public async Task<IActionResult> Save(CompanyInsertCommand companyInsertCommand)
        {

            return CreateActionResult(await _mediator.Send(companyInsertCommand));
        }

        [HttpPut]
        public async Task<IActionResult> Update(CompanyUpdateCommand companyUpdateCommand)
        {

            return CreateActionResult(await _mediator.Send(companyUpdateCommand));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {

            return CreateActionResult(await _mediator.Send(new CompanyDeleteCommand() { Id = id }));
        }
    }
}
