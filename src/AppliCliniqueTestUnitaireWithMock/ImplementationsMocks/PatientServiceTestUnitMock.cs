using Clinique.Data.Abstractions;
using Clinique.Services.Abstracts;
using Clinique.Services.AbstractsMock;
using Clinique.Services.Implementations;
using Clinique.Services.ImplementationsMocks;
using CLinique.Models.Models;
using FluentAssertions;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliCliniqueTestUnitaireWithMock.ImplementationsMocks
{
    public class PatientServiceTestUnitMock
    {
        private IPatientServiceMock _patientServiceMock;
        private Mock<IPatientRepository> _patientRepositoryMock;

        public PatientServiceTestUnitMock()
        {
            _patientRepositoryMock = new Mock<IPatientRepository>();
            _patientServiceMock = new PatientServiceMock(_patientRepositoryMock!.Object);
        }

        [Fact]
        public async Task GetAllAllPatient_Shoul_Be_Return_Empty_When_Not_Patient_In_Db()
        {
            _patientRepositoryMock.Setup(p => p.GetAllAsync()).ReturnsAsync(new List<Patient>());

            var result =  await _patientServiceMock.GetAllPatients();
            result.Should().BeEmpty();


        }

    }
}
