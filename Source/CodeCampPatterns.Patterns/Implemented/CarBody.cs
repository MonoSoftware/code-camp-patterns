﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCampPatterns.Patterns.Implemented
{
    public class CarBody : IBody
    {
        public string BodyParts
        {
            get
            {
                return "Body parts for a car.";
            }
        }
    }
}
