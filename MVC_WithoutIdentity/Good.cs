using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_WithoutIdentity
{
    public class Good
    {
        [Key]
        public Guid Id { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public int MinBuy { get; set; }
    }
}
