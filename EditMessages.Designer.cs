namespace Final_project
{
    partial class EditMessages
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
            btnLogOut = new Button();
            btnOthersMessages = new Button();
            btnMessageBoard = new Button();
            lbPastMessages = new ListBox();
            txtEditMessage = new TextBox();
            btnUpdate = new Button();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // btnLogOut
            // 
            btnLogOut.Location = new Point(581, 415);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(176, 23);
            btnLogOut.TabIndex = 5;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // btnOthersMessages
            // 
            btnOthersMessages.Location = new Point(307, 415);
            btnOthersMessages.Name = "btnOthersMessages";
            btnOthersMessages.Size = new Size(175, 23);
            btnOthersMessages.TabIndex = 4;
            btnOthersMessages.Text = "View other users Messages";
            btnOthersMessages.UseVisualStyleBackColor = true;
            btnOthersMessages.Click += btnOthersMessages_Click;
            // 
            // btnMessageBoard
            // 
            btnMessageBoard.Location = new Point(43, 415);
            btnMessageBoard.Name = "btnMessageBoard";
            btnMessageBoard.Size = new Size(181, 23);
            btnMessageBoard.TabIndex = 3;
            btnMessageBoard.Text = "Message Board";
            btnMessageBoard.UseVisualStyleBackColor = true;
            btnMessageBoard.Click += btnMessageBoard_Click;
            // 
            // lbPastMessages
            // 
            lbPastMessages.FormattingEnabled = true;
            lbPastMessages.Location = new Point(35, 23);
            lbPastMessages.Name = "lbPastMessages";
            lbPastMessages.Size = new Size(736, 214);
            lbPastMessages.TabIndex = 6;
            lbPastMessages.SelectedIndexChanged += lbPastMessages_SelectedIndexChanged;
            // 
            // txtEditMessage
            // 
            txtEditMessage.AcceptsReturn = true;
            txtEditMessage.Location = new Point(35, 254);
            txtEditMessage.Multiline = true;
            txtEditMessage.Name = "txtEditMessage";
            txtEditMessage.ScrollBars = ScrollBars.Vertical;
            txtEditMessage.Size = new Size(736, 70);
            txtEditMessage.TabIndex = 7;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(696, 341);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update Messages";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(593, 341);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // EditMessages
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(txtEditMessage);
            Controls.Add(lbPastMessages);
            Controls.Add(btnLogOut);
            Controls.Add(btnOthersMessages);
            Controls.Add(btnMessageBoard);
            Name = "EditMessages";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditMessages";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogOut;
        private Button btnOthersMessages;
        private Button btnMessageBoard;
        private ListBox lbPastMessages;
        private TextBox txtEditMessage;
        private Button btnUpdate;
        private Button btnDelete;
    }
}