﻿namespace cryptostatistics.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public virtual UserList UsersList { get; set; }
    }
}
