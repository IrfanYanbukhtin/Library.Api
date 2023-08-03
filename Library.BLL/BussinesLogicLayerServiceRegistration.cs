using Library.BLL.Services.Contracts;
using Library.BLL.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.BLL
{
	public static class BussinessLogicLayerServiceRegistration
	{
		public static IServiceCollection AddBllServices(this IServiceCollection services)
		{
			services.AddScoped<IAuthorService, AuthorManager>();

			services.AddScoped<IBookService, BookManager>();

			return services;
		}
	}
}
