﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.Models
{
    public class Cidade
    {
        [BindProperty]
        public string CEP { get; set; }
    }
}
