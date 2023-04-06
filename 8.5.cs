using System;

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public float Price { get; set; }

    public Book(string title, string author, float price)
    {
        Title = title;
        Author = author;
        Price = price;
    }

    public void Print()
    {
        Console.WriteLine($"Title: {Title}, Author: {Author}, Price: {Price}");
    }
}

public class BookGenre : Book
{
    public string Genre { get; set; }

    public BookGenre(string title, string author, float price, string genre) : base(title, author, price)
    {
        Genre = genre;
    }

    public new void Print()
    {
        base.Print();
        Console.WriteLine($"Genre: {Genre}");
    }
}

public sealed class BookGenrePubl : BookGenre
{
    public string Publisher { get; set; }

    public BookGenrePubl(string title, string author, float price, string genre, string publisher) : base(title, author, price, genre)
    {
        Publisher = publisher;
    }

    public new void Print()
    {
        base.Print();
        Console.WriteLine($"Publisher: {Publisher}");
    }
}



class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");

    Book book1 = new Book("Kniga", "Andrejs", 25.34f);
    book1.Print();
    BookGenre bookGenre1 = new BookGenre("Kniga", "Andrejs", 25.34f, "boevik");
    bookGenre1.Print();
    BookGenrePubl bookGenrePubl1 = new BookGenrePubl("Kniga", "Andrejs", 25.34f, "boevik", "12");
    bookGenrePubl1.Print();
  }
}
