/* ************************************************************************************
 * 
 *  <copyright file="MenuOperations.cs">
 *      Copyright (c) 2021 All Rights Reserved
 *  </copyright>
 *  <author>Lopesi</author>
 *  <date>5/27/2021 1:11:23 PM</date>
 *  <description>A classe que gere todas as operações previstas no menu</description>
 *  
 * ************************************************************************************
 **/

using System;
using BRDLL;


namespace FamaAmbiente
{
    /// <summary>
    /// Purpose: Esta class de operação do menu é para testar a alternativa do frontend
    /// Created by: Lopesi
    /// Created on: 5/27/2021 1:11:23 PM
    /// </summary>
    /// <remarks></remarks>

    public class MenuOperation
    {


        #region ------ ATTRIBUTES -------


        #endregion


        #region ------ METHODS ------


        #region ------ CONSTRUCTORS ------

        public MenuOperation()
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

        public static bool OperationListaTickets(out int ticketTotal, out int solvedTotal)
        {
            if (TicketRules.ListaTicketsRequest(out ticketTotal, out solvedTotal))
            {
                Console.WriteLine("Relatorio de total de tickets \n Impresso a " + DateTime.Today.ToShortDateString());

                Console.WriteLine("Número de tickets guardados:  " + ticketTotal.ToString());

                Console.WriteLine("Total de tickets resolvidos:  " + solvedTotal.ToString());

                Console.WriteLine("Total de tickets por resolver:  " + (solvedTotal - ticketTotal).ToString());

                Console.ReadKey();
                return true;
            }
            else
            {
                Console.WriteLine("Não há Tickets ainda!!");
                Console.ReadKey();
                return false;
            }

        }


        #endregion


        #endregion



    }
}
