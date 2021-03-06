﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Olbrasoft.Travel.Data.Base
{
    public abstract class CreationInfo<T> : IHaveId<T>, IHaveDateAndTimeOfCreation
    {
        [Key]
        [Column(Order = 1)]
        public T Id { get; set; }

        [DefaultValue("GetUtcDate()")]
        public DateTime Created { get; set; }
    }
}