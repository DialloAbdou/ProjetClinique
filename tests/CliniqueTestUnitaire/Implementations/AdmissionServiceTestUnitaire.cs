using Clinique.Services.Abstracts;
using Clinique.Services.Implementations;
using CLinique.Models.Models;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CliniqueTestUnitaire.Implementations
{
    public class AdmissionServiceTestUnitaire
    {

        private IAdmissionService _admissionService;

        private Patient patient = new Patient()
        {
            Id = 1,
            Nom = "NomPatient",
            Prenom = "PrePatient",
            Adresse = "AdressePatient",
            Age = 52
        };
        public AdmissionServiceTestUnitaire()
        {
            _admissionService = new AdmissionService();

        }
        [Fact]
        public void GetAllAdmission_Should_Be_Empty_At_Beginin()
        {
            var result = _admissionService.GetAllAdmission();
            result.Should().BeEmpty();
        }

        [Fact]
        public void IsPossibleAdmission_Should_Be_Return_True_when_Admission_Amount_lessEqualto_Ten()
        {
            _admissionService.isAddmissionPossible().Should().BeTrue();
        }


        [Fact]
        public void GetAllAdmission_Should_Be_Return_Collection_Not_Empty()
        {

            // Arrange
            _admissionService.AjoutAdmission(patient, "NomPathologie");
            // Act 
            var results = _admissionService.GetAllAdmission();
            var admision = results.First();
            //Assertion
            admision.Patient.Nom.Should().Be(patient.Nom);
            admision.Patient.Prenom.Should().Be(patient.Prenom);
            admision.Patient.Adresse.Should().Be(patient.Adresse);

        }

    }
}
