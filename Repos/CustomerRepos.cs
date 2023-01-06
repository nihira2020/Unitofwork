using Microsoft.EntityFrameworkCore;
using Unitofwork.Interface;
using Unitofwork.Modelss;

namespace Unitofwork.Repos
{
    public class CustomerRepos : GenericRepository<TblCustomer>, ICustomerrepo
    {
        public CustomerRepos(LearnDbContext learnDb) : base(learnDb)
        {
        }

        public override Task<List<TblCustomer>> GetAllAsync()
        {
            return base.GetAllAsync();
        }
        public override async Task<TblCustomer> GetAsync(int id)
        {
            return await DbSet.FirstOrDefaultAsync(item => item.Id == id);
        }

        public override async Task<bool> AddEntity(TblCustomer entity)
        {
            try
            {
                await DbSet.AddAsync(entity);
                return true;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public override async Task<bool> UpdateEntity(TblCustomer entity)
        {
            try
            {
                var existdata = await DbSet.FirstOrDefaultAsync(item => item.Id == entity.Id);
                if (existdata != null)
                {
                    existdata.Name = entity.Name;
                    existdata.Phone = entity.Phone;
                    existdata.Email = entity.Email;
                    existdata.CreditLimit = entity.CreditLimit;
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override async Task<bool> DeleteEntity(int id)
        {
            var existdata = await DbSet.FirstOrDefaultAsync(item => item.Id == id);
            if (existdata != null)
            {
                 DbSet.Remove(existdata);
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
