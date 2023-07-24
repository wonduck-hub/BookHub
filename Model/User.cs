﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHub.Model
{
    public class User
    {
        private int id;
        private int age;
        private string name;
        private string email;

        public User(int id, int age, string name, string email)
        {
            this.id = id;
            this.age = age;
            this.name = name;
            this.email = email;
        }

        public int Id { get { return id; } }
        public int Age { get { return age; } }
        public string Name { get { return name; } }
        public string Email { get { return email; } }
    }
}
