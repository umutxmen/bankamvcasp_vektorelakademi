﻿namespace BankaMVC.Areas.Admin.Models.Dtos.User
{
    public class NewUserDto
    {
        public string Nickname { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
    }
}
