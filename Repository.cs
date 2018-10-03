using System;
using System.Runtime.Serialization;

namespace WebAPIClient
{
    [DataContract(Name="repo")]
    public class Repository
    {
        public string name;
    }
}
