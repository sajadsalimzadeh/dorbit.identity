﻿using System;
using System.Collections.Generic;

namespace Dorbit.Identity.Contracts.Privileges;

public class PrivilegeDto
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
    public List<string> Accesses { get; set; }
}