using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities.Interfaces
{
    public interface IHasher
    {
        public string Hash(string input);
        public bool Verify(string input, string hashString);
    }
}
