using Unitofwork.Controllers;
using Unitofwork.Interface;
using Unitofwork.Modelss;

namespace Unitofwork.Repos
{
    public class UnitofWorkRepo : IUnitofWork
    {
        public ICustomerrepo customerrepo { get;private set; }

        private readonly LearnDbContext learnDbContext;

        public UnitofWorkRepo(LearnDbContext learnDbContext)
        {
            this.learnDbContext = learnDbContext;
            customerrepo = new CustomerRepos(learnDbContext);
        }

        public async Task CompleteAsync()
        {
            await this.learnDbContext.SaveChangesAsync();
        }
    }
}
