﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Mervi.Database.Entities
{
    public class BaseEntity
    {
        public long Id { get; set; }
        public DateTime DeletedDate { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
