﻿namespace JwtWebAPITutorial
{
    public class UserS
    {
        public string Email { get; set; } = string.Empty;

        public byte[] PasswordHash { get; set;}
        public byte[] PasswordSalt { get; set;}

        public string Role { get; set; }
    }
}
