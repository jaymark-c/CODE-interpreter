﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CODE_language.Exceptions
{
    public class FileException : Exception
    {

        public FileException() : base("File Error")
        {
        }
    }
}
