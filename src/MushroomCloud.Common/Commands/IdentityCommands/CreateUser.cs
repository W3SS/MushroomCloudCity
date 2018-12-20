﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MushroomCloud.Common.Commands.IdentityCommands
{
    public class CreateUser : ICommand
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
    }
}