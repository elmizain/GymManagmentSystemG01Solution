using GymManagmentSystemG01.Entities.Enums;

namespace GymManagmentSystemG01.Entities
{
    public class Trainer:GymUser
    {
        public DateTime HireDate { get; set; }
        public Specialties Specialties { get; set; }
        public ICollection<Session> Sessions { get; set; } = new HashSet<Session>();

    }
}
