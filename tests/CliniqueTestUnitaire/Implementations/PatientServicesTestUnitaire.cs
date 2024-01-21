using Clinique.Services.Implementations;
using CLinique.Models.Models;
using FluentAssertions;

namespace CliniqueTestUnitaire.Implementations
{
    public class PatientServicesTestUnitaire
    {
        PatientService _patientService;
        private List<Patient> _Listpatients = new List<Patient>();

        public PatientServicesTestUnitaire()
        {
            _patientService = new PatientService();
        }

        [Fact]
        public void GetAllPatients_Should_Be_Empty_At_Begining()
        {
            var result = _patientService.GetAllPatients();
            result.Should().BeEmpty();

        }



    }
}
