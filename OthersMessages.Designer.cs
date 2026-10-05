namespace Final_project
{
    partial class OthersMessages
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
            btnMessageBoard = new Button();
            btnEdit = new Button();
            btnLogOut = new Button();
            txtMessages = new TextBox();
            SuspendLayout();
            // 
            // btnMessageBoard
            // 
            btnMessageBoard.Location = new Point(44, 415);
            btnMessageBoard.Name = "btnMessageBoard";
            btnMessageBoard.Size = new Size(181, 23);
            btnMessageBoard.TabIndex = 0;
            btnMessageBoard.Text = "Message Board";
            btnMessageBoard.UseVisualStyleBackColor = true;
            btnMessageBoard.Click += btnMessageBoard_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(308, 415);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(175, 23);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit Past Messages";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.Location = new Point(582, 415);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(176, 23);
            btnLogOut.TabIndex = 2;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // txtMessages
            // 
            txtMessages.Dock = DockStyle.Top;
            txtMessages.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMessages.Location = new Point(0, 0);
            txtMessages.Multiline = true;
            txtMessages.Name = "txtMessages";
            txtMessages.ReadOnly = true;
            txtMessages.ScrollBars = ScrollBars.Vertical;
            txtMessages.Size = new Size(800, 397);
            txtMessages.TabIndex = 3;
            // 
            // OthersMessages
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtMessages);
            Controls.Add(btnLogOut);
            Controls.Add(btnEdit);
            Controls.Add(btnMessageBoard);
            Name = "OthersMessages";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OthersMessages";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMessageBoard;
        private Button btnEdit;
        private Button btnLogOut;
        private TextBox txtMessages;
    }
}