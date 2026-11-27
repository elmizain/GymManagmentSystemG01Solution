using GymManagmentSystemG01.Entities;

namespace GymManagmentSystemG01.Repositories.Interfaces
{
    public interface IPlanRepository
    {
        Task<IEnumerable<Plan>> GetAllPlansAsync(CancellationToken ct = default);

        Task<Plan?> GetPlanByIdAsync(int id, CancellationToken ct = default);

        Task<int> UpdateAsync(CancellationToken ct);
    }
}
