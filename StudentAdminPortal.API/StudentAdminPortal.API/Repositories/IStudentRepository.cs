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
        public Task<List<Gender>> GetGenderAsync();
        public Task<bool> Exists(Guid studentId);
        public Task<Student> UpdateStudent(Guid studentId, Student request);
        public Task<Student> DeleteStudent(Guid studentId);
        public Task<Student> AddStudent(Student request);
        public Task<Boolean> UpdateProfileImage(Guid studentId, string profileImageUrl);
    }
}
