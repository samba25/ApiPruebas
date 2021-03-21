using ApiPruebas.Domain.Models.Common;
using ApiPruebas.Domain.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApiPruebas.Domain.Contracts.Repositories
{
	public interface ICrudRepository<TModel>
		where TModel : class, IModel
	{
		/// <summary>
		/// Obtiene un registro de la base de datos, o default en caso de no encontrarlo.
		/// </summary>
		/// <param name="id">El identificador del Registro</param>
		/// <returns>El registro o su valor por defecto</returns>
		public Task<TModel> Read(string id);
		/// <summary>
		/// Actualiza un registro en la base de datos, o, si este no existe, lo crea.
		/// </summary>
		/// <param name="value">El registro a insertar/actualizar</param>
		/// <returns>Un estado donde se especifica si el registro se actualizo o inserto y el identificador del mismo.</returns>
		public Task<CrudOperationResult> Upsert(TModel value);
		/// <summary>
		/// Elimina un registro de la base de datos.
		/// </summary>
		/// <param name="id">El identificador del registro a eliminar.</param>
		/// <returns>El resultado de la operación, donde se especifica si existía el registro y si la operación finalizó exitosamente.</returns>
		public Task<CrudOperationResult> Delete(string id);
	}
}
