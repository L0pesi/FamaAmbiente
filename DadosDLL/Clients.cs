/* +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
 * 
 *  <copyright file="Clients.cs">
 *      Copyright (c) 2021 All Rights Reserved
 *  </copyright>
 *  <author>Lopesi</author>
 *  <date>5/26/2021 11:46:29 PM</date>
 *  <description>Gerir o conjunto dos cliente</description>
 *  
 * +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
 **/

using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using BODLL;


namespace DadosDLL
{
    /// <summary>
    /// Purpose: Esta classe gere o conjunto dos clientes e as 
    /// suas funções
    /// Created by: Lopesi
    /// Created on: 5/26/2021 11:46:29 PM
    /// </summary>
    /// <remarks></remarks>

    [Serializable]

    public class Clients
    {


        #region ------- ATTRIBUTES -------

        private static List<Client> allClients = new List<Client>();

        #endregion


        #region ------- METHODS -------


        #region ------- CONSTRUCTORS -------

        public Clients()
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
        public static bool LoadOnBoot()   //Carrega 3 clientes (exemplos)
        {
            allClients.Add(new Client("Sérgio", "Lopes", "180001001", "PT", new Contact("963213213", "slopes@ipca.pt", "Rua de esmeriz, 1", "4760-007")));
            allClients.Add(new Client("Luis", "Ferreira", "190019001", "PT", new Contact("911231231", "lufer@ipca.pt", "Rua do ipca, 18", "4760-666")));
            allClients.Add(new Client("Nelo", "Chapeiro", "180001001", "PT", new Contact("252001001", "", "Rua dos famaboys, 34", "4760-958")));



            return allClients != null ? true : false;
        }


        /// <summary>
        /// Função para imprimir no ecrã todos os clientes
        /// </summary>
        /// <param name="id">o parametro id em cliente</param>
        /// <returns>true se for bem sucedido. false se a lista estiver vazia</returns>
        public static bool List(out int id)
        {
            id = 0;
            if (allClients != null) //a condição caso a lista de clientes esteja vazia
            {
                foreach (Client c in allClients) //aqui vai imprimir a lista dos clientes com um ciclo foreach
                {
                    Console.WriteLine("Id: " + id + "\n" +
                                      "Nome: " + c.FirstName + " " + c.LastName + "\n" +
                                      "Morada: " + c.ContactData.AddressDesc + " " + c.ContactData.AddressZipCode + " VNF\n"
                                      );
                    Console.WriteLine("=====================================\n");
                    id++;
                }
                return true;
            }
            return false;
        }


        /// <summary>
        /// Função que recolhe um determinado cliente através do id
        /// </summary>
        /// <param name="id">o id que a função recebe</param>
        /// <param name="clt">o objeto cliente que é devolvido</param>
        /// <returns>true se encontrar, false senão. Leva o cliente em out</returns>
        public static bool Get(int id, out Client clt)
        {
            if (allClients != null)
            {
                clt = allClients[id];
                return true;
            }

            clt = null;
            return false;
        }


        /// <summary>
        /// Neste metodo, adicionamos um cliente á lista, verificando primeiro se ele já existe.
        /// </summary>
        public static bool AddClient(Client c, out string x)
        {
            if (allClients != null)
            {
                if (allClients.Contains(c))
                {
                    x = "Bola!!";
                    return false;
                }
            }
            allClients.Add(c);                                              //Adiciona Cliente á lista
            x = c.Nif;                                                 //devolve o nif através do out

            string fPath = AppDomain.CurrentDomain.BaseDirectory;

            if (fPath.Contains("Debug"))
            {
                fPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory.ToString(), @"../"));
            }

            SaveAll(fPath + @"\db\ClientsDB.bin");
            return true;
        }


        /// <summary>
        /// Metodo que gere o procedimento de armazenamento dos dados em ficheiro
        /// </summary>
        /// <param name="fileName">Caminho e nome do ficheiro</param>
        /// <returns>true se o procedimento de salvar foi ok. False em caso contrario</returns>
        public static bool SaveAll(string fileName)
        {
            try
            {
                FileStream fs = new FileStream(fileName, FileMode.Create);
                BinaryFormatter binForm = new BinaryFormatter();
                binForm.Serialize(fs, allClients);
                fs.Flush();
                fs.Close();
                fs.Dispose();
                return true;
            }
            catch (IOException io)
            {
                throw new Exception("Erro de gravação no ficheiro dos Clientes : " + io.Message);
            }
            catch (Exception e)
            {
                throw new Exception("Erro de gravação não previsto no ficheiro dos Clientes : ", e);
            }
        }


        /// <summary>
        /// Metodo que gere o procedimento de carregamento dos dados em ficheiro
        /// </summary>
        /// <param name="fileName">Caminho e nome do ficheiro</param>
        /// <returns>true se o procedimento de carregar foi ok. False em caso contrario</returns>
        public static bool LoadAll(string fileName)
        {
            try
            {
                Stream s = File.Open(fileName, FileMode.Open, FileAccess.Read);
                BinaryFormatter binForm = new BinaryFormatter();
                allClients = (List<Client>)binForm.Deserialize(s);
                s.Close();
                return true;
            }
            catch (IOException io)
            {
                throw new Exception("Erro de carregamento no ficheiro dos Clientes : " + io.Message);
            }
            catch (Exception e)
            {
                throw new Exception("Erro de carregamento não previsto no ficheiro dos Clientes : ", e);
            }
        }


        #endregion


        #endregion


    }
}
