namespace Final_project
{
    partial class MessageBoard
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
            txtMessage = new TextBox();
            btnSendMessage = new Button();
            lbPastMessages = new ListBox();
            lblWarning = new Label();
            btnEdit = new Button();
            btnOthersMessages = new Button();
            btnLogOut = new Button();
            SuspendLayout();
            // 
            // txtMessage
            // 
            txtMessage.AcceptsReturn = true;
            txtMessage.Location = new Point(38, 264);
            txtMessage.Multiline = true;
            txtMessage.Name = "txtMessage";
            txtMessage.ScrollBars = ScrollBars.Vertical;
            txtMessage.Size = new Size(727, 90);
            txtMessage.TabIndex = 0;
            // 
            // btnSendMessage
            // 
            btnSendMessage.Location = new Point(690, 374);
            btnSendMessage.Name = "btnSendMessage";
            btnSendMessage.Size = new Size(75, 32);
            btnSendMessage.TabIndex = 1;
            btnSendMessage.Text = "Send";
            btnSendMessage.UseVisualStyleBackColor = true;
            btnSendMessage.Click += btnSendMessage_Click;
            // 
            // lbPastMessages
            // 
            lbPastMessages.FormattingEnabled = true;
            lbPastMessages.Location = new Point(38, 9);
            lbPastMessages.Name = "lbPastMessages";
            lbPastMessages.Size = new Size(727, 244);
            lbPastMessages.TabIndex = 2;
            // 
            // lblWarning
            // 
            lblWarning.AutoSize = true;
            lblWarning.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblWarning.Location = new Point(48, 238);
            lblWarning.Name = "lblWarning";
            lblWarning.Size = new Size(0, 21);
            lblWarning.TabIndex = 3;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(91, 426);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(176, 23);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "Edit Past Messages";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnOthersMessages
            // 
            btnOthersMessages.Location = new Point(338, 426);
            btnOthersMessages.Name = "btnOthersMessages";
            btnOthersMessages.Size = new Size(179, 23);
            btnOthersMessages.TabIndex = 5;
            btnOthersMessages.Text = "View other users messages";
            btnOthersMessages.UseVisualStyleBackColor = true;
            btnOthersMessages.Click += btnOthersMessages_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.Location = new Point(603, 426);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(162, 23);
            btnLogOut.TabIndex = 6;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // MessageBoard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogOut);
            Controls.Add(btnOthersMessages);
            Controls.Add(btnEdit);
            Controls.Add(lblWarning);
            Controls.Add(lbPastMessages);
            Controls.Add(btnSendMessage);
            Controls.Add(txtMessage);
            Name = "MessageBoard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MessageBoard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMessage;
        private Button btnSendMessage;
        private ListBox lbPastMessages;
        private Label lblWarning;
        private Button btnEdit;
        private Button btnOthersMessages;
        private Button btnLogOut;
    }
}