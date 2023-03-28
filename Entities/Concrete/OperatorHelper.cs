﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class OperatorHelper : IEntity
    {
        public int Id { get; set; }
        public int HelperId { get; set; }
        public string Address { get; set; }
        public string InfoAboutHelp { get; set; }
    }
}