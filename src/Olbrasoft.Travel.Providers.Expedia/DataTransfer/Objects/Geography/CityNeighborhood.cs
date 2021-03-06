﻿using System.ComponentModel.DataAnnotations;

namespace Olbrasoft.Travel.Providers.Expedia.DataTransfer.Objects.Geography
{
    public class CityNeighborhood : IHaveRegionIdRegionName
    {
        // ReSharper disable once InconsistentNaming
        [Key]
        public long RegionID { get; set; }
        [Required]
        [StringLength(255)]
        public string RegionName { get; set; }
        [Required]
        public string Coordinates { get; set; }
    }
}
