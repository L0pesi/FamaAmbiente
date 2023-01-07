/* +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
 * 
 *  <copyright file="Person.cs">
 *      Copyright (c) 2021 All Rights Reserved
 *  </copyright>
 *  <author>Lopesi</author>
 *  <date>5/26/2021 11:52:46 PM</date>
 *  <description>Com esta classe, definimos o objecto pessoa, seus 
 *  atributos e metodos</description>
 *  
 * +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
 **/

using System;

namespace BODLL
{
    /// <summary>
    /// Purpose: A class Person é uma classe "Pai", define a 
    /// pessoa e seus atributos e metodos poderão ser usados por 
    /// outras classes
    /// Created by: Lopesi
    /// Created on: 5/26/2021 11:52:46 PM
    /// </summary>
    /// <remarks></remarks>

    [Serializable]

    public class Person
    {


        #region ------- ATRIBUTES -------

        private string language;
        private string firstName;
        private string lastName;
        private string nif;
        private Contact contactData = new Contact();

        #endregion


        #region ------- METHODS -------


        #region ------- CONSTRUCTORS -------

        public Person()
        {

        }

        public Person(string fName, string lName, string nif, string lang, Contact c)
        {
            FirstName = fName;
            LastName = lName;
            Nif = nif;
            Language = lang;
            ContactData = c;
        }

        #endregion


        #region ------- PROPERTIES -------

        public string Language
        {
            get
            {
                return language;
            }
            set
            {
                language = value;
            }
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }


        public string Nif
        {
            get
            {
                return nif;
            }
            set
            {
                bool b = (value.Length == 9) ? true : false;   //Verificação quanto ao número de digitos
                if (b)
                {
                    long aux;

                    bool c = long.TryParse(value, out aux);

                    nif = c ? aux.ToString() : "";
                    return;
                }
                nif = "";
            }
        }



        public Contact ContactData
        {
            get => contactData; set => contactData = value;
        }

        #endregion


        #region ------- FUNCTIONS -------



        #endregion


        #endregion


    }
}
