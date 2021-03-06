﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HealthyLife.Business.Models
{
    public class Specialization : IEntity
    {
        public virtual int Id { get; set; }

        public virtual string Name { get; set; }

        public virtual string Description { get; set; }
    }
}