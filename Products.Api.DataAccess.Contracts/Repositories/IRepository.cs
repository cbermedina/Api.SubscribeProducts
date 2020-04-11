/*==========================================================================
Source File:   IRepository.cs                                             
Description:                       
Author(es):    Cesar Augusto Bermúdez Medina                    
Date:          Saturday,April 11, 2020                                                 
Last Modified: Saturday,April 11, 2020                                               
Version:       1                                                       
Copyright (c), 2020 Visionamos                                         
==========================================================================*/

/*===========================================================================
History
Saturday,April 11, 2020 File created.
============================================================================*/
namespace Products.Api.DataAccess.Contracts.Repositories
{
    using Products.Api.Common.CrossCutting.Notifications;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    public interface IRepository<T> where T : class
    {
        /// <summary>
        /// Verifica que exista registro con el id dado
        /// </summary>
        /// <param name="strId"></param>
        /// <returns></returns>
        Task<AnswerNotification<bool>> ExistAsync(string strId);
        /// <summary>
        /// Obtiene una lista con todos los registros de la entidad
        /// </summary>
        /// <returns></returns>
        Task<AnswerNotification<List<T>>> GetAllAsync();
        /// <summary>
        /// Obtiene el registro cuyo id sea igual al dado
        /// </summary>
        /// <param name="strId"></param>
        /// <returns></returns>
        Task<AnswerNotification<T>> GetAsync(string strId);
        /// <summary>
        /// Elimina registro por idCommon
        /// </summary>
        /// <param name="strId"></param>
        /// <returns></returns>
        Task<AnswerNotification<bool>> DeleteAsync(string strId);
        /// <summary>
        /// Actualiza registro por id
        /// </summary>
        /// <param name="strId"></param>
        /// <param name="element"></param>
        /// <returns></returns>
        Task<AnswerNotification<bool>> UpdateAsync(string strId, T element);
        /// <summary>
        /// Inserta entidad en la bd
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        Task<AnswerNotification<T>> InsertAsync(T element);
    }
}
