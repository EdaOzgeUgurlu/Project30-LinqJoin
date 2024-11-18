using Project30_LinqJoin;

class Program
{
    static void Main(string[] args)
    {
        // Yazarlar tablosu için örnek veriler
        List<Author> authors = new List<Author> //yazarlar listesi oluşturuyoruz
            {
                new Author { AuthorId = 1, Name = "Ahmet Ümit" },
                new Author { AuthorId = 2, Name = "Jose Saramago" },
                new Author { AuthorId = 3, Name = "İlber Ortaylı" }
            };

        // Kitaplar tablosu için örnek veriler
        List<Book> books = new List<Book> //kitaplar listesi oluşturuyoruz
            {
                new Book { BookId = 1, Title = "Beyoğlu'nun En Güzel Abisi", AuthorId = 1 },
                new Book { BookId = 2, Title = "Körlük", AuthorId = 2 },
                new Book { BookId = 3, Title = "Türkiye'nin Yakın Tarihi", AuthorId = 3 },
                new Book { BookId = 4, Title = "Patasana", AuthorId = 1 }
            };

        // LINQ join sorgusu: Kitapları ve yazarları birleştir
        var query = from book in books
                    join author in authors
                    on book.AuthorId equals author.AuthorId
                    select new
                    {
                        BookTitle = book.Title,
                        AuthorName = author.Name
                    };

        // Sonuçları yazdır
        Console.WriteLine("Kitaplar ve Yazarlar:");
        foreach (var item in query)
        {
            Console.WriteLine($"Kitap: {item.BookTitle}, Yazar: {item.AuthorName}");
        }
    }
}