﻿namespace Dorbit.Identity.Contracts.Auth;

public class AuthLoginRequest
{
    public string Username { get; set; }
    public string UserAgent { get; set; }
    
    public string Value { get; set; }
    public LoginStrategy LoginStrategy { get; set; }
}