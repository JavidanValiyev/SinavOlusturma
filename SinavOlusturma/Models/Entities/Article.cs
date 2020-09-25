using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SinavOlusturma.Models.Entities
{
    public class Article
    {
        public int Id { get; set; }

        public string Tittle { get; set; }

        public string Content { get; set; }

        public ICollection<Question> Questions { get; set; }
    }
}
