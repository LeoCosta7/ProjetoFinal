namespace ConnectMeClients
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtClientName = new TextBox();
            btnCreateClient = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 9;
            label1.Text = "Client Name";
            // 
            // txtClientName
            // 
            txtClientName.Location = new Point(12, 42);
            txtClientName.Multiline = true;
            txtClientName.Name = "txtClientName";
            txtClientName.Size = new Size(155, 28);
            txtClientName.TabIndex = 10;
            // 
            // btnCreateClient
            // 
            btnCreateClient.BackColor = SystemColors.Info;
            btnCreateClient.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreateClient.Location = new Point(12, 76);
            btnCreateClient.Name = "btnCreateClient";
            btnCreateClient.Size = new Size(155, 33);
            btnCreateClient.TabIndex = 11;
            btnCreateClient.Text = "Create a client";
            btnCreateClient.UseVisualStyleBackColor = false;
            btnCreateClient.Click += btnCreateClient_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(220, 129);
            Controls.Add(btnCreateClient);
            Controls.Add(txtClientName);
            Controls.Add(label1);
            Name = "Form1";
            Text = "ConectMeClients";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox txtClientName;
        private Button btnCreateClient;
    }
}