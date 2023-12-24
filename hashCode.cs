using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Grocery_Store_Management
{
    class hashCode
    {
        public string pass_hash(string data){

            SHA1 sha = SHA1.Create();
            byte[] hashdat = sha.ComputeHash(Encoding.Default.GetBytes(data));
            StringBuilder return_value = new StringBuilder();
            for (int i = 0; i < hashdat.Length; i++){

                return_value.Append(hashdat[i].ToString());
            }

            return return_value.ToString();
         }




    }
}
