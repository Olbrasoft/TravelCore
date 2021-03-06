using Olbrasoft.Travel.Data.Base;
using System.Collections.Generic;

namespace Olbrasoft.Travel.Data.Accommodation
{
    public class Chain : OwnerCreatorIdAndCreator, IHaveExpediaId<int>, IHaveName
    {
        public int ExpediaId { get; set; } = int.MinValue;

        public string Name { get; set; }

        public virtual ICollection<RealEstate> Accommodations { get; set; }
    }
}