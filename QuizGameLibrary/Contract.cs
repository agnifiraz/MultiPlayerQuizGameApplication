/*
 * File name: Contract.cs
 * Author: Dhanashri, Ivan, Agnita 
 * Creation Date: 03 April, 2023
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace QuizGameLibrary
{
    // Define the service contract interface IGameQuestions
    [ServiceContract(CallbackContract = typeof(ICallBack))] // Use the CallbackContract attribute to specify the callback contract type
    public interface IGameQuestions
    {
        // Declare the operation contract GetQuestion that returns a Question object
        [OperationContract]
        Question GetQuestion();

        // Declare the property NumQuestions that returns the number of questions as an unsigned integer
        uint NumQuestions { [OperationContract] get; }

        // Declare the operation contract GetNumberOfPlayers that returns the number of players as an unsigned integer
        [OperationContract]
        uint GetNumberOfPlayers();

        // Declare the operation contract Join that allows a player to join the game by specifying their name and returns a boolean value indicating success or failure
        [OperationContract]
        bool Join(string name);

        // Declare the operation contract Join2 that allows a player to join the game by specifying their name and returns a boolean value indicating success or failure
        [OperationContract]
        bool Join2(string name);

        // Declare the operation contract Leave that allows a player to leave the game by specifying their name and is a one-way operation (i.e., the client does not wait for a response from the server)
        [OperationContract(IsOneWay = true)]
        void Leave(string name);

        // Declare the operation contract PostUserName that allows a client to post a user name as a message and is a one-way operation
        [OperationContract(IsOneWay = true)]
        void PostUserName(string message);

        // Declare the operation contract PostUser that allows a client to post a user name and points as a message and is a one-way operation
        [OperationContract(IsOneWay = true)]
        void PostUser(string name, uint pts);
    }
}