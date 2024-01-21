using Clinique.Services.Implementations;
using CLinique.Models.Models;
using FluentAssertions;

namespace CliniqueTestUnitaire.Implementations
{
    public class PatientServicesTestUnitaire
    {
        PatientService _patientService;
        private List<Patient> _Listpatients = new List<Patient>();
        private static Patient patient = new Patient()
        {
            Id = 1,
            Nom = "NomPatient1",
            Prenom = "PrePatient",
            Adresse = "AdressPatient",
            Age = 25

        };
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
        
        [Fact]
        public void GetAllPatients_Should_Be_Retunr_No_BeEmpty_IN_Collection()
        {
            //Arrange
            // Act
            _patientService.IsNotExistPatient(patient).Should().BeTrue();
            _patientService.AddPatient(patient);
            var result = _patientService.GetAllPatients();
            //Assertion
            result.Should().NotBeEmpty();
            result.Should().HaveCount(1);
            var patient1 = result.First();
            patient1.Id.Should().Be(1);
            patient1.Nom.Should().Be(patient1.Nom);
            patient1.Prenom.Should().Be(patient1.Prenom);
            patient1.Adresse.Should().Be(patient1.Adresse);
            patient1.Age.Should().Be(patient1.Age);


        }

    }
}
