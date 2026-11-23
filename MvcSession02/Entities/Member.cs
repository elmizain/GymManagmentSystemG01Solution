namespace GymManagmentSystemG01.Entities
{
    public class Member:GymUser
    {
        public String? photo { get; set; }
        public ICollection<MemberShip> MemberShips { get; set; } = new HashSet<MemberShip>();

    }
}
