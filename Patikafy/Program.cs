using Patikafy;

class Program
{
    static void Main()
    {
        // Şarkıcı listesini tanımlama
        var singers = new List<Singer>
        {
            new Singer("Ajda", "Pekkan", "Pop", 1968, 20000000),
            new Singer("Sezen", "Aksu", "Türk Halk Müziği/Pop", 1971, 10000000),
            new Singer("Funda", "Arar", "Pop", 1999,3000000),
            new Singer("Sertab", "Erener", "Pop", 1994, 5000000),
            new Singer("Sıla", "", "Pop", 2009, 3000000),
            new Singer("Serdar", "Ortaç", "Pop", 1994, 10000000),
            new Singer("Tarkan", "", "Pop", 1992, 40000000),
            new Singer("Hande", "Yener", "Pop", 1999, 7000000),
            new Singer("Hadise", "", "Pop", 2005, 5000000),
            new Singer("Gülber", "Ergen", "Pop/Türk Halk Müziği", 1997, 10000000),
            new Singer("Neşet", "Ertaş", "Türk Halk Müziği/Türk Sanat Müziği", 1960, 2000000),
        };

        // Adı 'S' ile başlayan şarkıcılar
        var singersWithS = singers
            .Where(s => s.FirstName.StartsWith("S"))
            .ToList();

        Console.WriteLine("Adı 'S' ile başlayan şarkıcılar:");
        singersWithS.ForEach(s => Console.WriteLine($"{s.FirstName} {s.LastName}"));

        Console.WriteLine("--------------------------------");

        // Albüm satışları 10 milyon'un üzerinde olan şarkıcılar
        var topSellingSingers = singers
            .Where(s => s.AlbumSales > 10000000)
            .ToList();

        Console.WriteLine("\nAlbüm satışları 10 milyon'un üzerinde olan şarkıcılar:");
        topSellingSingers.ForEach(s => Console.WriteLine($"{s.FirstName} {s.LastName} - {s.AlbumSales} albüm"));

        Console.WriteLine("--------------------------------");

        // 2000 yılı öncesi çıkış yapmış ve pop müzik yapan şarkıcılar, gruplayarak sıralama
        var pre2000PopSingers = singers
            .Where(s => s.DebutYear < 2000 && s.MusicGenre.Contains("Pop"))
            .GroupBy(s => s.DebutYear)
            .OrderBy(g => g.Key) // Çıkış yılına göre sıralama
            .SelectMany(g => g.OrderBy(s => s.FirstName)) // Her grup içindeki şarkıcıları isimlerine göre sıralama
            .ToList();

        Console.WriteLine("\n2000 yılı öncesi çıkış yapmış ve pop müzik yapan şarkıcılar:");
        pre2000PopSingers.ForEach(s => Console.WriteLine($"{s.FirstName} {s.LastName} - {s.DebutYear}"));

        Console.WriteLine("--------------------------------");

        // En çok albüm satan şarkıcı
        var bestSellingSinger = singers
            .OrderByDescending(s => s.AlbumSales)
            .First();

        Console.WriteLine($"\nEn çok albüm satan şarkıcı: {bestSellingSinger.FirstName} {bestSellingSinger.LastName} - {bestSellingSinger.AlbumSales} albüm");

        Console.WriteLine("--------------------------------");

        // En yeni çıkış yapan şarkıcı
        var newestSinger = singers
            .OrderByDescending(s => s.DebutYear)
            .First();
        // En eski çıkış yapan şarkıcı
        var oldestSinger = singers
            .OrderBy(s => s.DebutYear)
            .First();

        Console.WriteLine($"\nEn yeni çıkış yapan şarkıcı: {newestSinger.FirstName} {newestSinger.LastName} - {newestSinger.DebutYear}");
        Console.WriteLine($"En eski çıkış yapan şarkıcı: {oldestSinger.FirstName} {oldestSinger.LastName} - {oldestSinger.DebutYear}");
    }
}


