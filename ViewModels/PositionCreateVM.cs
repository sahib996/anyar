using System.ComponentModel.DataAnnotations;

namespace Anyar_1_.ViewModels
{
    public class PositionCreateVM
    {
        [Required]
        public string Name { get; set; }
    }
}
