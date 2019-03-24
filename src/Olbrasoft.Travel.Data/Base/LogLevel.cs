﻿using System.Collections.Generic;

namespace Olbrasoft.Travel.Data.Base
{
    public class LogLevel : OwnerCreatorInfoAndCreator, IHaveName, IHaveDescription
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Log> Logs { get; set; }
    }
}