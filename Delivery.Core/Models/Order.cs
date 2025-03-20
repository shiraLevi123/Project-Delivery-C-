﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deliver.Core.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int NumHouse { get; set; }
        public string City { get; set; }
        public bool? Status { get; set; }//ממתין/בוצע/בתהליך
        public DateTime DateCreated { get; set; }
        public DateTime DateFinal { get; set; }
        public int DeliverId { get; set; }

    }
}
