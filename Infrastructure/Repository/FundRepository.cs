using Domain.Interfaces.RepositoryInterfaces;
using Domain.Models;
using Infrastructure.GenericRepository;
using Infrastructure.Persist;

namespace Infrastructure.Repository
{
    public class FundRepository : GenericRepository<Fund> , IFundRepository
    {
        public FundRepository(DatabaseContext context ) : base(context)
        {
                
        }
    }
}
