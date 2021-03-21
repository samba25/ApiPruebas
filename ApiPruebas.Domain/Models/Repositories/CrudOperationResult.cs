using System;
using System.Collections.Generic;
using System.Text;

namespace ApiPruebas.Domain.Models.Repositories
{
	public class CrudOperationResult
	{
		/// <summary>
		/// La operacion no arrojo Excepcion
		/// </summary>
		public bool Success { get; set; } = false;
		/// <summary>
		/// El Registro existía en la base de datos
		/// </summary>
		public bool Exists { get; set; } = false;
		/// <summary>
		/// El Registro se insertó en la base de datos. Revisar el Id si se requiere mas info
		/// </summary>
		public bool Inserted { get; set; } = false;
		/// <summary>
		/// El registro se actualizó en la base de datos.
		/// </summary>
		public bool Updated { get; set; } = false;
		/// <summary>
		/// El Id del registro operado
		/// </summary>
		public string Id { get; set; } = "";
	}
}
