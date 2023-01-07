/* +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
 * 
 *  <copyright file="Technician.cs">
 *      Copyright (c) 2021 All Rights Reserved
 *  </copyright>
 *  <author>Lopesi</author>
 *  <date>5/26/2021 11:52:58 PM</date>
 *  <description>O Técnico é quem se designa para resolver uma 
 *  ocorrência</description>
 *  
 * +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
 **/

using System;

namespace BODLL
{
    /// <summary>
    /// Purpose: Esta classe define o técnico, seus atributos e metodos. 
    /// Created by: Lopesi
    /// Created on: 5/26/2021 11:52:58 PM
    /// </summary>
    /// <remarks></remarks>

    [Serializable]

    public class Technician : Person            //a classe tecnician herda da classe person
    {


        #region ------- ATTRIBUTES -------

        private int id;                        //id é atributo extra aos que herda de person


        #endregion


        #region ------- METHODS -------


        #region ------- CONSTRUCTORS -------

        public Technician()
        {

        }

        public Technician(string fName, string lName, string nif, string lang, Contact c)
        {
            this.FirstName = fName;
            this.LastName = lName;
            this.Nif = nif;
            this.Language = lang;
            this.ContactData = c;
        }

        #endregion


        #region ------- PROPERTIES -------

        public int Id
        {
            get { return id; }
            set { id = value; }
        }



        #endregion


        #region ------- FUNCTIONS -------



        #endregion


        #endregion


    }
}
