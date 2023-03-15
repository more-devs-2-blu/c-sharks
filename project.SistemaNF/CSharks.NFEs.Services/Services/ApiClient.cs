using CSharks.NFEs.Domain.Models;
using CSharks.NFEs.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using CSharks.NFEs.Domain.DTOs;
using System.Net;
using MySql.Data.MySqlClient.Memcached;
using System.Net.Http.Headers;
using System.Reflection.Metadata;
using System.Security.Principal;
using System.Xml.Linq;

namespace CSharks.NFEs.Services.Services
{
    public class ApiClient : IApiClientService
    {
        public async void EmitNF(string xmlFileEmit)
        {
            const string _url = "https://homologacao.atende.net/?pg=rest&service=WNERestServiceNFSe&cidade=integracoes";
            string Sxmldata = xmlFileEmit;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(_url);
            request.Method = "POST";
            request.ContentType = "multipart/form-data";
            request.Headers.Add("Authorization", "Basic MjUuODI1LjMwNy8wMDAxLTUyOlRlc3RlQDIwMjM");

            using (StreamWriter writer = new StreamWriter(request.GetRequestStream()))
            {
                writer.Write(Sxmldata);
            }

            try
            {
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    string responseBody = new StreamReader(response.GetResponseStream()).ReadToEnd();
                    Console.WriteLine(responseBody);
                }
                else
                {
                    Console.WriteLine($"Erro: {response.StatusCode}");
                }

                response.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro: {e.Message}");
            }
        }

        public string GetFile(NFEDTO nfe)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(NFEDTO));
            var sw = new StringWriter();

            xmlSerializer.Serialize(sw, nfe);

            return sw.ToString();
        }
    }
}
