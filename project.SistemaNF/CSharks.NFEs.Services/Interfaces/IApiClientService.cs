using CSharks.NFEs.Domain.DTOs;
using CSharks.NFEs.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace CSharks.NFEs.Services.Interfaces
{
    public interface IApiClientService
    {
        public string GetFile(NFEDTO nfe);
        public string SerializeXMLEmit(NFEDTO nfe);
        public Task<EmitedNF> EmitNF(string xmlFileEdit, string pathFile);

    }
}
