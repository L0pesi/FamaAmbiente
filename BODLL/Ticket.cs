/* +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
 * 
 *  <copyright file="Ticket.cs">
 *      Copyright (c) 2021 All Rights Reserved
 *  </copyright>
 *  <author>Lopesi</author>
 *  <date>5/26/2021 11:53:14 PM</date>
 *  <description>Um ticket é o conjunto das informações necessárias
 *  acerca de uma dada ocorrência. Necessários para que atenda ao 
 *  solicitado pelo cliente</description>
 *  
 * +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
 **/

using System;

namespace BODLL
{
    /// <summary>
    /// Purpose: Define o ticket, seus atributos e metodos.
    /// Created by: Lopesi
    /// Created on: 5/26/2021 11:53:14 PM
    /// </summary>
    /// <remarks></remarks>

    [Serializable]

    public class Ticket
    {


        #region ------- ATTRIBUTES -------

        private int ticketId;
        private Issue issue;   //Ocurrencia
        private bool solved;    //resolvido?
        private Technician tech;     //id funcionario assignado
        private Client client;
        private Infrastructure infrastructure;


        #endregion


        #region ------- METHODS -------


        #region ------- CONSTRUCTORS -------

        public Ticket()
        {

        }

        public Ticket(Issue issue, Technician tech, Client client, Infrastructure inf)
        {
            Issue = issue;
            Solved = false;     // ao criar "ticket" esta sempre por resolver
            Tech = tech;        // assigna id do func
            Client = client;    //atribui a um clt
            Infrastructure = inf;
        }

        #endregion


        #region ------- PROPERTIES -------

        public int TicketId
        {
            get { return ticketId; }
            set { ticketId = value; }
        }

        public Issue Issue
        {
            get { return issue; }
            set { issue = value; }
        }
        public bool Solved
        {
            get { return solved; }
            set { solved = value; }
        }

        public Technician Tech
        {
            get { return tech; }
            set { tech = value; }
        }

        public Client Client
        {
            get { return client; }
            set { client = value; }
        }

        public Infrastructure Infrastructure
        {
            get { return infrastructure; }
            set { infrastructure = value; }
        }


        #endregion


        #region ------- FUNCTIONS -------



        #endregion


        #endregion


    }
}

