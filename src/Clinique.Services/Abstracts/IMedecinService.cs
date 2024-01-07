using CLinique.Models.Models;

namespace Clinique.Services.Abstracts
{
    public interface IMedecinService
    {
        Task<Medecin> AddMedecinAsync(Medecin medecin);
    }
}
