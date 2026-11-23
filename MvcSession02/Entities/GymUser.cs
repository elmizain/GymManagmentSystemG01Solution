using GymManagmentSystemG01.Entities.Enums;

namespace GymManagmentSystemG01.Entities
{
    public class GymUser: BaseEntity
    {
        public String Name { get; set; } = default!;
        public String Email { get; set; } = default!;
        public String Phone { get; set; } = default!;
        public DateOnly DataOfBirth { get; set; } = default!;
        public Gender Gender { get; set; } 
        public Address Address { get; set; } = default!;
    }
    
    
}
