namespace Lab1Client
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
            BookIDtextBox = new TextBox();
            BookNametextBox = new TextBox();
            AuthortextBox = new TextBox();
            LibralyIDtextBox = new TextBox();
            CommitBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            FindButton = new Button();
            EditButton = new Button();
            DeleteButton = new Button();
            GetAllBtn = new Button();
            richTextBox1 = new RichTextBox();
            label5 = new Label();
            ChatTextBox = new TextBox();
            SendMessageBtn = new Button();
            gRPCCommitBtn = new Button();
            SuspendLayout();
            // 
            // BookIDtextBox
            // 
            BookIDtextBox.Location = new Point(70, 85);
            BookIDtextBox.Name = "BookIDtextBox";
            BookIDtextBox.Size = new Size(212, 23);
            BookIDtextBox.TabIndex = 0;
            // 
            // BookNametextBox
            // 
            BookNametextBox.Location = new Point(70, 149);
            BookNametextBox.Name = "BookNametextBox";
            BookNametextBox.Size = new Size(215, 23);
            BookNametextBox.TabIndex = 1;
            // 
            // AuthortextBox
            // 
            AuthortextBox.Location = new Point(70, 214);
            AuthortextBox.Name = "AuthortextBox";
            AuthortextBox.Size = new Size(212, 23);
            AuthortextBox.TabIndex = 2;
            // 
            // LibralyIDtextBox
            // 
            LibralyIDtextBox.Location = new Point(70, 265);
            LibralyIDtextBox.Name = "LibralyIDtextBox";
            LibralyIDtextBox.Size = new Size(215, 23);
            LibralyIDtextBox.TabIndex = 3;
            // 
            // CommitBtn
            // 
            CommitBtn.Location = new Point(124, 313);
            CommitBtn.Name = "CommitBtn";
            CommitBtn.Size = new Size(120, 23);
            CommitBtn.TabIndex = 4;
            CommitBtn.Text = "Commit";
            CommitBtn.UseVisualStyleBackColor = true;
            CommitBtn.Click += CommitBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(155, 67);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 5;
            label1.Text = "Book ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(155, 131);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 6;
            label2.Text = "Book name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(155, 196);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 7;
            label3.Text = "Author";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(155, 247);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 8;
            label4.Text = "Libraly ID";
            // 
            // FindButton
            // 
            FindButton.Location = new Point(297, 85);
            FindButton.Name = "FindButton";
            FindButton.Size = new Size(75, 23);
            FindButton.TabIndex = 9;
            FindButton.Text = "Find";
            FindButton.UseVisualStyleBackColor = true;
            FindButton.Click += FindButton_Click;
            // 
            // EditButton
            // 
            EditButton.Location = new Point(378, 84);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(75, 23);
            EditButton.TabIndex = 10;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += EditButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(459, 85);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(75, 23);
            DeleteButton.TabIndex = 11;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // GetAllBtn
            // 
            GetAllBtn.Location = new Point(428, 342);
            GetAllBtn.Name = "GetAllBtn";
            GetAllBtn.Size = new Size(75, 23);
            GetAllBtn.TabIndex = 12;
            GetAllBtn.Text = "GetAll";
            GetAllBtn.UseVisualStyleBackColor = true;
            GetAllBtn.Click += GetAllBtn_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(297, 119);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(367, 217);
            richTextBox1.TabIndex = 13;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(802, 77);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 14;
            label5.Text = "Chat";
            // 
            // ChatTextBox
            // 
            ChatTextBox.Location = new Point(751, 119);
            ChatTextBox.Margin = new Padding(2, 2, 2, 2);
            ChatTextBox.Name = "ChatTextBox";
            ChatTextBox.Size = new Size(146, 23);
            ChatTextBox.TabIndex = 15;
            // 
            // SendMessageBtn
            // 
            SendMessageBtn.Location = new Point(785, 159);
            SendMessageBtn.Margin = new Padding(2, 2, 2, 2);
            SendMessageBtn.Name = "SendMessageBtn";
            SendMessageBtn.Size = new Size(78, 20);
            SendMessageBtn.TabIndex = 16;
            SendMessageBtn.Text = "Send";
            SendMessageBtn.UseVisualStyleBackColor = true;
            SendMessageBtn.Click += SendMessageBtn_Click;
            // 
            // gRPCCommitBtn
            // 
            gRPCCommitBtn.Location = new Point(124, 351);
            gRPCCommitBtn.Name = "gRPCCommitBtn";
            gRPCCommitBtn.Size = new Size(118, 25);
            gRPCCommitBtn.TabIndex = 17;
            gRPCCommitBtn.Text = "gRPCCommit";
            gRPCCommitBtn.UseVisualStyleBackColor = true;
            gRPCCommitBtn.Click += gRPCCommitBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 450);
            Controls.Add(gRPCCommitBtn);
            Controls.Add(SendMessageBtn);
            Controls.Add(ChatTextBox);
            Controls.Add(label5);
            Controls.Add(richTextBox1);
            Controls.Add(GetAllBtn);
            Controls.Add(DeleteButton);
            Controls.Add(EditButton);
            Controls.Add(FindButton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(CommitBtn);
            Controls.Add(LibralyIDtextBox);
            Controls.Add(AuthortextBox);
            Controls.Add(BookNametextBox);
            Controls.Add(BookIDtextBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox BookIDtextBox;
        private TextBox BookNametextBox;
        private TextBox AuthortextBox;
        private TextBox LibralyIDtextBox;
        private Button CommitBtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button FindButton;
        private Button EditButton;
        private Button DeleteButton;
        private Button GetAllBtn;
        private RichTextBox richTextBox1;
        private Label label5;
        private TextBox ChatTextBox;
        private Button SendMessageBtn;
        private Button gRPCCommitBtn;
    }
}
