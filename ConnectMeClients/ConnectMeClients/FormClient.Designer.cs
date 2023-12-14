namespace ConnectMeClients
{
    partial class FormClient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ChatTextBox = new TextBox();
            btnSendMessage = new Button();
            txtClientRecipient = new TextBox();
            label1 = new Label();
            btnStatus = new Button();
            MessageTextBox = new TextBox();
            lblUsername = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // ChatTextBox
            // 
            ChatTextBox.Location = new Point(228, 9);
            ChatTextBox.Multiline = true;
            ChatTextBox.Name = "ChatTextBox";
            ChatTextBox.Size = new Size(166, 180);
            ChatTextBox.TabIndex = 20;
            // 
            // btnSendMessage
            // 
            btnSendMessage.BackColor = SystemColors.Info;
            btnSendMessage.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSendMessage.Location = new Point(12, 195);
            btnSendMessage.Name = "btnSendMessage";
            btnSendMessage.Size = new Size(204, 59);
            btnSendMessage.TabIndex = 21;
            btnSendMessage.Text = "SendMessage";
            btnSendMessage.UseVisualStyleBackColor = false;
            btnSendMessage.Click += btnSendMessage_Click;
            // 
            // txtClientRecipient
            // 
            txtClientRecipient.Location = new Point(12, 88);
            txtClientRecipient.Multiline = true;
            txtClientRecipient.Name = "txtClientRecipient";
            txtClientRecipient.Size = new Size(131, 29);
            txtClientRecipient.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(9, 68);
            label1.Name = "label1";
            label1.Size = new Size(55, 17);
            label1.TabIndex = 23;
            label1.Text = "Send to";
            // 
            // btnStatus
            // 
            btnStatus.BackColor = Color.Ivory;
            btnStatus.Location = new Point(155, 12);
            btnStatus.Name = "btnStatus";
            btnStatus.Size = new Size(61, 35);
            btnStatus.TabIndex = 24;
            btnStatus.Text = "Status";
            btnStatus.UseVisualStyleBackColor = false;
            btnStatus.Click += btnStatus_Click;
            // 
            // MessageTextBox
            // 
            MessageTextBox.Location = new Point(228, 195);
            MessageTextBox.Multiline = true;
            MessageTextBox.Name = "MessageTextBox";
            MessageTextBox.Size = new Size(166, 65);
            MessageTextBox.TabIndex = 25;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsername.Location = new Point(12, 27);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(0, 20);
            lblUsername.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(88, 17);
            label2.TabIndex = 27;
            label2.Text = "Client Name:";
            // 
            // FormClient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(416, 266);
            Controls.Add(label2);
            Controls.Add(lblUsername);
            Controls.Add(MessageTextBox);
            Controls.Add(btnStatus);
            Controls.Add(label1);
            Controls.Add(txtClientRecipient);
            Controls.Add(btnSendMessage);
            Controls.Add(ChatTextBox);
            Name = "FormClient";
            Text = "Client";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox ChatTextBox;
        private Button btnSendMessage;
        public TextBox txtClientRecipient;
        private Label label1;
        public Button btnStatus;
        public TextBox MessageTextBox;
        public Label lblUsername;
        private Label label2;
    }
}