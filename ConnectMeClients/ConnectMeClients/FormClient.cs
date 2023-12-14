using ClientMe;
using ConnectMeClients.Util;

namespace ConnectMeClients
{
    public partial class FormClient : Form
    {
        public FormClient()
        {
            InitializeComponent();
        }

        private async void btnStatus_Click(object sender, EventArgs e)
        {
            ClientsManagerUtil clientsManagerUtil = new ClientsManagerUtil();
            clientsManagerUtil.InitializeGrpcConnection();

            bool status = (btnStatus.BackColor == Color.LimeGreen) ? Disable() : Enable();

            await clientsManagerUtil.HandleConnection(new RequestConnection { ClientName = lblUsername.Text, Status = status }, this);
        }

        private async void btnSendMessage_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtClientRecipient.Text) && !string.IsNullOrEmpty(MessageTextBox.Text))
            {
                ClientsManagerUtil clientsManagerUtil = new ClientsManagerUtil();

                await clientsManagerUtil.RequestClient(new RequestClient { ClientToSend = txtClientRecipient.Text, Message = MessageTextBox.Text }, this);

                ChatTextBox.Text += $"{lblUsername.Text}: {MessageTextBox.Text}\r\n";
                MessageTextBox.Text = "";
            }
        }

        private bool Disable()
        {
            btnStatus.BackColor = Color.Red;
            btnSendMessage.Enabled = false;
            return false;
        }

        private bool Enable()
        {
            btnStatus.BackColor = Color.LimeGreen;
            btnSendMessage.Enabled = true;
            return true;
        }
    }
}
