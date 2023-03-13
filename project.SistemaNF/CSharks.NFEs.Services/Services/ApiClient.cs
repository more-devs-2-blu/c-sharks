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

namespace CSharks.NFEs.Services.Services
{
    public class ApiClient : IApiClientService
    {
        public string EmitNF(XmlSerializer xmlNf)
        {
            var _url = "https://homologacao.atende.net/?pg=rest&service=WNERestServiceNFSe&cidade=integracoes";

            XmlDocument soapEnvelopeXml = CreateSoapEnvelope();
            HttpWebRequest webRequest = CreateWebRequest(_url);
            InsertSoapEnvelopeIntoWebRequest(soapEnvelopeXml, webRequest);

            IAsyncResult asyncResult = webRequest.BeginGetResponse(null, null);

            asyncResult.AsyncWaitHandle.WaitOne();

            string soapResult;
            using (WebResponse webResponse = webRequest.EndGetResponse(asyncResult))
            {
                using (StreamReader rd = new StreamReader(webResponse.GetResponseStream()))
                {
                    soapResult = rd.ReadToEnd();
                }
                Console.Write(soapResult);
            }



            return "";
        }
        private static XmlDocument CreateSoapEnvelope()
        {
            XmlDocument soapEnvelopeDocument = new XmlDocument();
            soapEnvelopeDocument.LoadXml(
            @"<SOAP-ENV:Envelope xmlns:SOAP-ENV=""http://schemas.xmlsoap.org/soap/envelope/"" 
                xmlns:xsi=""http://www.w3.org/1999/XMLSchema-instance"" 
                xmlns:xsd=""http://www.w3.org/1999/XMLSchema"">
                <SOAP-ENV:Body>
                    <HelloWorld xmlns=""http://tempuri.org/"" 
                        SOAP-ENV:encodingStyle=""http://schemas.xmlsoap.org/soap/encoding/"">
                        <int1 xsi:type=""xsd:integer"">12</int1>
                        <int2 xsi:type=""xsd:integer"">32</int2>
                    </HelloWorld>
                </SOAP-ENV:Body>
            </SOAP-ENV:Envelope>");
            return soapEnvelopeDocument;
        }

        private static void InsertSoapEnvelopeIntoWebRequest(XmlDocument soapEnvelopeXml, HttpWebRequest webRequest)
        {
            using (Stream stream = webRequest.GetRequestStream())
            {
                soapEnvelopeXml.Save(stream);
            }
        }
        private static HttpWebRequest CreateWebRequest(string url)
        {
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(url);
            webRequest.Headers.Add("Authorization", "MjUuODI1LjMwNy8wMDAxLTUyOlRlc3RlQDIwMjM");
            webRequest.ContentType = "multipart/form-data";
            webRequest.Accept = "xml";
            webRequest.Method = "POST";
            return webRequest;
        }

        public XmlSerializer GetFile(nfse nfe)
        {

            return SerializeXMLEmit(nfe);
        }
        public XmlSerializer SerializeXMLEmit(nfse nfe)
        {

            nfe.identificador = "3812817100220600010000000001";

            nfe.nf = new NF()
            {
                valor_total = "1,00"
            };

            nfe.prestador = new Prestador()
            {
                cpfcnpj = "00000000000000",
                cidade = "8357"
            };

            nfe.tomador = new Tomador()
            {
                tipo = "J",
                endereco_informado = "",
                identificador = "",
                cpfcnpj = "06262485902",
                nome_razao_social = "",
                ie = "",
                logradouro = "",
                email = "",
                numero_residencia = "",
                complemento = ""
            };

            lista item = new lista();
            item.tributa_municipio_prestador = "S";
            item.codigo_local_prestacao_servico = "8357";
            item.codigo_item_lista_servico = "702";
            item.descritivo = "Teste";
            item.aliquota_item_lista_servico = "5";
            item.situacao_tributaria = "0";
            item.valor_tributavel = "0";
            nfe.itens = new List<lista>
            {
                item
            };

            string nomeArquivo = DateTime.Now.ToString().Replace(@"/", "").Replace(@" ", "").Replace(@":", "") + ".xml";
            using (StreamWriter stream = new StreamWriter(Path.Combine(@"D:\Pastas\Programação\Devs2Blu\Hackathon\Csharks", nomeArquivo)))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(nfse));
                xmlSerializer.Serialize(stream, nfe);
                return xmlSerializer;
            }
        }
    } 
}
