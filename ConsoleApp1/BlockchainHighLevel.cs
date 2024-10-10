using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockchainProjeDenemesi
{
    internal class BlockchainHighLevel
    {
        LinkedList<BlokObjesi> _BlockChain;

        public LinkedList<BlokObjesi > BlockChain {  get { return _BlockChain; } }

        public BlockchainHighLevel()
        {
            _BlockChain = new LinkedList<BlokObjesi>();
            _BlockChain.AddLast(BlockchainLowLevel.CreateGenesisBlock());
        }

        public void AddBlock(string DataToAdd)
        {
            byte[] NewBlockID = BlockchainLowLevel.HashBlock(_BlockChain.Last.Value.BlockID, DataToAdd, 0);
            BlokObjesi NewBlock = new BlokObjesi(NewBlockID, _BlockChain.Last.Value.BlockID, DataToAdd);
            _BlockChain.AddLast(NewBlock);
        }
    }
}
