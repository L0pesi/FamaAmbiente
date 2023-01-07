/* +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
 * 
 *  <copyright file="Tickets.cs">
 *      Copyright (c) 2021 All Rights Reserved
 *  </copyright>
 *  <author>Lopesi</author>
 *  <date>5/27/2021 4:59:29 PM</date>
 *  <description>Gerir o conjunto dos Tickets</description>
 *  
 * +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
 **/

using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using BODLL;

namespace DadosDLL
{
    /// <summary>
    /// Purpose: Esta classe gere o conjunto dos Tickets e as 
    /// suas funções
    /// Created by: Lopesi
    /// Created on: 5/27/2021 4:59:29 PM
    /// </summary>
    /// <remarks></remarks>

    [Serializable]

    public class Tickets
    {


        #region ------ ATTRIBUTES ------

        private static List<Ticket> allTickets;                                 //cria apenas uma lista de tickets

        #endregion


        #region ------ METHODS ------


        #region ------ CONSTRUCTORS ------

        /// <summary>
        /// o default constructor da classe Tickets
        /// </summary>

        static Tickets()
        {
            allTickets = new List<Ticket>();
        }

        #endregion


        #region ------ PROPERTIES ------


        #endregion


        #region ------ FUNCTIONS ------


        /// <summary>
        /// Neste metodo, adicionamos um ticket á lista, verificando primeiro se ele já existe.
        /// </summary>
        public static bool AddTicket(Ticket t, out int x)
        {
            if (allTickets != null)
            {
                if (allTickets.Contains(t))
                {
                    x = -1;
                    return false;
                }
            }
            allTickets.Add(t);                                              //Adiciona ticket á lista
            x = t.TicketId;                                                 //devolve o id através do out

            string fPath = AppDomain.CurrentDomain.BaseDirectory;

            if (fPath.Contains("Debug"))
            {
                fPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory.ToString(), @"../"));
            }

            SaveAll(fPath + @"\db\ticketsDB.bin");
            return true;
        }



        /// <summary>
        /// Este metodo requisita a informação necessária para imprimir no ecrâ
        /// </summary>
        /// <param name="ticketNum">Número de tickets guardados</param>
        /// <param name="solvedTotal">total de resolvidos</param>
        /// <returns>true se tiver dados, false se não tiver</returns>
        public static bool ListaTickets(out int ticketTotal, out int solvedTotal)
        {
            ticketTotal = allTickets.Count;
            solvedTotal = 0;

            if (ticketTotal != 0)
            {
                foreach (Ticket t in allTickets)
                {
                    if (t.Solved)
                    {
                        solvedTotal++;                                 //conta o número de tickets resolvidos

                    }
                }
                return true;
            }
            return false;
        }



        /// <summary>
        /// Metodo que gere o procedimento de armazenamento dos dados em ficheiro
        /// </summary>
        /// <param name="fileName">Caminho e nome do ficheiro</param>
        /// <returns>true se o procedimento de salvar foi ok. False em caso contrario</returns>
        public static bool SaveAll(string fileName)
        {
            try
            {
                FileStream fs = new FileStream(fileName, FileMode.Create);
                BinaryFormatter binForm = new BinaryFormatter();
                binForm.Serialize(fs, allTickets);
                fs.Flush();
                fs.Close();
                fs.Dispose();
                return true;
            }
            catch (IOException io)
            {
                throw new Exception("Erro de gravação no ficheiro dos Tickets : " + io.Message);
            }
            catch (Exception e)
            {
                throw new Exception("Erro de gravação não previsto no ficheiro dos Tickets : ", e);
            }
        }


        /// <summary>
        /// Metodo que gere o procedimento de carregamento dos dados em ficheiro
        /// </summary>
        /// <param name="fileName">Caminho e nome do ficheiro</param>
        /// <returns>true se o procedimento de carregar foi ok. False em caso contrario</returns>
        public static bool LoadAll(string fileName)
        {
            try
            {
                Stream s = File.Open(fileName, FileMode.Open, FileAccess.Read);
                BinaryFormatter binForm = new BinaryFormatter();
                allTickets = (List<Ticket>)binForm.Deserialize(s);
                s.Close();
                return true;
            }
            catch (IOException io)
            {
                throw new Exception("Erro de carregamento no ficheiro dos Tickets : " + io.Message);
            }
            catch (Exception e)
            {
                throw new Exception("Erro de carregamento não previsto no ficheiro dos Tickets : ", e);
            }
        }


        #endregion


        #endregion


    }
}
