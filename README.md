# 📚 Library Management System

Library Management System, **yazarlar** ve **kitaplar** arasındaki ilişkiyi yönetmek ve ilişkilendirmek için geliştirilmiş bir **C# Konsol Uygulaması**dır. Uygulama, LINQ kullanarak yazar ve kitap tablolarını birleştirir ve ilişkili verileri ekrana yazdırır.

## 📖 İçindekiler

- [Hakkında](#hakkında)
- [Özellikler](#özellikler)
- [Kullanılan Teknolojiler](#kullanılan-teknolojiler)
- [Kurulum](#kurulum)
- [Kullanım](#kullanım)
- [Kodun Yapısı](#kodun-yapısı)
- [Çalışma Mantığı](#çalışma-mantığı)


---

## Hakkında

Bu uygulama, LINQ kullanarak iki veri kümesi (yazarlar ve kitaplar) üzerinde **birleştirme (join)** işlemi yapmayı öğretmek için basit bir örnek sunar. Uygulama, aşağıdaki işlevleri yerine getirir:

1. **Veri Modelleme:** Yazarlar ve kitaplar için sınıflar oluşturur.
2. **Veri İlişkilendirme:** LINQ `join` kullanarak kitapları yazarlara bağlar.
3. **Konsol Çıktısı:** Her kitabın başlığı ve yazarı konsola yazdırılır.

---

## Özellikler

- Yazarlar ve kitaplar tabloları arasında ilişki kurma.
- LINQ sorguları ile veri birleştirme.
- Kullanıcı dostu konsol çıktısı ile ilişkilendirilmiş verileri gösterme.

---

## Kullanılan Teknolojiler

- **C#:** Modern ve güçlü bir programlama dili.
- **LINQ (Language Integrated Query):** Veri sorgulama ve birleştirme işlemleri için.
- **.NET Core SDK:** Uygulamanın çalışması için gerekli framework.

---

## Kurulum

### Gereksinimler
- **.NET Core SDK** (En az 6.0 sürümü). İndirmek için [buraya tıklayın](https://dotnet.microsoft.com/download).

### Adım 1: Projeyi Klonlayın
```bash
git clone https://github.com/kullaniciAdi/LibraryManagement.git
```

### Adım 2: Proje Dizini
```bash
cd LibraryManagement
```

### Adım 3: Çalıştırın
```bash
dotnet run
```

---

## Kullanım

1. Proje çalıştırıldığında konsol ekranında yazarlar ve kitapların ilişkili olduğu bir liste görüntülenecektir.
2. Liste, kitap başlıklarını ve bu kitapların yazarlarını içerir.

---

## Kodun Yapısı

### 1. **`Author` Sınıfı**
Yazarlar tablosunu temsil eder.

```csharp
public class Author
{
    public int AuthorId { get; set; } // Yazarın benzersiz kimliği
    public string Name { get; set; }  // Yazarın adı
}
```

### 2. **`Book` Sınıfı**
Kitaplar tablosunu temsil eder.

```csharp
public class Book
{
    public int BookId { get; set; }   // Kitabın benzersiz kimliği
    public string Title { get; set; } // Kitabın başlığı
    public int AuthorId { get; set; } // Yazarın kimliğine referans
}
```

### 3. **`Main` Metodu**
Ana metot, aşağıdaki adımları içerir:

- **Veri Oluşturma:** Yazarlar ve kitaplar için listeler oluşturulur.
- **LINQ Sorgusu:** Kitaplar ve yazarlar `join` kullanılarak birleştirilir.
- **Sonuçları Yazdırma:** Birleştirilen veriler ekrana yazdırılır.

```csharp
var query = from book in books
            join author in authors
            on book.AuthorId equals author.AuthorId
            select new
            {
                BookTitle = book.Title,
                AuthorName = author.Name
            };

foreach (var item in query)
{
    Console.WriteLine($"Kitap: {item.BookTitle}, Yazar: {item.AuthorName}");
}
```

---

## Çalışma Mantığı

### 1. **Veri İlişkilendirme**
Kitaplar ve yazarlar, `AuthorId` özelliği üzerinden ilişkilendirilir. LINQ `join` sorgusu şu şekilde çalışır:
- Her kitabın `AuthorId` değeri ile yazarların `AuthorId` değeri karşılaştırılır.
- Eşleşen kayıtlar birleştirilir.

### 2. **Sonuçların Yazdırılması**
Birleştirilen sonuçlar anonim bir nesne olarak alınır ve her bir kayıt konsola yazdırılır.

---

