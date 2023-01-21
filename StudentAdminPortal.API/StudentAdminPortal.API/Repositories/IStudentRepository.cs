﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using StudentAdminPortal.API.DataModels;

namespace StudentAdminPortal.API.Repositories
{
    public interface IStudentRepository
    {
        public Task<List<Student>> GetStudentsAsync();

        public Task<Student> GetStudentAsync(Guid studentId);
    }
}
