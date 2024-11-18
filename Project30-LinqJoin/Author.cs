using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project30_LinqJoin
{
    // Yazarlar tablosuna karşılık gelen sınıf
    public class Author
    {
        public int AuthorId { get; set; } // Yazarın benzersiz kimliği
        public string Name { get; set; }  // Yazarın adı
    }
}
