﻿using Anyar_1_.Models.Base;

namespace Anyar_1_.Models
{
    public class Team: BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int PositionId { get; set; }
        public Position Position { get; set; }
    }
}
