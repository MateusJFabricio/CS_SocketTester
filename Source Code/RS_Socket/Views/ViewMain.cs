using System;
using System.Windows.Forms;
using RS_Socket.Model;

namespace UR10_Socket
{
 
    public partial class ViewMain : Form
    {
        RSModel model = new RSModel();
        private bool pauseReceiveMessage_Client = false;
        private bool pauseReceiveMessage_Server = false;

        public ViewMain()
        {
            InitializeComponent();
            
        }

        private void btnConect_Click(object sender, EventArgs e)
        {
            btnConect.Enabled = false;

            if (!model.VerifyGate(txtGate.Text))
            {
                MessageBox.Show("Porta Invalida");
                return;
            }

            timerVerifyConection.Start();

            if(tabSendReceive.SelectedTab == tabSendReceive.TabPages["tabClient"])
            {
                model.connectClientSocket(cbIp.SelectedItem.ToString(), txtGate.Text);
            }else
            {
                model.connectServerSocket(cbIp.SelectedItem.ToString(), txtGate.Text);
            }
        }

        private void btnSend_Client_Click(object sender, EventArgs e)
        {
            
            if((rtSend_Client.Text.Length == 0))
            {
                MessageBox.Show("Digite uma mensagem para enviar");
                return;
            }

            model.sendClientMessage(rtSend_Client.Text);
        }

        private void btnPause_Client_Click(object sender, EventArgs e)
        {
            pauseReceiveMessage_Client = true;
        }

        private void btnDesconectar_Client_Click(object sender, EventArgs e)
        {
            timerReceiver.Stop();
            timerVerifyConection.Start();
            pnlServer.Enabled = false;;
            pnlClient.Enabled = false;
            rtReceive_Client.Text = "";
            rtReceive_Server.Text = "";
            rtSend_Client.Text = "";
            rtSend_Server.Text = "";

            if (tabSendReceive.SelectedTab == tabSendReceive.TabPages["tabClient"])
            {
                model.disconectClientSocket();
            }
            else
            {
                model.disconectServerSocket();
            }
            btnDesconectar.Enabled = false;
            btnConect.Enabled = true;
        }

        private void btnContinue_Client_Click(object sender, EventArgs e)
        {
            pauseReceiveMessage_Client = false;
        }

        private void btnEnviar_Server_Click(object sender, EventArgs e)
        {
            if ((rtSend_Server.Text.Length == 0))
            {
                MessageBox.Show("Digite uma mensagem para enviar");
                return;
            }

            model.sendServerMessage(rtSend_Server.Text);
        }

        private void btnPausar_Server_Click(object sender, EventArgs e)
        {
            pauseReceiveMessage_Server = true;
        }

        private void btnContinuar_server_Click(object sender, EventArgs e)
        {
            pauseReceiveMessage_Server = false;
        }

        private void tabSendReceive_Deselecting(object sender, TabControlCancelEventArgs e)
        {
            if (model.isClientConection)
            {
                if (e.TabPage.Name == "tabClient")
                {
                    if (DialogResult.OK == MessageBox.Show("Ha uma conexao Client ativa. Gostaria de desativar esta conexao?", "Confirma", MessageBoxButtons.OKCancel))
                    {
                        btnDesconectar_Client_Click(sender, e);
                    }
                    else
                        e.Cancel = true; ;
                }
            }

            if (model.isServerConection)
            {
                if (e.TabPage.Name == "tabServidor")
                {
                    if (DialogResult.OK == MessageBox.Show("Ha uma conexao Server ativa. Gostaria de desativar esta conexao?", "Confirma", MessageBoxButtons.OKCancel))
                    {
                        btnDesconectar_Client_Click(sender, e);
                    }
                    else
                        e.Cancel = true; ;
                }
            }
        }

        private void ViewMain_Shown(object sender, EventArgs e)
        {
            cbIp.Items.AddRange(model.ListIP);
            cbIp.SelectedIndex =0;
        }

        private void timerReceiver_Tick(object sender, EventArgs e)
        {
            if((!model.isClientConection) && (!model.isServerConection))
            {
                btnDesconectar_Client_Click(sender, e);
                timerReceiver.Stop();
                timerVerifyConection.Start();
                return;
            }

            if ((!pauseReceiveMessage_Client) || (!pauseReceiveMessage_Server))
            {
                if (model.isServerConection || model.isClientConection)
                {
                    if (tabSendReceive.SelectedTab.Name == "tabServidor")
                        rtReceive_Server.AppendText(model.receiveServerMessage());
                    else
                        rtReceive_Client.AppendText(model.receiveClientMessage());
                }
            }
        }

        private void timerVerifyConection_Tick(object sender, EventArgs e)
        {
            if (model.isClientConection || model.isServerConection)
            {
                btnDesconectar.Enabled = true;

                if (model.isClientConection)
                    pnlClient.Enabled = true;

                if (model.isServerConection)
                    pnlServer.Enabled = true;

                timerReceiver.Start();
                timerVerifyConection.Stop();
            }
        }

    }
}
