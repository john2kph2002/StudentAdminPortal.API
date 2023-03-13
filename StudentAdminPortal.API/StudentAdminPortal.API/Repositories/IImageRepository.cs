﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace StudentAdminPortal.API.Repositories
{
    public interface IImageRepository
    {
        public Task<string> Upload(IFormFile file, string fileName);
    }
}
