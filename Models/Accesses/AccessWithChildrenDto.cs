﻿namespace Dorbit.Identity.Models.Accesses;

public class AccessWithChildrenDto
{
    public string Name { get; set; }
    public List<string> Children { get; set; } = new();
}