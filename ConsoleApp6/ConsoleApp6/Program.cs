using System.Xml.Linq;

namespace ConsoleApp6;

internal class Program
{
    static void Main(string[] args)
    {
        Library library = new(3);
        Book book = new("Book",30,"Test",20);
        Book book2 = new("Book2", 30, "Test", 20);
        Book book3 = new("Book3", 30, "Test", 20);
        Book book4 = new("Book4", 30, "Test", 20);
        library.AddBook(book);
        library.AddBook(book2);
        library.AddBook(book3);
        library.AddBook(book4);

        foreach (var item in library.GetAllBooks())
        {
            item.ShowInfo();
        }
        library.GetBookById(2);
        book2.Sell();
        //book3.Sell();



        library.RemoveById(1);
    }
}
