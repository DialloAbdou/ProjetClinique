using CLinique.Models.Models;

namespace Clinique.Services.Abstracts
{
    public interface IMedecinService
    {
        void AddMedecin(Medecin medecin);
        IEnumerable<Medecin> GetAllMedecin();
        void Affecter(Medecin medecin, Patient patient);
        bool isExistMedecin(Medecin medecin);
    }
}
