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
