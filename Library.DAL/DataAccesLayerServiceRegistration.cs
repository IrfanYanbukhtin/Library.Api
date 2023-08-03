using Library.DAL.Repository.Author;
using Library.DAL.Repository.Book;
using Microsoft.Extensions.DependencyInjection;

namespace Library.DAL
{
	public static class DataAccessLayerServiceRegistration
	{
		public static IServiceCollection AddDalServices(this IServiceCollection services)
		{
			services.AddScoped<IAuthorRepository, AuthorRepository>();

			services.AddScoped<IBookRepository, BookRepository>();

			return services;
		}
	}
}
