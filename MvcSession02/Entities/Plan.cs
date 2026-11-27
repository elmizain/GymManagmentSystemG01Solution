using System.ComponentModel.DataAnnotations;

namespace GymManagmentSystemG01.Entities
{
    public class Plan: BaseEntity
    {
        public String Name { get; set; } = default!;
        public String Description  { get; set; } = default!;
        public int DurationDays  { get; set; } 
        public decimal price  { get; set; }
        public bool IsActive  { get; set; }

        public ICollection<MemberShip> MemberShips { get; set; } = new HashSet<MemberShip>();
    }
}
