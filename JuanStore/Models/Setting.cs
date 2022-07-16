﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace JuanStore.Models
{
    public class Setting
    {
        public int Id { get; set; }
        [Required, StringLength(maximumLength: 255)]
        public string Key { get; set; }
        [Required, StringLength(maximumLength: 1000)]
        public string Value { get; set; }
    }
}
