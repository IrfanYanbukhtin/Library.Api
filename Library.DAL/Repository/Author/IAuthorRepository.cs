using Library.DAL.Repository.Contarcts;

namespace Library.DAL.Repository.Author
{
	public interface IAuthorRepository : IRepositoryAsync<Entities.Author>
	{
		Task<ICollection<Entities.Author>> Test();
	}
}
