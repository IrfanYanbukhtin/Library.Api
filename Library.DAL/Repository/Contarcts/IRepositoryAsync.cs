using Library.DAL.Entities;

namespace Library.DAL.Repository.Contarcts
{
	public interface IRepositoryAsync<T> where T : Entity
	{
		Task<ICollection<T>> GetAllAsync();
		Task<T> GetAsync(int? id);
		Task AddAsync(T entity);
		Task UpdateAsync(int id, T entity);
		Task DeleteAsync(int id);
	}
}
