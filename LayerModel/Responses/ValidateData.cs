using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerModel.Responses
{
    public class ValidateData
    {
        public string ValidateString(string? data)
        {
            if (string.IsNullOrEmpty(data))
            {
                return "No Especificado";
            }
            return data;
        }   
    }
}
