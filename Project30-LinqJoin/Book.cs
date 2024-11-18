using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project30_LinqJoin
{
    // Kitaplar tablosuna karşılık gelen sınıf
    public class Book
    {
        public int BookId { get; set; }   // Kitabın benzersiz kimliği
        public string Title { get; set; } // Kitabın başlığı
        public int AuthorId { get; set; } // Yazar ile ilişkiyi belirten kimlik
    }
}
