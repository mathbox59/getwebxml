using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace GetWebXML.DES
{
    public class Encryption_Base64
    {    /// Base64加密
        public static string Base64Code(string Message)
        {
            byte[] encData_byte = new byte[Message.Length];
            encData_byte = System.Text.Encoding.UTF8.GetBytes(Message);
            string encodedData = Convert.ToBase64String(encData_byte);
            return encodedData;
        }
    }
}
