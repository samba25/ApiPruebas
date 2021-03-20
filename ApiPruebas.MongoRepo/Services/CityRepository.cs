﻿using ApiPruebas.Domain.Models.Configurations;
using ApiPruebas.MongoRepo.Models;
using ApiPruebas.MongoRepo.Services.Common;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPruebas.MongoRepo.Services
{
	public class CityRepository : BaseRepository<CityRepositoryModel>
	{

		public CityRepository(IOptions<AppConfiguration> config) : base(config)
		{
		}

		public override string DatabaseName => "";
		public override string CollectionName => "";
	}
}
