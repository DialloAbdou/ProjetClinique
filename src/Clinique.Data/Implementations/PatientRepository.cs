﻿using Clinique.Data.Abstractions;
using CLinique.Models.Models;
using Microsoft.EntityFrameworkCore;

namespace Clinique.Data.Implementations
{
    public class PatientRepository : Repository<Patient>, IPatientRepository
    {
        public PatientRepository(CliniqueDbContext cliniqueDbContext) : base(cliniqueDbContext)
        {
        }

        private CliniqueDbContext ClinqieDbContext => dbContext as CliniqueDbContext;

        public Task AddMissionPatientAsync(Patient patient, string nomPathologie)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Patient>> GetAllPatientAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> isAdmission(List<Patient> patients)
        {
            throw new NotImplementedException();
        }
    }
}
