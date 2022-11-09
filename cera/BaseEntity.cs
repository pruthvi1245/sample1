﻿using System;

namespace Enitites
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public string UpdatedBy { get; set; }
        public string CreatedBy { get; set; }
        public bool IsActive { get; set; }
    }
}
