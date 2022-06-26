
using DataBaseLib.TuristDB.Models;
using Microsoft.EntityFrameworkCore;
using ServiceData;

namespace DataTest
{
    [TestClass]
    public class CountryTest
    {
        private readonly TuristDBContext connect;

        public CountryTest()
        {
            var optionsBuilder = new DbContextOptionsBuilder<TuristDBContext>();
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-DVSENK7\\SQLEXPRESS;Initial Catalog=TuristDB;Integrated Security=True");

            connect = new TuristDBContext(optionsBuilder.Options);
          
        }

        [TestMethod]
        public void TestcountriesLists()
        {
            CountryCity country = new CountryCity(connect);

            var test=  country.countriesLists();
            Assert.IsNotNull(test);

         
        }
    }
}