﻿namespace Dorbit.Identity.Models.Accesses;

public class AccessImportRequest
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public List<AccessImportRequest> Children { get; set; }
}