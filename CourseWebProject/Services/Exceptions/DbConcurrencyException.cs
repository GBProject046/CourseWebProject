﻿using System;

namespace CourseWebProject.Services.Exceptions
{
    public class DbConcurrencyException : ApplicationException
    {
        public DbConcurrencyException(string message) : base (message)
        {

        }
    }
}
