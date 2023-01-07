/* +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
 * 
 *  <copyright file="Technicians.cs">
 *      Copyright (c) 2021 All Rights Reserved
 *  </copyright>
 *  <author>Lopesi</author>
 *  <date>5/26/2021 11:47:52 PM</date>
 *  <description>Gerir o conjunto dos Técnicos</description>
 *  
 * +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
 **/

using System;
using System.Collections.Generic;
using BODLL;


namespace DadosDLL
{
    /// <summary>
    /// Purpose: Esta classe gere o conjunto dos Técnicos e as 
    /// suas funções
    /// Created by: Lopesi
    /// Created on: 5/26/2021 11:47:52 PM
    /// </summary>
    /// <remarks></remarks>

    [Serializable]

    public class Technicians
    {


        #region ------- ATTRIBUTES -------

        private static List<Technician> allTechnicians = new List<Technician>();

        #endregion


        #region ------- METHODS -------


        #region ------- CONSTRUCTORS -------

        public Technicians()
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
        public static bool LoadOnBoot()   //Carrega 2 técnicos (exemplos)
        {
            allTechnicians.Add(new Technician("Jorge", "Jesus", "201205209", "PT", new Contact("910000999", "jj@benfas.pt", "Rua do stander, 39 1º andar", "4860-066")));
            allTechnicians.Add(new Technician("Ruben", "Amorim", "262269696", "PT", new Contact("927727879", "", "Rua do gamanço, 2", "4690-009")));

            return allTechnicians != null ? true : false;
        }


        /// <summary>
        /// Função para imprimir no ecrã todos os técnicos
        /// </summary>
        /// <param name="id">o parametro id em tecnico</param>
        /// <returns>true se for bem sucedido. false se a lista estiver vazia</returns>
        public static bool List(out int id)
        {
            id = 0;
            if (allTechnicians != null) //a condição caso a lista de technicians esteja vazia
            {
                foreach (Technician t in allTechnicians) //aqui vai imprimir a lista dos clientes com um ciclo foreach
                {
                    Console.WriteLine("Id: " + id + " -> " +
                                      "Nome: " + t.FirstName + " " + t.LastName + "\n");
                    id++;
                }
                return true;
            }
            return false;
        }


        /// <summary>
        /// Função que recolhe um determinado técnico através do id
        /// </summary>
        /// <param name="id">o id que a função recebe</param>
        /// <param name="t">o objeto técnico que é devolvido</param>
        /// <returns>true se encontrar, false senão. Leva o técnico em out</returns>
        public static bool Get(int id, out Technician t)
        {
            if (allTechnicians != null)
            {
                t = allTechnicians[id];
                return true;
            }

            t = null;
            return false;
        }

        #endregion


        #endregion


    }
}
