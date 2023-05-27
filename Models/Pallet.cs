using OtusEducationHomework9.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtusEducationHomework9.Models
{
    public class Pallet : Product, IMyCloneable<Pallet>, ICloneable
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int Length { get; set; }

        public Pallet(decimal quantity, int width, int height, int length) : base(quantity)
        {
            Width = width;
            Height = height;
            Length = length;
        }
        public new Pallet MyClone()
        {
            return new Pallet(this.Quantity, this.Width, this.Height, this.Length);
        }

        public new object Clone()
        {
            return MyClone();
        }

        public override string ToString()
        {
            return $"{base.ToString()}; Width = {Width}; Height = {Height}; Length = {Length}";
        }
    }
}
