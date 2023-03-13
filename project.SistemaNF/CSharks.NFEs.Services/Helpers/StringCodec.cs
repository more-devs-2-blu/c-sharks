using System.Text;

namespace CSharks.NFEs.Services.Helpers
{
    public class StringCodec 
    {
        public static string DecodeFromBase64(string str)
        {
            byte[] encodedBytes = Convert.FromBase64String(str);
            string decodedString = Encoding.UTF8.GetString(encodedBytes);
            return decodedString;
        }

        public static string EncodeToBase64(string str)
        {
            byte[] encodedBytes = Encoding.UTF8.GetBytes(str);
            string encodedString = Convert.ToBase64String(encodedBytes);
            return encodedString;
        }
    }
}
