﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BearMountain.Models
{
    public class UserBasket
    {
        public int ID { get; set; }

        public string UserID { get; set; }

        public ICollection<BasketItems> BasketItems { get; set; }
    }
}
