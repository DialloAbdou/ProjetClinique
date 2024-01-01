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

        private IPatientService _patientService;
        private  Mock<IPatientRepository> _patientRepositoryMock = new Mock<IPatientRepository>();
        Fixture _fixture = new();
        public PatientServicesTestUnitaire()
        {
            _patientService = new PatientService(_patientRepositoryMock.Object);
        }

        [Fact]
        public void GetAllPatients_Should_Empty_when_No_Patient_in_List()
        {
            // Arrange
            _patientRepositoryMock.Setup(m=>m.GetPatientAll())
                .Returns(new List<Patient>());
            // Act
            var result = _patientService.GetAllPatients();
            // Asser
            result.Should().BeEmpty();
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
        public void AddPatient_Should_Be_Return_new_Patient_In_DB()
        {
            // Assertion 
            Patient p = null;

            _patientRepositoryMock.Setup(m => m.AddPatient(It.IsAny<Patient>()))
                .Callback( (Patient patient)=> p= patient);
        
            Patient PatientRandom = new Patient()
            // Act
            //var patient = _patientService.AddPatient(patient2);
            //patient.Should().NotBeNull();
            //patient.Nom.Should().Be("NomPatient2");
            //patient.Prenom.Should().Be("PrePatient2");
            //patient.Age.Should().Be(25);
        }



        //[Fact]
        //public void AddPatient_Should_Be_Return_ThrowExeception_When_Patient_Existed_In_Db()
        //{
        //    // Assertion 


        //    Patient patient2 = new Patient
        //    {
        //        Id = 2,
        //        Nom = "NomPatient2",
        //        Prenom = "PrePatient2",
        //        Adresse = "Adress2",
        //        Age = 25

        //    };
        //    var patient = _patientService.AddPatient(patient2);
        //    Patient patient3 = new Patient
        //    {
        //        Id = 2,
        //        Nom = "NomPatient2",
        //        Prenom = "PrePatient2",
        //        Adresse = "Adress2",
        //        Age = 25

        //    };
        //    // Act
        //    Action act = () => _patientService.AddPatient(patient3);
        //    act.Should().Throw<ArgumentException>();    
        // ;
        //}
    }
}
