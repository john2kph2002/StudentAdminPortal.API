﻿using AutoMapper;
using StudentAdminPortal.API.DataModels;
using StudentAdminPortal.API.DomainModels;
using DataModels = StudentAdminPortal.API.DataModels;

namespace StudentAdminPortal.API.Profiles.AfterMap
{
    public class UpdateStudentRequestAfterMap : IMappingAction<UpdateStudentRequest, DataModels.Student>
    {
        public void Process(UpdateStudentRequest source, DataModels.Student destination, ResolutionContext context)
        {
            destination.Address = new DataModels.Address()
            {
                PhysicalAddress = source.PhysicalAddress,
                PostalAddress = source.PostalAddress
            };
        }
    }
}
