using System;

namespace BlockchainProjeDenemesi
{
    class Program
    {
        static void Main(String[] args)
        {
            /*
            byte[] PreviousBlockID = BitConverter.GetBytes(0);
            string TransactionData = "MyTransactionData";
            int Nonce = 0;
            BlockchainLowLevel.HashBlock(PreviousBlockID,TransactionData,Nonce);    
            */

            BlockchainHighLevel BE = new BlockchainHighLevel();
            BE.AddBlock("Arthur pays William 10 BTC for bread");
            BE.AddBlock("Amelia pays 20 BTC to Ava for brick");
            BE.AddBlock("George pays 30 BTC to James for book");

            int itemAmount = 0;
            foreach (var item in BE.BlockChain)
            {
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Block Height:"+itemAmount);
                Console.WriteLine("Block ID:" + BitConverter.ToString(item.BlockID));
                Console.WriteLine("Previous Block ID: "+BitConverter.ToString(item.PreviousBlockID));
                Console.WriteLine("Transaction Data: "+item.Data);
                Console.WriteLine("----------------------------------------");
                itemAmount++;
            }
        }
    }
}