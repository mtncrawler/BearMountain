﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BearMountain.Models
{
    public class UserBasket
    {
        [Key]
        public string UserID { get; set; }

        public int MyProperty { get; set; }
    }
}
