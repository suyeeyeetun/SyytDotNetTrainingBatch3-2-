using System;
using System.Collections.Generic;

namespace SyytDotNetTrainingBatch3_2_.Database.AppDbContextModels;

public partial class TblProductCategory
{
    public int ProductCategoryId { get; set; }

    public string ProductCategoryCode { get; set; } = null!;

    public string ProductCategoryName { get; set; } = null!;
}
