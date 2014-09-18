using System.Collections.Generic;
using PrePopulatedDatabase.Core.Entities;

namespace PrePopulatedDatabase.Core.Services
{
    public interface IBowTieService
    {
        int Create(BowTie bowTie);
        void Edit(BowTie bowTie);
        void Delete(BowTie bowTie);
        BowTie Get(int id);
        List<BowTie> GetAll();
    }
}