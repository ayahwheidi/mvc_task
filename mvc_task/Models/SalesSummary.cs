﻿using System;
using System.Collections.Generic;

namespace mvc_task.Models
{
    public partial class SalesSummary
    {
        public string Brand { get; set; } = null!;
        public string Category { get; set; } = null!;
        public short ModelYear { get; set; }
        public decimal? Sales { get; set; }
    }
}
