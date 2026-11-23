namespace GymManagmentSystemG01.Entities
{
    public class MemberShip : BaseEntity
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int MemberId { get; set; }
        public Member Member { get; set; } = default!;
        public int PlanId { get; set; }
        public Plan plan { get; set; } = default!;
        public String Status => StartDate> DateTime.Now ? "UpComing" : EndDate> DateTime .Now ? "Active": "Expired";
    }
}
