/*==========================================================================
Source File:   AnswerNotification.cs                                             
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
namespace Products.Api.Common.CrossCutting.Notifications
{
    using System.Net;

    public class AnswerNotification<T>
    {
        /// <summary>
        /// Status Code
        /// </summary>
        public HttpStatusCode StatusCode { get; private set; }
        /// <summary>
        /// Message
        /// </summary>
        public string Message { get; private set; }
        /// <summary>
        /// Response
        /// </summary>
        public T Response { get; private set; }

        /// <summary>
        /// Get Answer
        /// </summary>
        /// <param name="httpStatusCode"></param>
        /// <param name="strMessage"></param>
        /// <param name="response"></param>
        /// <returns></returns>
        public static AnswerNotification<T> GetAnswer(HttpStatusCode httpStatusCode, string strMessage, T response)
        {
            return new AnswerNotification<T> { StatusCode = httpStatusCode, StrMessage = strMessage, Response = response };
        }
    }
}
