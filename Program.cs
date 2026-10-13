public enum state
{
    Dostupna,
    Vypujcena,
    Rezervovana
}

class Kniha
{
    private string name;
    private string author;
    private int date;
    private string isbn;
    private state stav;
    
    public Kniha(string name, string author, int date, string isbn, state stav)
    {
        this.name = name;
        this.author = author;
        this.date = date;
        this.isbn = isbn;
        this.stav = stav;
    }

    public Kniha()
    {
        name = "Stíny nad Vltavou";
        author = "Kristian Maladji";
        date = 2019;
        isbn = "978-80-7432-115-3";
        stav = state.Dostupna;
    }

    private Kniha EnterBook()
    {
        Console.WriteLine("Enter a name of book: ");
        string name = Console.ReadLine();
        
        Console.WriteLine("Enter a author: ");
        string author = Console.ReadLine();
        
        Console.WriteLine("Enter a date: ");
        int date = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter a ISBN: ");
        string isbn = Console.ReadLine();
        Console.WriteLine("Enter a state: ");
        state stav = Enum.Parse<state>(Console.ReadLine(), true);
        
        return new Kniha(name, author, date, isbn, stav);
        
    }

}