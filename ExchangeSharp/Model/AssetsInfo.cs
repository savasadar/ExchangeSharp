using System;
using System.Collections.Generic;
using System.Text;

namespace ExchangeSharp
{
    public class Deposit
    {
        public string currency { get; set; }
        public string address { get; set; }
        public string amount { get; set; }
        public int confirmations { get; set; }
        public string txid { get; set; }
        public int timestamp { get; set; }
        public string status { get; set; }
    }

    public class Withdrawal
    {
        public int withdrawalNumber { get; set; }
        public string currency { get; set; }
        public string address { get; set; }
        public string amount { get; set; }
        public string fee { get; set; }
        public int timestamp { get; set; }
        public string status { get; set; }
        public string ipAddress { get; set; }
    }

    public class AssetsInfo
    {
        public List<Deposit> deposits { get; set; }
        public List<Withdrawal> withdrawals { get; set; }
    }
}
