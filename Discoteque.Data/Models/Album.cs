namespace Discoteque.Data.Models;

public class Album : BaseEntity<int>{
    // A string is an array of char
    public string Name { get; set; } = ""; // default! 
    public int Year { get; set;}
    public Genres Genre { get; set; } = Genres.Unknown;
}

public enum Genres{
    Rock,
    Metal,
    Salsa,
    Merengue,
    Urban,
    Folk,
    Indie,
    Techno,
    Vallenato,
    Unknown
}