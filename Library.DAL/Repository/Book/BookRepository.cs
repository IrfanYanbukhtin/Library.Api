using Library.DAL.DataContext;

namespace Library.DAL.Repository.Book
{
	public class BookRepository : EfCoreRepositoryAsync<Entities.Book>, IBookRepository
	{
		public BookRepository(AppDbContext dbContext) : base(dbContext)
		{

		}

		public async Task<ICollection<Entities.Book>> Test()
		{
			var result = (await base.GetAllAsync()).Where(x => x.Description == "Roman").ToList();

			return result;
		}
	}
}
