/* +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
 * 
 *  <copyright file="Infrastructure.cs">
 *      Copyright (c) 2021 All Rights Reserved
 *  </copyright>
 *  <author>Lopesi</author>
 *  <date>5/26/2021 11:52:04 PM</date>
 *  <description>As infraestrutura são o alvo da intervenção nas 
 *  ocorrências. Tratando-se de redes, podem ser 3 tipos: Água, 
 *  Saneamento ou Pluviais</description>
 *  
 * +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
 **/

using System;

namespace BODLL
{
    /// <summary>
    /// Purpose: Define a infraestrutura, seus atributos e metodos.
    /// Created by: Lopesi
    /// Created on: 5/26/2021 11:52:04 PM
    /// </summary>
    /// <remarks></remarks>

    [Serializable]

    public class Infrastructure
    {


        #region ------- ATTRIBUTES -------
        private int id;
        private string type;    //Tipo de infraestrutura


        #endregion


        #region ------- METHODS -------


        #region ------- CONSTRUCTORS -------

        public Infrastructure()
        {

        }
        public Infrastructure(string type)   //construtor 2 - o tipo de infraestrutura
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
