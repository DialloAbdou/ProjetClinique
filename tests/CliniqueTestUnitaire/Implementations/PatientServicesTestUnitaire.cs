using AutoFixture;
using Clinique.Data.Abstractions;
using Clinique.Services.Abstracts;
using Clinique.Services.Implementations;
using CLinique.Models.Models;
using FluentAssertions;
using Moq;

namespace CliniqueTestUnitaire.Implementations
{
    public class PatientServicesTestUnitaire
    {
        PatientService _patientService;
        private List<Patient> _Listpatients = new List<Patient>();
        Patient patient1 = new Patient
        {
            Id = 1,
            Nom = "patient1",
            Prenom = "prePatient1",
            Adresse = "Adresse1",
            Age = 25,

        };

        Patient patient2 = new Patient
        {
            Id = 2,
            Nom = "patient2",
            Prenom = "prePatient2",
            Adresse = "Adresse2",
            Age = 25,

        };

        Patient patient3 = new Patient
        {
            Id = 3,
            Nom = "patient3",
            Prenom = "prePatient3",
            Adresse = "Adresse3",
            Age = 25,

        };
        public PatientServicesTestUnitaire()
        {
            _patientService = new PatientService();
        }

        [Fact]
        public void GetAllPatients_should_Be_Empty_At_Benginin()
        {
            // Arrange
            // Act
            var result = _patientService.GetAllPatients();
            //Assertion
            result.Should().BeEmpty();
        }

        [Fact]
        public void GetAllPatients_should_Be_Return_Liste_Addmission_At_Day()
        {
            _patientService.AddMissionPatient(patient1, "scarlatine");
            var result = _patientService.GetAllPatients();
            result.Should().NotBeEmpty();
            var mypatient = result.FirstOrDefault();
            mypatient.Should().NotBeNull();
            mypatient!.Nom.Should().Be(mypatient.Nom);
            mypatient.Prenom.Should().Be(mypatient.Prenom);
            mypatient.Adresse.Should().Be(mypatient.Adresse);
            mypatient.NomPatologie.Should().Be(mypatient.NomPatologie);

        }

        [Fact]
        public void AddMissionPatient_When_IsAdmission_Should_Be_True()
        {
            var result = _patientService.isAdmission(_Listpatients);
               _Listpatients.Add(patient1);
        }

        [Fact]
        public void isAdmission_should_Be_Return_False_when_Collection_Count_LessOrEqual_To_Max()
        {
            //Assertion
            _Listpatients.Add(patient1);
            _Listpatients.Add(patient2);
            _Listpatients.Add(patient3); 
            _Listpatients.Add(patient2);
            _Listpatients.Add(patient3);
            _Listpatients.Add(patient2);
            _Listpatients.Add(patient3);
            // Action

            var result= _patientService.isAdmission(_Listpatients);
            result.Should().BeFalse();
        }

        [Fact]
        public void isAdmission_should_Be_Return_True_When_Collection_Count_Less_Or_Equal_To_10()
        {
            // Arrange
            _Listpatients.Add(patient1);
            _Listpatients.Add(patient2);
            _Listpatients.Add(patient3);
            // Act
            var result = _patientService.isAdmission(_Listpatients);
            // Assertion
            result.Should().BeTrue();

        }
    }
}
