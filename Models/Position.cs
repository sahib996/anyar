using Anyar_1_.Models.Base;

namespace Anyar_1_.Models
{
    public class Position: BaseEntity
    {
        public string Name { get; set; }
        
        public List<Team> Team { get; set; }
    }
}
