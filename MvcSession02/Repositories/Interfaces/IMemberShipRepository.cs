using GymManagmentSystemG01.Entities;
using System.Linq.Expressions;

namespace GymManagmentSystemG01.Repositories.Interfaces
{
    public interface IMemberShipRepository
    {
        Task<bool> AnyAsync(Expression<Fune<MemberShip,bool>> predicate, CancellationToken ct - default);
    }
}
