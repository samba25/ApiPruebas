using ApiPruebas.Core.Services;
using ApiPruebas.Domain.Contracts.Services;
using Autofac;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiPruebas.Core.Application
{
	public class DependencyInjection
	{
		public ContainerBuilder Builder { get; }

		public DependencyInjection(ContainerBuilder builder)
		{
			Builder = builder;
		}

		public void InjectServices()
		{
			Builder.RegisterType<GeographyService>().As<IGeographyService>();
		}
	}
}
