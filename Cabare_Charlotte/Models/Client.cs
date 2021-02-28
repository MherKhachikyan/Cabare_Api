using System;
using System.Collections.Generic;
using System.Text;

namespace Cabare.Models
{
    public class Client
    {
        public int Id { get; set; }

        public string DeviceId { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
