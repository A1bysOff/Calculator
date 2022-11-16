using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.Entities
{
    public class History
    {
        public Guid Id { get; set; }
        public DateTime ActDateTime { get; set; } = DateTime.Now;
        bool IsAdmin { get; set; } = false;
        public Guid CaclulationId { get; set; }
        public Calculation Calculation { get; set; } = null!;

    }
}
