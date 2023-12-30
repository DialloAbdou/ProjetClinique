using Clinique.Services.Implementations;
using CLinique.Models.Models;
using FluentAssertions;

namespace CliniqueTestUnitaire.Implementations
{
    public class PatientServicesTestUnitaire
    {

        private PatientService _patientService;
        public PatientServicesTestUnitaire()
        {
            _patientService = new PatientService();
        }

        [Fact]
        public void GetAllPatients_Should_Empty_when_No_Patient_in_List()
        {
            // Arrange
            // Act
            var result = _patientService.GetAllPatients();
            // Asser
            result.Should().BeEmpty();
        }


        [Fact]
        public void GetAllPatients_Should_All_Patient_In_List_When_No_EmpTy_List()
        {
            // Assertion 
            Patient patient1 = new Patient
            {
                Id = 1,
                Nom = "NomPatient1",
                Prenom = "PrePatient",
                Adresse = "Adress1",
                Age = 25

            };
            // Act
            _patientService.AddPatient(patient1);
            var result = _patientService.GetAllPatients();
            result.Should().NotBeEmpty();
        }


        [Fact]
        public void AddPatient_Should_ThrowNullArgumentException_When_Patient_Is_Null()
        {
            // Assertion 
            Patient patient2 = null;
            // Act
            Action act=()=> _patientService.AddPatient(patient2);
            act.Should().Throw<ArgumentNullException>();
           
        }
           
        [Fact]
        public void AddPatient_Should_Be_Return_new_Patient_When_AddPatient_in_DB()
        {
            // Assertion 

            Patient patient2 = new Patient
            {
                Id = 2,
                Nom = "NomPatient2",
                Prenom = "PrePatient2",
                Adresse = "Adress2",
                Age = 25

            };
            // Act
            var patient = _patientService.AddPatient(patient2);
            patient.Should().NotBeNull();
            patient.Nom.Should().Be("NomPatient2");
            patient.Prenom.Should().Be("PrePatient2");
            patient.Age.Should().Be(25);
        }



        [Fact]
        public void AddPatient_Should_Be_Return_ThrowExeception_When_Patient_Existed_In_Db()
        {
            // Assertion 


            Patient patient2 = new Patient
            {
                Id = 2,
                Nom = "NomPatient2",
                Prenom = "PrePatient2",
                Adresse = "Adress2",
                Age = 25

            };
            var patient = _patientService.AddPatient(patient2);
            Patient patient3 = new Patient
            {
                Id = 2,
                Nom = "NomPatient2",
                Prenom = "PrePatient2",
                Adresse = "Adress2",
                Age = 25

            };
            // Act
            Action act = () => _patientService.AddPatient(patient3);
            act.Should().Throw<ArgumentException>();    
         ;
        }
    }
}
