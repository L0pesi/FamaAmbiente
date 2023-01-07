/* +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
 * 
 *  <copyright file="Client.cs">
 *      Copyright (c) 2021 All Rights Reserved
 *  </copyright>
 *  <author>Lopesi</author>
 *  <date>5/26/2021 11:51:09 PM</date>
 *  
 *  <description>O cliente é o reclamante das ocorrências. Quando o cliente 
 *  gera uma reclamação, dá-se inicio ao procedimento de elaboração de um 
 *  ticket com a descrição para um técnico a resolver.</description>
 *  
 * +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
 **/

using System;

namespace BODLL
{
    /// <summary>
    /// Purpose: Esta classe define o cliente, seus atributos e metodos. 
    /// Created by: Lopesi
    /// Created on: 5/26/2021 11:51:09 PM
    /// </summary>
    /// <remarks></remarks>

    [Serializable]

    public class Client : Person
    {

        /// <summary>
        /// A classe client herda da classe person
        /// </summary>


        #region ------- ATTRIBUTES -------

        //não tem atributos extra aos que herda de Person

        #endregion


        #region ------- METHODS -------


        #region ------- CONSTRUCTORS -------

        public Client(Person c)
        {

        }

        public Client(string fName, string lName, string nif, string lang, Contact c)
        {
            this.FirstName = fName;
            this.LastName = lName;
            this.Nif = nif;
            this.Language = lang;
            this.ContactData = c;
        }

        #endregion


        #region ------- PROPERTIES -------



        #endregion


        #region ------- FUNCTIONS -------



        #endregion


        #endregion



    }
}
