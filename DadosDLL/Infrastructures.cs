/* +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
 * 
 *  <copyright file="Infrastructures.cs">
 *      Copyright (c) 2021 All Rights Reserved
 *  </copyright>
 *  <author>Lopesi</author>
 *  <date>5/26/2021 11:48:48 PM</date>
 *  <description>Gerir o conjunto das Infraestruturas</description>
 *  
 * +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
 **/

using System;
using System.Collections.Generic;
using BODLL;

namespace DadosDLL
{
    /// <summary>
    /// Purpose: Esta classe gere o conjunto das infraestruturas e as 
    /// suas funções
    /// Created by: Lopesi
    /// Created on: 5/26/2021 11:48:48 PM
    /// </summary>
    /// <remarks></remarks>

    [Serializable]

    public class Infrastructures
    {


        #region ------- ATTRIBUTES -------

        private static List<Infrastructure> listOfInfrastructures = new List<Infrastructure>();

        #endregion


        #region ------- METHODS -------


        #region ------- CONSTRUCTORS -------

        public Infrastructures()
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
        public static bool LoadOnBoot()   //Carrega 3 tipos infraestruturas
        {
            listOfInfrastructures.Add(new Infrastructure("Água"));              // Rede de Abastecimento de água
            listOfInfrastructures.Add(new Infrastructure("Saneamento"));        // Rede de Drenagem de águas residuais
            listOfInfrastructures.Add(new Infrastructure("Pluviais"));          // Rede de Drenagem de águas pluviais

            return listOfInfrastructures != null ? true : false;
        }


        /// <summary>
        /// Função para imprimir no ecrã todas as infraestruturas
        /// </summary>
        /// <param name="id">o parametro id em infraestruturas</param>
        /// <returns>true se for bem sucedido. false se a lista estiver vazia</returns>
        public static bool ShowInfrastructures(out int id)
        {
            id = 0;
            if (listOfInfrastructures != null) //condição caso a lista esteja vazia
            {
                foreach (Infrastructure i in listOfInfrastructures) //ciclo foreach para imprimir a lista
                {
                    Console.WriteLine("Id: " + id + " - " + i.Type + "\n");
                    id++;
                }
                return true;
            }
            return false;
        }


        /// <summary>
        /// Função que recolhe uma determinada infraestrutura através do id
        /// </summary>
        /// <param name="id">o id que a função recebe</param>
        /// <param name="i">o objeto infraestrutura que é devolvido</param>
        /// <returns>true se encontrar, false senão. Leva a infraestrutura em out</returns>
        public static bool Get(int id, out Infrastructure i)
        {
            if (listOfInfrastructures != null)
            {
                i = listOfInfrastructures[id];
                return true;
            }

            i = null;
            return false;
        }


        #endregion


        #endregion


    }
}
