using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MVCApp2.Models;

public partial class Ingredient
{
    [Key]
    public int Id { get; set; }

    [Column(TypeName = "text")]
    public string Name { get; set; } = null!;
}
