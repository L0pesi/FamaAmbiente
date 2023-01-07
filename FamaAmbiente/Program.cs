/* «««««««««««««««««««««««««««««««««««««««««««««««««««««««««««««««««««««««««««««««««««««««««««««««««««««««««««««««««
 * 
 * ++++     FamaAmbiente    ++++            Copyright (c) 2021 All Rights Reserved
 * <copyright file="Program.cs">       Developer: Sérgio Lopes @Ipca-Est  </copyright>
 * 
 * <author>Lopesi</author>
 * <email>a8390@alunos.ipca.pt</email>
 * <date>3/27/2021 5:23:44 PM</date>
 * 
 * <version>1.3</version>
 * 
 * <description> Aplicação para gerir os tickets do Sistema de Gestão da Manutenção
 * das redes de Abastecimento de Água, Drenagem de Águas Residuais e Drenagem de 
 * Águas Pluviais de Vila Nova de Famalicão</description>
 * 
 * »»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»»
 **/

using System;
using BODLL;
using DadosDLL;
using BRDLL;


namespace FamaAmbiente
{
    /// <summary>
    /// O Program é o Mainspace da aplicação.
    /// Aqui executa-se e lança-se a interação com o utilizador.
    /// </summary>


    class Program
    {

        /// <summary>
        /// No main (program) apenas ficam os métodos de interação com o utilizador
        /// </summary>


        static void Main(string[] args)
        {

            /****************************************************************************************************************
             * Neste programa, queremos que o utilizador introduza todos os dados necessários para que se construa
             * um ticket contendo os elementos necessários para se identificar devidamente a ocorrencia e designar-se
             * quem a irá reparar.
             * Tentarei 2 abordagem distintas: Uma de simples execução para teste com grande parte das funções e outra 
             * com menus para que o utilizador tenha mais interação.
             * Além da criação do ticket, deverá o programa poder consultar e gravar em ficheiro os tickets.
             ****************************************************************************************************************/



            #region <<<<<< 1ª Abordagem - Simples Execução >>>>>>


            #region ++++ Boot Loader ++++

            /// <summary>
            /// boot loader - (LoadOnBoot função criada em cada classe que contém os dados)
            /// </summary>
            /// <remarks>Este solução de pré carregar os dados existentes em funções criadas não é ideal, porém foi desenvolvido
            /// desta maneira para facilitar a conclusão do trabalho. De futuro optar por carregar de ficheiros.
            /// Esta abordagem obriga ainda a não usar correctamente o modelo NTier.</remarks>

            bool a = Issues.LoadOnBoot();
            bool b = Infrastructures.LoadOnBoot();
            bool c = Clients.LoadOnBoot();
            bool d = Technicians.LoadOnBoot();
            if (!a && !b && !c && !d)  //Para o caso de não carregar com sucesso - verificar
            {
                Console.WriteLine("Algo correu menos bem..\n");
            }

            #endregion


            #region ++++ Test Simple Run Concept ++++

            /// <summary>
            /// Aqui ficam os métodos de interação com o utilizador
            /// </summary>

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n Bemvindo ao Sistema de Gestão FamaAmbiente \n \n");
            Console.ResetColor();

            Console.WriteLine("Selecione um cliente:\n");
            int num;
            if (!Clients.List(out num)) //a função clients.list é executada enquanto sendo uma condição
            {
                Console.WriteLine("Erro ao mostrar clientes\n");
                Console.ReadKey();
                return;

            }
            int clt;
            int.TryParse(Console.ReadLine(), out clt); //vai ler a escolha do utilizador relativamente ao cliente

            Console.WriteLine("\nIndique qual a situação:\n");
            if (!Issues.List(out num))  //a função Issues.List é executada enquanto sendo uma condição
            {
                Console.WriteLine("Erro ao mostrar ocurrencias\n");
                Console.ReadKey();
                return;
            }
            int issue;
            int.TryParse(Console.ReadLine(), out issue);  //vai ler a escolha do utilizador relativamente á ocorrência


            Console.WriteLine("\nIndique qual a infraestrutura:\n");
            if (!Infrastructures.ShowInfrastructures(out num)) //a função Infrastructures.ShowInfrastructures é executada enquanto sendo uma condição
            {
                Console.WriteLine("Erro ao mostrar infraestruturas\n");
                Console.ReadKey();
                return;
            }
            int infrastr;
            int.TryParse(Console.ReadLine(), out infrastr); //vai ler a escolha do utilizador relativamente á infraestrutura


            Console.WriteLine("\nIndique qual a técnico a designar:\n");
            if (!Technicians.List(out num))  //a função Technicians.List é executada enquanto sendo uma condição
            {
                Console.WriteLine("Erro ao mostrar técnicos\n");
                Console.ReadKey();
                return;
            }
            int tech;
            int.TryParse(Console.ReadLine(), out tech); //vai ler a escolha do utilizador relativamente ao técnico a designar


            Issue i1;
            Client c1;
            Technician tech1;
            Infrastructure inf1;

            //recolhe os objetos que compõem um ticket
            a = Issues.Get(issue, out i1);
            b = Technicians.Get(tech, out tech1);
            c = Clients.Get(clt, out c1);
            d = Infrastructures.Get(infrastr, out inf1);

            if (!a && !b && !c && !d)   //para o caso de algum falhar - verificação
            {
                Console.WriteLine("Ups... algo aconteceu\n");
                Console.ReadKey();
                return;
            }

            Ticket t1 = new Ticket(i1, tech1, c1, inf1); //criação e armazenamento do ticket

            
            Console.WriteLine("\n\nTicket criado");

            Console.ReadKey();


            #endregion


            #endregion



            #region <<<<<< 2ª Abordagem - Menu de execução >>>>>>

            //Infelizmente não tive tempo de implementar esta abordagem onde era minha intenção aplicar devidamente
            //as camadas sob norma NTier, aplicar mais interação com o utilizador deixando-o até manipular ficheiros.

            #region ++++ Test Menu Concept ++++

            //int menuAux; //variavel que gere a escolha do menu
            //do
            //{
            //    Console.Clear();
            //    Console.ForegroundColor = ConsoleColor.Cyan;
            //    Console.WriteLine("\n Bemvindo ao Sistema de Gestão FamaAmbiente \n \n");
            //    Console.ResetColor();

            //    Console.WriteLine("o que deseja fazer?\n");

            //    Console.WriteLine(
            //        "1 - Adicionar novo ticket\n" +
            //        "2 - Listar todos os tickets\n" +
            //        "3 - Adicionar novo cliente\n" +
            //        "4 - Listar todos os Clientes\n" +
            //        "5 - Adicionar novo Tecnico\n" +
            //        "6 - Listar todos os técnicos\n" +
            //        "7 - Relatório de Ocorrências por Infraestrutura\n" +
            //        "8 - Sair\n"
            //        );

            //    _ = int.TryParse(Console.ReadLine(), out menuAux) ? menuAux : 0;

            //    switch (menuAux)
            //    {
            //        case 1:
            //            //MenuOperation.OperationAdicionaTicket();
            //            break;

            //        case 2:
            //            MenuOperation.OperationListaTickets(out int ticketTotal, out int solvedTotal);
            //            break;

            //        case 3:
            //            //MenuOperation.OperationAdicionaCliente();
            //            break;

            //        case 4:
            //            //MenuOperation.OperationListaClientes();
            //            break;

            //        case 5:
            //            //MenuOperation.OperationAdicionaTecnico();
            //            break;

            //        case 6:
            //            //MenuOperation.OperationListaTecnicos();
            //            break;

            //        case 7:
            //            //MenuOperation.OperationRelatorioInfraestrutura();

            //            break;

            //        case 8:
            //            return; //Exits program
            //        default:
            //            Console.WriteLine("Opção inválida!");
            //            Console.ReadLine();
            //            break;
            //    }
            //} while (menuAux != 0);


            #endregion


            #endregion




        }
    }
}