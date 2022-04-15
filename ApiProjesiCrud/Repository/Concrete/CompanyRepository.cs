using ApiProjesiCrud.Commands.CompanyDelete;
using ApiProjesiCrud.Commands.CompanyInsert;
using ApiProjesiCrud.Commands.CompanyUpdate;
using ApiProjesiCrud.Models;
using ApiProjesiCrud.Repository.Abstract;
using Dapper;
using System.Data;

namespace ApiProjesiCrud.Repository
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly IDbConnection _connection;
        private readonly IDbTransaction _transaction;


        public async Task<List<Company>> GetAll()
        {
            var query = "select * from company";
            var companies = await _connection.QueryAsync<Company>(query);

            return companies.ToList();
        }

        public async Task<List<Company>> GetAllWithPage(int page, int pageSize)
        {
            int offset = (page - 1) * pageSize;
            var query = "select * from company order by id desc limit @pagesize offset @offset";

            var companies = await _connection.QueryAsync<Company>(query, new { pagesize = pageSize, offset = offset });

            return companies.ToList();
        }

        public async Task<List<Company>> GetAllWithPageParameters(int page, int pageSize)
        {
            throw new NotImplementedException();
        }

        public async Task<int> Save(CompanyInsertCommand insertCommand)
        {
            var command = "insert into company(name,taxnumber,country,address,phonenumber)values(@name,@taxnumber,@country,@address,@phonenumber) returning id";

            var id = await _connection.ExecuteScalarAsync<int>(command, insertCommand.newCompany);


            return id;
        }
        public async Task<bool> Delete(CompanyDeleteCommand deleteCommand)
        {
            var command = "delete from company where id=@id";

            return await _connection.ExecuteAsync(command, deleteCommand) > 0;
        }


        public async Task<bool> Update(CompanyUpdateCommand updateCommmand)
        {
            var command = "update company set name=@name, taxnumber=@taxnumber,country=@country,address=@address, phonenumber=@phonenumber where id=@id";
            return await _connection.ExecuteAsync(command, updateCommmand) > 0;
        }


    }
}

