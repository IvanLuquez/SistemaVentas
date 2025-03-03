using LayerModel.Responses;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerData
{
    public class ValidationErrors
    {

        public static MessageResponse ValidationException(NpgsqlException ex)
        {
            return new MessageResponse
            {
                Message = "Message: Error SQL State: " + ex.SqlState,
                Success = false,
                ErrorCode = "Error Code: " + ex.ErrorCode.ToString(),
                ErrorDescription = "Descripcion: " + ex.Message + " \n" + ex.InnerException
            };
        }

        public static MessageResponse SuccesMessage(DataTable? data, string information)
        {
            return new MessageResponse
            {
                Message = "Message: " + information,
                Success = true,
                ErrorCode = "0",
                ErrorDescription = "Success",
                DataConsult = data
            };
        }

    }
}
