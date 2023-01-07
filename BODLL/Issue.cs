/* +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
 * 
 *  <copyright file="BODLL.cs">
 *      Copyright (c) 2021 All Rights Reserved
 *  </copyright>
 *  <author>Lopesi</author>
 *  <date>5/26/2021 11:52:28 PM</date>
 *  <description>As ocorrências são o objecto dos tickets. A ela são 
 *  designados técnicos para nelas intervir a pedido de um cliente. 
 *  Uma ocorrência pode ser do tipo Avaria ou Manutenção.</description>
 *  
 * +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
 **/

using System;

namespace BODLL
{
    /// <summary>
    /// Purpose: Define a ocorrência, seus atributos e metodos.
    /// Created by: Lopesi
    /// Created on: 5/26/2021 11:52:28 PM
    /// </summary>
    /// <remarks></remarks>

    [Serializable]

    public class Issue
    {


        #region ------- ATTRIBUTES -------

        private int id;
        private string type;

        #endregion


        #region ------- METHODS -------

        #region ------- CONSTRUCTORS -------

        public Issue()
        {

        }


        public Issue(string type)   //construtor 2 - o tipo de ocorrência
        {
            Type = type;
        }


        #endregion


        #region ------- PROPERTIES -------

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }


        #endregion


        #region ------- FUNCTIONS -------



        #endregion


        #endregion


    }
}
