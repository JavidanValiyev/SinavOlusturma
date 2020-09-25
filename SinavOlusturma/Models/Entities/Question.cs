using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SinavOlusturma.Models.Entities
{
    public class Question
    {
        public int Id { get; set; }

        public string Tittle { get; set; }

        public ICollection<Option> Options { get; set; }
    }
}
