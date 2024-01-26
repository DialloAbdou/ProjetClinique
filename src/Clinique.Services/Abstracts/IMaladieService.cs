using CLinique.Models.Models;

namespace Clinique.Services.Abstracts
{
    public interface IMaladieService
    {
        IEnumerable<Maladie> GetAllMaladie();
        void AddMaladie(Maladie maladie);
        bool IsNotExistedMaladie(Maladie maladie);
    }
}
