using System;
using System.Collections.Generic;

namespace SyytDotNetTrainingBatch3_2_.Database.AppDbContextModels;

public partial class Product
{
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;

    public decimal Price { get; set; }

    public bool DeleteFlag { get; set; }
}
