using CLinique.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinique.Services.AbstractsMock
{
    public interface IPatientServiceMock
    {
        Task<Patient> AddPatient(Patient patient);
        Task<IEnumerable<Patient>> GetAllPatients();
        Task<bool> IsExistPatient(Patient patient);

    }
}
