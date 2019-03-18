namespace UR10_Socket
{
    partial class ViewMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConect = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.tabSendReceive = new System.Windows.Forms.TabControl();
            this.tabClient = new System.Windows.Forms.TabPage();
            this.pnlClient = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnContinue_Client = new System.Windows.Forms.Button();
            this.rtReceive_Client = new System.Windows.Forms.RichTextBox();
            this.btnPause_Client = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSend_Client = new System.Windows.Forms.Button();
            this.rtSend_Client = new System.Windows.Forms.RichTextBox();
            this.tabServidor = new System.Windows.Forms.TabPage();
            this.pnlServer = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnContinuar_server = new System.Windows.Forms.Button();
            this.btnPausar_Server = new System.Windows.Forms.Button();
            this.rtReceive_Server = new System.Windows.Forms.RichTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnEnviar_Server = new System.Windows.Forms.Button();
            this.rtSend_Server = new System.Windows.Forms.RichTextBox();
            this.cbIp = new System.Windows.Forms.ComboBox();
            this.timerReceiver = new System.Windows.Forms.Timer(this.components);
            this.timerVerifyConection = new System.Windows.Forms.Timer(this.components);
            this.tabSendReceive.SuspendLayout();
            this.tabClient.SuspendLayout();
            this.pnlClient.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabServidor.SuspendLayout();
            this.pnlServer.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Porta:";
            // 
            // txtGate
            // 
            this.txtGate.Location = new System.Drawing.Point(139, 27);
            this.txtGate.Name = "txtGate";
            this.txtGate.Size = new System.Drawing.Size(100, 20);
            this.txtGate.TabIndex = 3;
            this.txtGate.Text = "30002";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "IP:";
            // 
            // btnConect
            // 
            this.btnConect.Location = new System.Drawing.Point(253, 27);
            this.btnConect.Name = "btnConect";
            this.btnConect.Size = new System.Drawing.Size(83, 23);
            this.btnConect.TabIndex = 6;
            this.btnConect.Text = "Conectar";
            this.btnConect.UseVisualStyleBackColor = true;
            this.btnConect.Click += new System.EventHandler(this.btnConect_Click);
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.Enabled = false;
            this.btnDesconectar.Location = new System.Drawing.Point(356, 27);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(83, 23);
            this.btnDesconectar.TabIndex = 10;
            this.btnDesconectar.Text = "Desconectar";
            this.btnDesconectar.UseVisualStyleBackColor = true;
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Client_Click);
            // 
            // tabSendReceive
            // 
            this.tabSendReceive.Controls.Add(this.tabClient);
            this.tabSendReceive.Controls.Add(this.tabServidor);
            this.tabSendReceive.Location = new System.Drawing.Point(12, 53);
            this.tabSendReceive.Name = "tabSendReceive";
            this.tabSendReceive.SelectedIndex = 0;
            this.tabSendReceive.Size = new System.Drawing.Size(621, 295);
            this.tabSendReceive.TabIndex = 11;
            this.tabSendReceive.Deselecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabSendReceive_Deselecting);
            // 
            // tabClient
            // 
            this.tabClient.Controls.Add(this.pnlClient);
            this.tabClient.Location = new System.Drawing.Point(4, 22);
            this.tabClient.Name = "tabClient";
            this.tabClient.Padding = new System.Windows.Forms.Padding(3);
            this.tabClient.Size = new System.Drawing.Size(613, 269);
            this.tabClient.TabIndex = 0;
            this.tabClient.Text = "Cliente";
            this.tabClient.UseVisualStyleBackColor = true;
            // 
            // pnlClient
            // 
            this.pnlClient.Controls.Add(this.groupBox2);
            this.pnlClient.Controls.Add(this.groupBox1);
            this.pnlClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlClient.Enabled = false;
            this.pnlClient.Location = new System.Drawing.Point(3, 3);
            this.pnlClient.Name = "pnlClient";
            this.pnlClient.Size = new System.Drawing.Size(607, 263);
            this.pnlClient.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnContinue_Client);
            this.groupBox2.Controls.Add(this.rtReceive_Client);
            this.groupBox2.Controls.Add(this.btnPause_Client);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 121);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(607, 142);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recebido";
            // 
            // btnContinue_Client
            // 
            this.btnContinue_Client.Location = new System.Drawing.Point(504, 48);
            this.btnContinue_Client.Name = "btnContinue_Client";
            this.btnContinue_Client.Size = new System.Drawing.Size(75, 23);
            this.btnContinue_Client.TabIndex = 3;
            this.btnContinue_Client.Text = "Continuar";
            this.btnContinue_Client.UseVisualStyleBackColor = true;
            this.btnContinue_Client.Click += new System.EventHandler(this.btnContinue_Client_Click);
            // 
            // rtReceive_Client
            // 
            this.rtReceive_Client.Location = new System.Drawing.Point(6, 19);
            this.rtReceive_Client.Name = "rtReceive_Client";
            this.rtReceive_Client.Size = new System.Drawing.Size(478, 96);
            this.rtReceive_Client.TabIndex = 0;
            this.rtReceive_Client.Text = "";
            // 
            // btnPause_Client
            // 
            this.btnPause_Client.Location = new System.Drawing.Point(504, 19);
            this.btnPause_Client.Name = "btnPause_Client";
            this.btnPause_Client.Size = new System.Drawing.Size(75, 23);
            this.btnPause_Client.TabIndex = 2;
            this.btnPause_Client.Text = "Pausar";
            this.btnPause_Client.UseVisualStyleBackColor = true;
            this.btnPause_Client.Click += new System.EventHandler(this.btnPause_Client_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSend_Client);
            this.groupBox1.Controls.Add(this.rtSend_Client);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(607, 115);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enviar";
            // 
            // btnSend_Client
            // 
            this.btnSend_Client.Location = new System.Drawing.Point(504, 19);
            this.btnSend_Client.Name = "btnSend_Client";
            this.btnSend_Client.Size = new System.Drawing.Size(75, 24);
            this.btnSend_Client.TabIndex = 5;
            this.btnSend_Client.Text = "Enviar";
            this.btnSend_Client.UseVisualStyleBackColor = true;
            this.btnSend_Client.Click += new System.EventHandler(this.btnSend_Client_Click);
            // 
            // rtSend_Client
            // 
            this.rtSend_Client.Location = new System.Drawing.Point(6, 22);
            this.rtSend_Client.Name = "rtSend_Client";
            this.rtSend_Client.Size = new System.Drawing.Size(478, 71);
            this.rtSend_Client.TabIndex = 4;
            this.rtSend_Client.Text = "";
            // 
            // tabServidor
            // 
            this.tabServidor.Controls.Add(this.pnlServer);
            this.tabServidor.Location = new System.Drawing.Point(4, 22);
            this.tabServidor.Name = "tabServidor";
            this.tabServidor.Padding = new System.Windows.Forms.Padding(3);
            this.tabServidor.Size = new System.Drawing.Size(613, 269);
            this.tabServidor.TabIndex = 1;
            this.tabServidor.Text = "Servidor";
            this.tabServidor.UseVisualStyleBackColor = true;
            // 
            // pnlServer
            // 
            this.pnlServer.Controls.Add(this.groupBox3);
            this.pnlServer.Controls.Add(this.groupBox4);
            this.pnlServer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlServer.Enabled = false;
            this.pnlServer.Location = new System.Drawing.Point(3, 3);
            this.pnlServer.Name = "pnlServer";
            this.pnlServer.Size = new System.Drawing.Size(607, 263);
            this.pnlServer.TabIndex = 14;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnContinuar_server);
            this.groupBox3.Controls.Add(this.btnPausar_Server);
            this.groupBox3.Controls.Add(this.rtReceive_Server);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 127);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(607, 136);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Recebido";
            // 
            // btnContinuar_server
            // 
            this.btnContinuar_server.Location = new System.Drawing.Point(504, 48);
            this.btnContinuar_server.Name = "btnContinuar_server";
            this.btnContinuar_server.Size = new System.Drawing.Size(75, 23);
            this.btnContinuar_server.TabIndex = 3;
            this.btnContinuar_server.Text = "Continuar";
            this.btnContinuar_server.UseVisualStyleBackColor = true;
            this.btnContinuar_server.Click += new System.EventHandler(this.btnContinuar_server_Click);
            // 
            // btnPausar_Server
            // 
            this.btnPausar_Server.Location = new System.Drawing.Point(504, 19);
            this.btnPausar_Server.Name = "btnPausar_Server";
            this.btnPausar_Server.Size = new System.Drawing.Size(75, 23);
            this.btnPausar_Server.TabIndex = 2;
            this.btnPausar_Server.Text = "Pausar";
            this.btnPausar_Server.UseVisualStyleBackColor = true;
            this.btnPausar_Server.Click += new System.EventHandler(this.btnPausar_Server_Click);
            // 
            // rtReceive_Server
            // 
            this.rtReceive_Server.Location = new System.Drawing.Point(6, 19);
            this.rtReceive_Server.Name = "rtReceive_Server";
            this.rtReceive_Server.Size = new System.Drawing.Size(478, 96);
            this.rtReceive_Server.TabIndex = 0;
            this.rtReceive_Server.Text = "";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnEnviar_Server);
            this.groupBox4.Controls.Add(this.rtSend_Server);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(607, 107);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Enviar";
            // 
            // btnEnviar_Server
            // 
            this.btnEnviar_Server.Location = new System.Drawing.Point(504, 19);
            this.btnEnviar_Server.Name = "btnEnviar_Server";
            this.btnEnviar_Server.Size = new System.Drawing.Size(75, 24);
            this.btnEnviar_Server.TabIndex = 5;
            this.btnEnviar_Server.Text = "Enviar";
            this.btnEnviar_Server.UseVisualStyleBackColor = true;
            this.btnEnviar_Server.Click += new System.EventHandler(this.btnEnviar_Server_Click);
            // 
            // rtSend_Server
            // 
            this.rtSend_Server.Location = new System.Drawing.Point(6, 22);
            this.rtSend_Server.Name = "rtSend_Server";
            this.rtSend_Server.Size = new System.Drawing.Size(478, 71);
            this.rtSend_Server.TabIndex = 4;
            this.rtSend_Server.Text = "";
            // 
            // cbIp
            // 
            this.cbIp.FormattingEnabled = true;
            this.cbIp.Items.AddRange(new object[] {
            "127.0.0.1"});
            this.cbIp.Location = new System.Drawing.Point(12, 27);
            this.cbIp.Name = "cbIp";
            this.cbIp.Size = new System.Drawing.Size(121, 21);
            this.cbIp.TabIndex = 12;
            // 
            // timerReceiver
            // 
            this.timerReceiver.Interval = 1000;
            this.timerReceiver.Tick += new System.EventHandler(this.timerReceiver_Tick);
            // 
            // timerVerifyConection
            // 
            this.timerVerifyConection.Interval = 1000;
            this.timerVerifyConection.Tick += new System.EventHandler(this.timerVerifyConection_Tick);
            // 
            // ViewMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 354);
            this.Controls.Add(this.cbIp);
            this.Controls.Add(this.tabSendReceive);
            this.Controls.Add(this.btnDesconectar);
            this.Controls.Add(this.btnConect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGate);
            this.Controls.Add(this.label1);
            this.Name = "ViewMain";
            this.Text = "RoboSoft API Comunição Socket";
            this.Shown += new System.EventHandler(this.ViewMain_Shown);
            this.tabSendReceive.ResumeLayout(false);
            this.tabClient.ResumeLayout(false);
            this.pnlClient.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tabServidor.ResumeLayout(false);
            this.pnlServer.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConect;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.TabControl tabSendReceive;
        private System.Windows.Forms.TabPage tabClient;
        private System.Windows.Forms.TabPage tabServidor;
        private System.Windows.Forms.ComboBox cbIp;
        private System.Windows.Forms.Timer timerReceiver;
        private System.Windows.Forms.Timer timerVerifyConection;
        private System.Windows.Forms.Panel pnlClient;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSend_Client;
        private System.Windows.Forms.RichTextBox rtSend_Client;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnContinue_Client;
        private System.Windows.Forms.RichTextBox rtReceive_Client;
        private System.Windows.Forms.Button btnPause_Client;
        private System.Windows.Forms.Panel pnlServer;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnContinuar_server;
        private System.Windows.Forms.Button btnPausar_Server;
        private System.Windows.Forms.RichTextBox rtReceive_Server;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnEnviar_Server;
        private System.Windows.Forms.RichTextBox rtSend_Server;
    }
}

