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

        static readonly HttpClient _client = new HttpClient();

        public async void EmitNF(string xmlFileEmit)
        {
            const string _url = "https://homologacao.atende.net/?pg=rest&service=WNERestServiceNFSe&cidade=integracoes";

            try

            {
                _client.DefaultRequestHeaders.Authorization = AuthenticationHeaderValue.Parse("Basic MjUuODI1LjMwNy8wMDAxLTUyOlRlc3RlQDIwMjM");
                //var stringContent = new StringContent(xmlFileEmit, Encoding.UTF8, "multipart/form-data");

                var stringContent = new StringContent(xmlFileEmit);
                stringContent.Headers.ContentType = new MediaTypeHeaderValue("application/xml");

                var response = await _client.PostAsync(_url, stringContent);
                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(responseBody);
                }
                else
                {
                    Console.WriteLine(response.StatusCode);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro: {e.Message}");
            }
        }

        public string GetFile(NFEDTO nfe)
        {

            return SerializeXMLEmit(nfe);
        }

        public string SerializeXMLEmit(NFEDTO nfe)
        {

            nfe.Identificador = "3812817100220600010000000001";

            nfe.Nf = new NF()
            {
                ValorTotal = "1,00"
            };

            nfe.Prestador = new Prestador()
            {
                CpfCnpj = "00000000000000",
                Cidade = "8357"
            };

            nfe.Tomador = new Tomador()
            {
                Tipo = "J",
                EnderecoInformado = "lalala",
                Identificador = "0000000000",
                CpfCnpj = "06262485902",
                NomeRazaoSocial = "lepo",
                Ie = "testeie",
                Logradouro = "testerua",
                Email = "teste@gmail.com",
                NumeroResidencia = "658",
                Complemento = "casa"
            };

            lista item = new lista();
            item.TributaMunicipioPrestador = "S";
            item.CodigoLocalPrestServico = "8357";
            item.CodigoServico = "702";
            item.Descricao = "Teste";
            item.AliquotaServico = "5";
            item.SituacaoTributaria = "0";
            item.ValorTributavel = "0";
            nfe.Itens = new List<lista>
            {
                item
            };

            string nomeArquivo = DateTime.Now.ToString().Replace(@"/", "").Replace(@" ", "").Replace(@":", "") + ".xml";
            using (StreamWriter stream = new StreamWriter(Path.Combine(@"D:\Pastas\Programação\Devs2Blu\Hackathon\Csharks", nomeArquivo)))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(NFEDTO));
                xmlSerializer.Serialize(stream, nfe);

                var sw = new StringWriter();
                xmlSerializer.Serialize(sw, nfe);

                return sw.ToString();
            }
        }
    } 
}
