﻿using System;

namespace smart_helper_
{
    class User
    {
        public String Username { get; }
        
        public String Password { get; }

        public User(String Username, String Password)
        {
            this.Username = Username;
            this.Password = Password;
        }
    }
}
