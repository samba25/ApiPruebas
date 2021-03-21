using ApiPruebas.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiPruebas.Domain.Contracts.Repositories
{
	public interface ICountryRepository : ICrudRepository<Country>
	{
	}
}
