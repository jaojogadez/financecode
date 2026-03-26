namespace MinhaLojinha.Models;

public class Produto {
    public long Id {get; private set;}
    public string Nome {get; set;}
    public string Category {get; set;}
    public string? Brand {get; set;}

    public Product()
    {

    }

    public Product(long id, string name, string category, string? brand) 
    {
        Id = Id;
        Nome = name;
        Category = category;
        Brand = brand;
    }
}