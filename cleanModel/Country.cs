﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace cleanModel;

[Table("Country")]
public partial class Country
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("name")]
    [StringLength(50)]
    public string Name { get; set; } = null!;

    [Column("iso2")]
    [StringLength(2)]
    [Unicode(false)]
    public string Iso2 { get; set; } = null!;

    [Column("iso3")]
    [StringLength(3)]
    [Unicode(false)]
    public string Iso3 { get; set; } = null!;

    [InverseProperty("Country")]
    public virtual ICollection<City> Cities { get; set; } = new List<City>();
}
