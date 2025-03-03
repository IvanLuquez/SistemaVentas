using LayerModel.Responses;

namespace LayerViews.Responses
{
    public class ShowMessages
    {
        private string messageConcat = string.Empty;

        public void ShowMessage(MessageResponse messageResponse)
        {
            messageConcat = string.Empty;
            if (messageResponse.Success)
            {
                MessageBox.Show(messageResponse.Message, "Opreacion Completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                messageConcat = messageConcat + messageResponse.Message + "\n";
                messageConcat = messageConcat + messageResponse.ErrorCode + "\n";
                messageConcat = messageConcat + messageResponse.ErrorDescription;
                MessageBox.Show(messageConcat, "Opreacion Con errores", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool ShowCheckMessage(string message)
        {
            bool result = false;

            var response = MessageBox.Show(message, "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (response == DialogResult.Yes) result = true;

            return result;
        }
    }
}
