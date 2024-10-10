using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BlockchainProjeDenemesi
{
    static internal class BlockchainLowLevel
    {
        const string GenesisBlockText = "Genesis Block";
        public static BlokObjesi CreateGenesisBlock()
        {
            byte[] PreviousBlockID = BitConverter.GetBytes(0);
            byte[] BlockID = HashBlock(PreviousBlockID, GenesisBlockText, 0);

            BlokObjesi GenesisBlock = new BlokObjesi(BlockID, PreviousBlockID, GenesisBlockText);

            return GenesisBlock;
        }
        public static byte[] HashBlock(byte[] PreviousBlockID, string BlockData, int Nonce)
        {
            string PreviousBlockString = BitConverter.ToString(PreviousBlockID);
            string NonceString = Nonce.ToString();
            string CompletedBlock = PreviousBlockString + NonceString + BlockData;

            byte[] NewBlockId = SHA1.HashData(Encoding.ASCII.GetBytes(CompletedBlock)); 
            return NewBlockId;
        }
    }
}
