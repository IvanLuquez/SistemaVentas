using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerModel.Responses
{
    public class MessageResponse
    {
        public required string Message { get; set; }
        public bool Success { get; set; }
        public required string ErrorCode { get; set; }
        public required string ErrorDescription { get; set; }
        public DataTable? DataConsult { get; set; }
    }
}
