class Books
{
    public string name = "Здесь название книги";
    public string genre = "Здесь жанр книги";
    public DateTime release = new DateTime();
    public string autor_name = "Здесь имя автора";
    public string country = "Здесь страна происхождения книги";

    public void Print_gran()
    {
        Console.WriteLine("+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+");
    }


    public void Print_book()
    {
        Console.WriteLine($"название книги:\t{name}. " +
            $"\nДата ВЫпуска книги: {release}. " +
            $"\nЖанр книги: {genre}. \nCтрана происхождения книги: {country}. ");

    }
}