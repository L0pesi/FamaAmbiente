/* +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
 * 
 *  <copyright file="Contact.cs">
 *      Copyright (c) 2021 All Rights Reserved
 *  </copyright>
 *  <author>Lopesi</author>
 *  <date>5/26/2021 11:51:26 PM</date>
 *  
 *  <description>Esta class Contact serve para conseguir devidamente estruturar 
 *  o mesmo para que todas as suas propriedades fossem especificadas.</description>
 *  
 * ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
 **/

using System;
using System.Text.RegularExpressions;

namespace BODLL
{
    /// <summary>
    /// Purpose: Caracteriza e estrutura as informações de contacto (contact)
    /// Created by: Lopesi
    /// Created on: 5/26/2021 11:51:26 PM
    /// </summary>
    /// <remarks></remarks>

    [Serializable]

    public class Contact
    {


        #region ------- ATTRIBUTES -------

        private string phoneNumber;
        private string email;
        private string addressCity;
        private string addressDesc;
        private string addressZipCode;


        #endregion


        #region ------- METHODS -------


        #region ------- CONSTRUCTORS -------

        public Contact()
        {

        }

        public Contact(string nr, string email, string addDesc, string addZipCode)
        {
            PhoneNumber = nr;
            Email = email;
            AddressDesc = addDesc;
            AddressZipCode = addZipCode;


        }

        #endregion


        #region ------- PROPERTIES -------


        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }
            set
            {
                bool b = (value.Length == 9) ? true : false; //verificação quanto ao número de digitos do número de telefone
                if (b)
                {
                    long aux;

                    bool c = long.TryParse(value, out aux);

                    phoneNumber = c ? aux.ToString() : "";
                    return;
                }
                phoneNumber = "";
            }
        }


        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                string pattern = (@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");         //REGEX pattern para email válido

                bool b = Validate(value.ToLower(), pattern);                                //função que vai validar a syntaxe do email

                email = b ? value : "no-email";
            }
        }


        public string AddressCity
        {
            get
            {
                return addressCity;
            }
            set
            {
                addressCity = "Vila Nova de Famalicão";   //Aplicação apenas para Vila Nova de Famalicão, por isso establece por defeito
            }
        }

        public string AddressDesc
        {
            get
            {
                return addressDesc;
            }
            set
            {
                addressDesc = (value.Length <= 50) ? CapitalLetter(value) : ""; //Capital Letter arranjo
            }
        }


        public string AddressZipCode
        {
            get
            {
                return addressZipCode;
            }
            set
            {
                bool b = Validate(value, @"^[1-9]\d{3}(-\d{3})?$");        //função que vai validar a syntax do codigo postal

                addressZipCode = b ? value : "0000-000";
            }
        }


        #endregion


        #region ------- FUNCTIONS -------

        public static string CapitalLetter(string s)
        {
            ///<summary>
            ///Função da biblioteca System.Globalization
            ///converte a string para lowercase
            ///</summary>

            return System.Globalization.CultureInfo.CurrentUICulture.TextInfo.ToTitleCase(s.ToLower());
        }


        private bool Validate(string n, string pattern)
        {

            ///<summary>
            /// REGEX Função que valida a syntaxe de uma string usando um padrão
            /// que designamos (simulado online). biblioteca System.Text.RegularExpressions
            ///</summary>

            return Regex.IsMatch(n, pattern);
        }


        #endregion


        #endregion


    }
}
