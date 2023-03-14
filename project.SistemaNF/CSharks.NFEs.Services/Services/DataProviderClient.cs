using CSharks.NFEs.Domain.DTOs;
using CSharks.NFEs.Domain.Models;
using CSharks.NFEs.Services.Interfaces;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace CSharks.NFEs.Services.Services
{
    public class DataProviderClient : IDataProviderService
    {
        private readonly HttpClient _httpClient;

        public DataProviderClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async void SendToms(List<TOMDTO> toms)
        {
            const string URL = "/city";
            var json = JsonConvert.SerializeObject(toms);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync(URL, content);
        }

        public string GetTomByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
