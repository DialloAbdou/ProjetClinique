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

        private Mock<IPatientRepository> _patientRepositoryMock = new Mock<IPatientRepository>();
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
            var patient = await _patientService.AddPatientAsync(PatientRandom);
            //// Assert
            p.Should().NotBeNull();
            p!.Adresse.Should().Be(patient.Adresse);
            p!.Nom.Should().Be(patient.Nom);
            p.Prenom.Should().Be(patient.Prenom);
            p.Age.Should().Be(patient.Age);

        }

        [Fact]
        public async void IsExistePatient_Should_Be_Return_True_When_Patient_Existed_in_DB()
        {
            // Arrange
            var patient = new Patient { Id = 1, Nom = "NomPatient1", Prenom = "PrePatient", Adresse = "Adress1", Age = 20 };
            _patientRepositoryMock.Setup(m => m.IsExitedPatient(patient))
            .ReturnsAsync(true);
      
            // Act
            var result = await _patientService.IsExistePatient(patient);
            //Assert

            result.Should().BeTrue();
        }


        [Fact]
        public async void GetAllPatients_Should_NotEmpty_when_Have_Patient_in_Db()
        {
            // Arrange
            _patientRepositoryMock.Setup(m => m.GetAllAsync())
                .ReturnsAsync(new List<Patient>() { new Patient { Id = 1, Nom = "NomPatient1", Prenom = "PrePatient", Adresse = "Adress1", Age = 20 }, new Patient { Id = 2, Nom = "NomPatient2", Prenom = "PrePatient2", Adresse = "Adress2", Age = 25} });

            var result = await _patientService.GetAllPatientAsync();

            // Assert
            result.Should().NotBeEmpty();
             
            var patient = result.FirstOrDefault(p=>p.Id == 1);
            patient.Should().NotBeNull();   
            patient!.Nom.Should().Be(patient.Nom);
            patient!.Adresse.Should().Be(patient.Adresse);
            patient!.Age.Should().Be(patient.Age);



        }
    }
}
