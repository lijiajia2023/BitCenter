using System;
using System.Collections.Generic;
using System.Text;
using CookComputing.XmlRpc;

namespace BitCenter
{
    public struct BitAddress
    {
        public string label;
        public string address;
        public int stream;
        public bool enabled;
    }

    public interface BitAPI : IXmlRpcProxy
    {
        [XmlRpcMethod]
        string helloWorld(string firstWord, string secondWord);
        [XmlRpcMethod]
        int add(int a, int b);
        [XmlRpcMethod]
        void statusBar(string message);
        [XmlRpcMethod]
        string sendBroadcast(string Addr, string Base64subject, string Base64message);
        [XmlRpcMethod]
        string sendMessage(string ToAddr, string FromAddr, string Base64subject, string Base64message);
        [XmlRpcMethod]
        string createRandomAddress(string base64label, bool shortAddr,int totalDifficulty,int smallMessageDifficulty);
        [XmlRpcMethod]
        string createDeterministicAddresses(string base64Password, int numberAddr, int addrVersion, int stream, bool shortAddr, int totalDifficulty, int smallMessageDifficulty);
        [XmlRpcMethod]
        string getAllInboxMessages();
        [XmlRpcMethod]
        void trashMessage(string msgid);
        [XmlRpcMethod]
        string getStatus(string msgID);
        [XmlRpcMethod]
        void addSubscription(string addr, string b64label);
        [XmlRpcMethod]
        void deleteSubscription(string addr);
    }
}
