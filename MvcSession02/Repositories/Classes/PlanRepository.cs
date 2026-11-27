using GymManagmentSystemG01.Contexts;
using GymManagmentSystemG01.Entities;
using GymManagmentSystemG01.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GymManagmentSystemG01.Repositories.Classes
{
    public class PlanRepository: IPlanRepository
    {
        private GymDbContext _dbContext;// I/O

        public PlanRepository(GymDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IEnumerable<Plan>> GetAllAsync(CancellationToken ct = default)
        {
            return await dbContext.Plans.AsNoTracking().ToListAsync(ct);
        }

        public async Task<Plan?> GetByIdAsync(int id, CancellationToken ct = default)
        {
            return await _dbContext.Plans.FindAsync([id], CancellationToken: ct);
        }

        public async Task<int> UpdateAsync(CancellationToken ct)
        {
            try
            {
                return await _dbContext.SaveChangesAsync(ct);
            }
            catch (DbUpdateException ex)
            {
                Console.WriteLine(ex);
                return 0;
            }
        }
    }
}
