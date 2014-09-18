using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cirrious.MvvmCross.Community.Plugins.Sqlite;
using PrePopulatedDatabase.Core.Entities;

namespace PrePopulatedDatabase.Core.Services
{
    public class BowTieService : IBowTieService
    {
           private readonly ISQLiteConnection _connection;
 
    

        public BowTieService(ISQLiteConnectionFactory factory)
        {
            
            _connection = factory.Create("BowTieDB.sqlite");
            _connection.CreateTable<BowTie>();
           
        }

        public int Create(BowTie bowTie)
        {
            _connection.Insert(bowTie);
            return bowTie.ID;
        }


        public void Edit(BowTie bowTie)
        {
            _connection.Update(bowTie);

        }

        public void Delete(BowTie bowTie)
        {
            _connection.Delete(bowTie);
          
        }

        public BowTie Get(int id)
        {
            return _connection.Table<BowTie>().FirstOrDefault(x => x.ID == id);
        }

        public List<BowTie> GetAll()
        {
            return _connection.Table<BowTie>().ToList();
        }
    }

}
