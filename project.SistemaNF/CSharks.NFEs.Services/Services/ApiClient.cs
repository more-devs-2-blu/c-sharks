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

        
        //novo emmit
        public async Task<EmitedNF> EmitNF(string xmlFileEmit, string pathFile)
        {
            const string _url = "https://homologacao.atende.net/?pg=rest&service=WNERestServiceNFSe&cidade=integracoes";
            string Sxmldata = xmlFileEmit;

            string tempFilePath = Path.GetTempFileName();
            string xmlFilePath = pathFile;
            EmitedNF emited = new EmitedNF();

            try
            {
                File.WriteAllText(tempFilePath, Sxmldata);
                File.WriteAllText(xmlFilePath, Sxmldata);


                HttpClient httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", "MjUuODI1LjMwNy8wMDAxLTUyOlRlc3RlQDIwMjM");


                using (var formDataContent = new MultipartFormDataContent())
                {
                    using (var streamContent = new StreamContent(File.OpenRead(tempFilePath)))
                    {
                        formDataContent.Add(streamContent, "teste", Path.GetFileName(tempFilePath));

                        var response = await httpClient.PostAsync(_url, formDataContent);

                        if (response.StatusCode == HttpStatusCode.OK)
                        {
                            string responseBody = await response.Content.ReadAsStringAsync();
                            //use emited
                            

                            XmlDocument xmlDoc = new XmlDocument();
                            xmlDoc.LoadXml(responseBody);
                            string numeroNfse = xmlDoc.SelectSingleNode("//numero_nfse").InnerText;
                            string codVerificadorAutenticidade = xmlDoc.SelectSingleNode("//cod_verificador_autenticidade").InnerText;

                            emited.Situation = "Success";
                            emited.NoNfse = numeroNfse;
                            emited.CodVerify = codVerificadorAutenticidade;
                            emited.LinkPDF = $"https://homologacao.atende.net//autoatendimento/servicos/consulta-de-autenticidade-de-nota-fiscal-eletronica-nfse/detalhar/1/identificador/{emited.CodVerify}?cidade=integracoes";
                            return emited;

                        }
                        else
                        {
                            Console.WriteLine($"Erro: {response.StatusCode}");
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro: {e.Message}");
                
            }
            finally
            {
                // Delete the temporary file
                File.Delete(tempFilePath);
            }

            return emited;
        }  
        public async Task<EmitedNF> CancelNF(string xmlFileEmit, string pathFile)
        {
            const string _url = "https://homologacao.atende.net/?pg=rest&service=WNERestServiceNFSe&cidade=integracoes";
            string Sxmldata = xmlFileEmit;

            string tempFilePath = Path.GetTempFileName();
            string xmlFilePath = pathFile;
            EmitedNF emited = new EmitedNF();

            try
            {
                File.WriteAllText(tempFilePath, Sxmldata);
                File.WriteAllText(xmlFilePath, Sxmldata);


                HttpClient httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", "MjUuODI1LjMwNy8wMDAxLTUyOlRlc3RlQDIwMjM");

                using (var formDataContent = new MultipartFormDataContent())
                {
                    using (var streamContent = new StreamContent(File.OpenRead(tempFilePath)))
                    {
                        formDataContent.Add(streamContent, "teste", Path.GetFileName(tempFilePath));

                        var response = await httpClient.PostAsync(_url, formDataContent);

                        if (response.StatusCode == HttpStatusCode.OK)
                        {
                            string responseBody = await response.Content.ReadAsStringAsync();
                            //use emited
                            responseBody = responseBody.Replace(" <?","<?");
                            XmlDocument xmlDoc = new XmlDocument();
                            xmlDoc.LoadXml(responseBody);

                            if (xmlDoc.SelectSingleNode("//codigo").InnerText.StartsWith("00117"))
                            {
                                emited.Situation = "Already canceled";
                            }
                            else
                            {
                                emited.Situation = "Cancel";
                            }
                            return emited;

                        }
                        else
                        {
                            Console.WriteLine($"Erro: {response.StatusCode}");
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro: {e.Message}");
                
            }
            finally
            {
                // Delete the temporary file
                File.Delete(tempFilePath);
            }

            return emited;
        }

        public string GetFile(NFEDTO nfe)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(NFEDTO));
            var sw = new Utf8StringWriter();

            xmlSerializer.Serialize(sw, nfe);

            return sw.ToString();
        }

        public class Utf8StringWriter : StringWriter
        {
            public override Encoding Encoding => Encoding.UTF8;
        }
    }
}
