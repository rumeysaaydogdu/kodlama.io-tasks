﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Color : IEntity
    {
        //propertiler
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
