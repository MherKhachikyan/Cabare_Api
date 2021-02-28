using System;
using System.Collections.Generic;
using System.Text;

namespace Cabare.Models
{
    public class Order
    {
        public int Id { get; set; }

        public bool IsDeleted { get; set; }

        public Client Client { get; set; }
    }
}
