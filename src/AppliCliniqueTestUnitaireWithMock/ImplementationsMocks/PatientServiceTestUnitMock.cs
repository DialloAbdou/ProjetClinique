using AutoFixture;
using Clinique.Data.Abstractions;
using Clinique.Services.AbstractsMock;
using Clinique.Services.ImplementationsMocks;
using CLinique.Models.Models;
using FluentAssertions;
using Moq;

namespace AppliCliniqueTestUnitaireWithMock.ImplementationsMocks
{
    public class PatientServiceTestUnitMock
    {
        private IPatientServiceMock _patientServiceMock;
        private Mock<IPatientRepository> _patientRepositoryMock;
        private Fixture _fixture = new();
        public PatientServiceTestUnitMock()
        {
            _patientRepositoryMock = new Mock<IPatientRepository>();
            _patientServiceMock = new PatientServiceMock(_patientRepositoryMock!.Object);
        }

        [Fact]
        public async Task GetAllAllPatient_Shoul_Be_Return_Empty_When_Not_Patient_In_Db()
        {
            _patientRepositoryMock.Setup(p => p.GetAllAsync()).ReturnsAsync(new List<Patient>());

            var result = await _patientServiceMock.GetAllPatients();
            result.Should().BeEmpty();


        }

        [Fact]
        public async Task GetAllAllPatient_Shoul_Be_Return_Collection_Patient_In_Db()
        {
            _patientRepositoryMock.Setup(p => p.GetAllAsync())
               .ReturnsAsync(new List<Patient> { new Patient { Id = 1, Nom = "Nom1", Prenom = "prenom1", Adresse = "Adress1", NomPathologie = "nompathologie" } });

            var result = await _patientServiceMock.GetAllPatients();
            result.Should().NotBeEmpty();
            result.Should().HaveCount(1);
        }

        [Fact]
        public async Task AddPatient_Should_Be_Return_New_Paient_When_Add_in_DB()
        {
            Patient p = null;

            _patientRepositoryMock
                .Setup(p => p.AddAsync(It.IsAny<Patient>()))
                .Callback((Patient patient) => p = patient);
            var patient =   await _patientServiceMock.AddPatient(new Patient { Nom = "Nom1", Prenom = "Prenom1", Adresse = "Adresse1" });
            p.Should().NotBeNull();
            p.Nom.Should().Be("Nom1");
            p.Prenom.Should().Be("Prenom1");
            p.Adresse.Should().Be("Adresse1");

            _patientRepositoryMock.Verify(m=>m.AddAsync(It.Is<Patient>(p=>p.Nom =="Nom1" && p.Prenom=="Prenom1")));

        }

        

    }
}
