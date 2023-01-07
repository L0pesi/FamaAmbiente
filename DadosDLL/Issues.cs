/* +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
 * 
 *  <copyright file="Issues.cs">
 *      Copyright (c) 2021 All Rights Reserved
 *  </copyright>
 *  <author>Lopesi</author>
 *  <date>5/26/2021 11:48:06 PM</date>
 *  <description>Gerir o conjunto das ocorrências</description>
 *  
 * +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
 **/

using System;
using System.Collections.Generic;
using BODLL;

namespace DadosDLL
{
    /// <summary>
    /// Purpose: Esta classe gere o conjunto das ocorrências e as 
    /// suas funções
    /// Created by: Lopesi
    /// Created on: 5/26/2021 11:48:06 PM
    /// </summary>
    /// <remarks></remarks>

    [Serializable]

    public class Issues
    {


        #region ------- ATTRIBUTES -------

        private static List<Issue> listOfIssues = new List<Issue>();

        #endregion


        #region ------- METHODS -------


        #region ------- CONSTRUCTORS -------

        public Issues()
        {

        }

        #endregion


        #region ------- PROPERTIES -------



        #endregion


        #region ------- FUNCTIONS -------

        /// <summary>
        /// Função para carregar exemplos pré-definidos
        /// </summary>
        /// <returns>true se for bem sucedido.False se estiver vazia</returns>
        public static bool LoadOnBoot()   //Carrega os 2 tipos de ocurrências
        {
            listOfIssues.Add(new Issue("Avaria"));
            listOfIssues.Add(new Issue("Manutenção"));

            return listOfIssues != null ? true : false;
        }


        /// <summary>
        /// Função para imprimir no ecrã todas as ocorrências
        /// </summary>
        /// <param name="id">o parametro id em ocorrencias</param>
        /// <returns>true se for bem sucedido. false se a lista estiver vazia</returns>
        public static bool List(out int id)
        {
            id = 0;
            if (listOfIssues != null)  //condição caso a lista esteja vazia
            {
                foreach (Issue i in listOfIssues) //ciclo foreach para imprimir a lista existente
                {
                    Console.WriteLine("Id: " + id + " - " + i.Type + "\n");
                    id++;
                }
                return true;
            }
            return false;
        }


        /// <summary>
        /// Função que recolhe uma determinada ocorrência através do id
        /// </summary>
        /// <param name="id">o id que a função recebe</param>
        /// <param name="issue">o objeto ocorrencia que é devolvido</param>
        /// <returns>true se encontrar, false senão. Leva a ocorrência em out</returns>
        public static bool Get(int id, out Issue issue)
        {
            if (listOfIssues != null)
            {
                issue = listOfIssues[id];
                return true;
            }

            issue = null;
            return false;
        }


        #endregion


        #endregion


    }
}
