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
            Nom = "patient 2",
            Prenom = "prePatient3",
            Adresse = "Adresse2",
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
        public void GetAllPatients_should_ThrowArgumentException_When_Max_Is_lowerOrEqual_To_Ten()
        {
            _patientService.AddMissionPatient(patient1, "scarlatine");
            _patientService.AddMissionPatient(patient2, "Tuberculose");
            _patientService.AddMissionPatient(patient3, "Varicelle");
            Action act = () => _patientService.GetAllPatients(); ;
            act.Should().Throw<ArgumentOutOfRangeException>();
        }
    }
}
