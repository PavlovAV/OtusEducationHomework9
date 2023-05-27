using OtusEducationHomework9.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtusEducationHomework9.Models
{
    public class Spool : Product, IMyCloneable<Spool>, ICloneable
    {
        public int Diameter { get; set; }
        public int Height { get; set; }

        public Spool(decimal quantity, int diameter, int height) : base(quantity)
        {
            Diameter = diameter;
            Height = height;
        }
        public new Spool MyClone()
        {
            return new Spool(this.Quantity, this.Diameter, this.Height);
        }

        public new object Clone()
        {
            return MyClone();
        }

        public override string ToString()
        {
            return $"{base.ToString()}; Diameter = {Diameter}; Height = {Height}";
        }
    }
}
