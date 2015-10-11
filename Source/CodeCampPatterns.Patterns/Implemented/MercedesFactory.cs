using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCampPatterns.Patterns.Implemented
{
    public class MercedesFactory : Factory
    {
        public override Car CreateCar(MercedesSeries series)
        {
            switch (series)
            {
                case MercedesSeries.A:
                    Car aClass = new Car();
                    aClass.Name = "Mercedes A Class";
                    aClass.PowerInHp = 110;
                    aClass.SerialNumber = "20151010_A";
                    aClass.CreatedDate = DateTime.Now;
                    return aClass;
                case MercedesSeries.B:
                    Car bClass = new Car();
                    bClass.Name = "Mercedes B Class";
                    bClass.PowerInHp = 130;
                    bClass.SerialNumber = "20151010_B";
                    bClass.CreatedDate = DateTime.Now;
                    return bClass;
                case MercedesSeries.C:
                    Car cClass = new Car();
                    cClass.Name = "Mercedes C Class";
                    cClass.PowerInHp = 110;
                    cClass.SerialNumber = "20151010_C";
                    cClass.CreatedDate = DateTime.Now;
                    return cClass;
                case MercedesSeries.E:
                    Car eClass = new Car();
                    eClass.Name = "Mercedes E Class";
                    eClass.PowerInHp = 110;
                    eClass.SerialNumber = "20151010_E";
                    eClass.CreatedDate = DateTime.Now;
                    return eClass;
                case MercedesSeries.S:
                    Car sClass = new Car();
                    sClass.Name = "Mercedes S Class";
                    sClass.PowerInHp = 250;
                    sClass.SerialNumber = "20151010_S   ";
                    sClass.CreatedDate = DateTime.Now;
                    return sClass;
                default:
                    return null;
            }
        }
    }

    
}
