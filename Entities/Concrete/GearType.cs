﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class GearType: BaseEntity
    {

        public string Name { get; set; }
    }


}
