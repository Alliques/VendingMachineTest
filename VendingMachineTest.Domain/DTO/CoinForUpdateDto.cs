﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineTest.Domain.DTO
{
    public class CoinForUpdateDto
    {
        public Guid Guid { get; set; }
        public int TotalCount { get; set; }

        public bool IsBlocked { get; set; }

        public IFormFile ImageFile { get; set; }
    }
}