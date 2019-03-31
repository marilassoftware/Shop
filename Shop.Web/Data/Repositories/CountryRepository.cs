namespace Shop.Web.Data
{
    using System.Threading.Tasks;
    using Shop.Web.Data.Entities;
    public class CountryRepository : GenericRepository<Country>, ICountryRepository
    {
        public CountryRepository(DataContext context) : base(context)
        {

        }

        
    }
}
