using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Errors
{
    public class ApiException
    {
        public ApiException(int stutusCode, string messages = null, string details = null)
        {
            StutusCode = stutusCode;
            Messages = messages;
            Details = details;
        }

        public int StutusCode { get; set; }
        public string Messages { get; set; }
        public string Details { get; set; }
    }
}