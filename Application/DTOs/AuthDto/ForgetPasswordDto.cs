﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.AuthDto
{
    public class ForgetPasswordDto
    {
        [EmailAddress]
        public string? Email { get; set; }
    }
}
