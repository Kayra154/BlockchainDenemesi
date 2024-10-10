using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockchainProjeDenemesi
{
    internal class BlokObjesi
    {
        private byte[] _BlockID;
        private byte[] _PreviousBlockID;
        private string _Data;
        private int _Nonce;

        public byte[] BlockID { get { return _BlockID; } }
        public byte[] PreviousBlockID { get { return _PreviousBlockID; } }
        public string Data { get { return _Data; } }
        public int Nonce { get { return _Nonce; } }

        public BlokObjesi(byte[] BlockID, byte[] PreviousBlockID, string Data, int Nonce=0)
        {
            _BlockID = BlockID;
            _PreviousBlockID = PreviousBlockID;
            _Data = Data;
            _Nonce = Nonce;
        }
    }
}
