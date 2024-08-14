namespace Repository.Client.Models;

public partial class Beer
{
    public Guid BeerId { get; set; }

    public string Name { get; set; } = null!;

    public string Style { get; set; } = null!;

    public Guid BrandId { get; set; }

    public virtual Brand Brand { get; set; } = null!;
}
