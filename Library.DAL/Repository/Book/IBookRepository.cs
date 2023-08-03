using Library.DAL.Repository.Contarcts;

namespace Library.DAL.Repository.Book
{
	public interface IBookRepository : IRepositoryAsync<Entities.Book>
	{
		Task<ICollection<Entities.Book>> Test();
	}
}
