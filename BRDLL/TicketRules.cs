/* +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
 * 
 *  <copyright file="TicketRules.cs">
 *      Copyright (c) 2021 All Rights Reserved
 *  </copyright>
 *  <author>Lopesi</author>
 *  <date>5/27/2021 3:02:35 PM</date>
 *  <description>A gestão dos tickets</description>
 *  
 * +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
 **/

using System;
using System.IO;
using DadosDLL;
using BODLL;


namespace BRDLL
{
    /// <summary>
    /// Purpose: Esta classe gere os tickets, todas as suas regras
    /// e validações
    /// Created by: Lopesi
    /// Created on: 5/27/2021 3:02:35 PM
    /// </summary>
    /// <remarks></remarks>

    public class TicketRules
    {


        #region ------- ATTRIBUTES -------


        #endregion


        #region ------ METHODS ------


        #region ------ CONSTRUCTORS -------


        public TicketRules()
        {

        }

        #endregion


        #region ------ PROPERTIES ------


        #endregion


        #region ------ FUNCTIONS ------


        /// <summary>
        /// Este metodo requisita a informação necessária sobre
        /// os tickets para imprimir no ecrâ
        /// </summary>
        /// <param name="ticketNum">Número de tickets guardados</param>
        /// <param name="solvedTotal">total de resolvidos</param>
        /// <returns>true se tiver dados, false se não tiver</returns>
        public static bool ListaTicketsRequest(out int ticketTotal, out int solvedTotal)
        {
            return Tickets.ListaTickets(out ticketTotal, out solvedTotal);
        }

       

        #endregion


        #endregion


    }
}
