 class Autor
 {
    public string name = "Здесь имя автора";
    public string first_name = "Здесь фамилия автора";
    public DateTime birth_day = new DateTime();
    public DateTime death_day = new DateTime();
    public string genre = "Здесь жанр автора";
    public string country = "Здесь происхождение автора";


    public void Print_bred()
    {
        Console.WriteLine("+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+");
    }

    public void Print_autor()
    {
        Console.WriteLine($"Имя автора:\t{name}. \nФамилия автора: {first_name}. " +
            $"\nДата рождения автора: {birth_day}.\nДата смерти автора: {death_day}. " +
            $"\nЖанр автора: {genre}. \nпроисхождение автора: {country}. ");
    }

 
}


