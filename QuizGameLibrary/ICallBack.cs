/*
 * File name: ICallBack.cs
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
    public interface ICallBack
    {
        [OperationContract(IsOneWay = true)]
        //sends an array of Player objects to all subscribed clients
        void SendAllPlayers(Player[] messages);
        [OperationContract(IsOneWay = true)]
        //sends an array of Player objects representing points to all subscribed clients
        void SendAllPoints(Player[] messages);

    }
}