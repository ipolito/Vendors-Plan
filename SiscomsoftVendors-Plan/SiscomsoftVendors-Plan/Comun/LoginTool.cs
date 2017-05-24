using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;

using System.Security.Cryptography;

namespace SiscomsoftVendors_Plan.Comun
{
    class LoginTool
    {
        /// <summary>
        /// FUNCION ENCARGADA DE GENERAL LA CLAVE MD5 DE ENCRIPTACION PARA EL PASSWORD
        /// </summary>
        /// <param name="str">PASSWORD A ECRIPTAR</param>
        /// <returns>CADENA DE TEXTO DE LA CLAVE ENCRIPTADA</returns>
        public static String getMD5(string str)
        {
            MD5 md5 = MD5CryptoServiceProvider.Create();
            ASCIIEncoding enconding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = md5.ComputeHash(enconding.GetBytes(str));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2 }", stream[i]);
            return sb.ToString();
        }
    }
}