﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Dorbit.Framework.Entities;

namespace Dorbit.Identity.Entities;

public class Access : FullEntity
{
    [StringLength(64), Required] public string Name { get; set; }
    [StringLength(128)] public string Description { get; set; }
    public Guid? ParentId { get; set; }

    [ForeignKey(nameof(ParentId))] public Access Parent { get; set; }

    public ICollection<Access> Children { get; set; }
}