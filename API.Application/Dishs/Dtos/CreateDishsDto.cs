using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Application.Dishs.Dtos
{
    public class CreateDishsDto
    {
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;
        public double Price { get; set; } = default!;

        public int? KiloCarlo { get; set; } = default!;
    }
}
