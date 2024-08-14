using System;
using System.Collections.Generic;

namespace Repository.Client.Models;

public partial class Brand
{
    public Guid BrandId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Beer> Beers { get; set; } = new List<Beer>();
}
