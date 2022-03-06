﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopTenPresidents.Shared.TransferDtos;

public class PresidentTransferDto
{
     public string FirstName { get; set; } = null!;

     public string? MiddleName { get; set; }

     public string LastName { get; set; } = null!;

     public DateTime DateOfBirth { get; set; }

     public DateTime? DateOfDeath { get; set; }
}
