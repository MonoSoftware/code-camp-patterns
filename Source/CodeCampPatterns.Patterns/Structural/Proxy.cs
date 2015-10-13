﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCampPatterns.Patterns.Structural
{
    public class Proxy : ISubject
    {
        private RealSubject realSubject;

        public void PerformAction()
        {
            if (realSubject == null)
            {
                realSubject = new RealSubject();
            }
            realSubject.PerformAction();
        }
    }
}
