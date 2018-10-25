﻿using System.Collections.Generic;
using System.Data.SqlClient;

namespace Olbrasoft.Data.Entity.Framework.Bulk
{
    public class BulkConfig
    {
        public bool PreserveInsertOrder { get; set; }

        public bool SetOutputIdentity { get; set; }

        public int BatchSize { get; set; } = 2000;

        public int? NotifyAfter { get; set; }

        public int? BulkCopyTimeout { get; set; }

        public bool EnableStreaming { get; set; }

        public bool UseTempDB { get; set; }

        public bool WithHoldlock { get; set; } = true;

        public bool CalculateStats { get; set; }
        public StatsInfo StatsInfo { get; set; }

        public List<string> PropertiesToInclude { get; set; }

        public List<string> PropertiesToExclude { get; set; }

        public List<string> UpdateByProperties { get; set; }

        public SqlBulkCopyOptions SqlBulkCopyOptions { get; set; }

        protected bool HasOutput { get; set; }

        public HashSet<string> IgnoreColumns { get; set; } = new HashSet<string>();

        public HashSet<string> IgnoreColumnsUpdate { get; set; } = new HashSet<string>();
    }

    public class StatsInfo
    {
        public int StatsNumberInserted { get; set; }

        public int StatsNumberUpdated { get; set; }
    }
}