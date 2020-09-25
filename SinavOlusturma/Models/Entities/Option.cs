using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SinavOlusturma.Models.Entities
{
    public class Option
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public bool IsItTrue { get; set; }
    }
}
