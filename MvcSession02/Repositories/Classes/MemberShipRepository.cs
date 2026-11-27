using GymManagmentSystemG01.Contexts;
using GymManagmentSystemG01.Entities;
using GymManagmentSystemG01.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace GymManagmentSystemG01.Repositories.Classes
{
    public class MemberShipRepository: IMemberShipRepository
    {
        private readonly GymDbContext _dbContext;
        public MemberShipRepository(GymDbContext dbContext)
        {
            _dbContext = dbContext
        }
        public Task<bool> AnyAsync(Expression<Func<MemberShip,bool>> predicate, CancellationToken ct = default)
        {
            return await _dbContext.MemberShips.AnyAsync(predicate, ct);
        }
    }
}
