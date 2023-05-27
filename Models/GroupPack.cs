using OtusEducationHomework9.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtusEducationHomework9.Models
{
    public class GroupPack : Spool, IMyCloneable<GroupPack>, ICloneable
    {
        public int CountSpools { get; set; }

        public GroupPack(decimal quantity, int diameter, int height, int countSpools) : base(quantity, diameter, height)
        {
            CountSpools = countSpools;
        }
        public new GroupPack MyClone()
        {
            return new GroupPack(this.Quantity, this.Diameter, this.Height, this.CountSpools);
        }

        public new object Clone()
        {
            return MyClone();
        }

        public override string ToString()
        {
            return $"{base.ToString()}; CountSpools = {CountSpools}";
        }
    }
}
