﻿using Core.Entities;   // IEnt,ty'den miras alabilmek için
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Brand : IEntity
    {
        //propertiler
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
