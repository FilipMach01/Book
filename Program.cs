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

    public static Kniha EnterBook()
    {
        Console.WriteLine("Enter a name of book: ");
        string name = Console.ReadLine();
        
        Console.WriteLine("Enter a author: ");
        string author = Console.ReadLine();
        
        
        int date;
        while (true)
        {
            Console.WriteLine("Enter a date: ");
            string? vstup = Console.ReadLine();

            if (!int.TryParse(vstup, out date))
            {
                Console.WriteLine("date must be a full number");
                continue;
            }

            if (date < 1450 || date > 2026)
            {
                Console.WriteLine("not valid date");
            }
            break;
            
        }

        string isbn;
        while (true)
        {
            Console.WriteLine("Enter a ISBN: ");
            isbn = (Console.ReadLine() ?? "").Trim();

            if (string.IsNullOrWhiteSpace(isbn))
            {
                Console.WriteLine("enter a ISBN");
                continue;
            }

            break;

        }
        
        Console.WriteLine("Enter a state: ");
        state stav = Enum.Parse<state>(Console.ReadLine(), true);
        
        return new Kniha(name, author, date, isbn, stav);
        
    }

    public void VypisInfo()
    {
        Console.WriteLine($"Tato kniha se jmenuje: {name}, napsal/a ji: {author} a byla vydana v roce: {date}. Kniha je ve stavu {stav}, isbn = {isbn}");
    }

}

class Program
{
    static void Main()
    {
        Kniha harryPotter = new Kniha("Harry Potter a Kámen mudrců", "J. K. Rowling", 1997, "978-0-7475-3269-9", state.Dostupna);
        Kniha georgeOrwell = new Kniha("1984", "George Orwell", 1949, "978-0-14-118776-1", state.Dostupna);;
        Kniha kniha = Kniha.EnterBook();
        

        List<Kniha> knihovna = new List<Kniha>
        {
            harryPotter,
            georgeOrwell,
            kniha
        };
        foreach (Kniha book in knihovna)
        {
            book.VypisInfo();
        }
    }
}