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
            _patientRepositoryMock.Setup(m => m.GetAllAsync())
                .ReturnsAsync(new List<Patient>());
               
            // Act
            var result = _patientService.GetAllPatientAsync();
            // Asser
        }

           
        [Fact]
        public async void AddPatient_Should_Be_Return_new_Patient_In_DB()
        {
            // Assertion 
            Patient p = null;

            _patientRepositoryMock.Setup(m => m.AddAsync(It.IsAny<Patient>()))
                .Callback((Patient patient) => p = patient);
               
            Patient PatientRandom = _fixture.Create<Patient>();
            //// Act
            var patient = await  _patientService.AddPatientAsync(PatientRandom);
            //// Assert
            p.Should().NotBeNull();
            p!.Adresse.Should().Be(patient.Adresse);
            p!.Nom.Should().Be(patient.Nom);
            p.Prenom.Should().Be(patient.Prenom);
            p.Age.Should().Be(patient.Age);
   
        }


    }
}
