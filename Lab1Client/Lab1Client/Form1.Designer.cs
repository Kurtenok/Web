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
            SuspendLayout();
            // 
            // BookIDtextBox
            // 
            BookIDtextBox.Location = new Point(100, 142);
            BookIDtextBox.Margin = new Padding(4, 5, 4, 5);
            BookIDtextBox.Name = "BookIDtextBox";
            BookIDtextBox.Size = new Size(301, 31);
            BookIDtextBox.TabIndex = 0;
            // 
            // BookNametextBox
            // 
            BookNametextBox.Location = new Point(100, 248);
            BookNametextBox.Margin = new Padding(4, 5, 4, 5);
            BookNametextBox.Name = "BookNametextBox";
            BookNametextBox.Size = new Size(305, 31);
            BookNametextBox.TabIndex = 1;
            // 
            // AuthortextBox
            // 
            AuthortextBox.Location = new Point(100, 357);
            AuthortextBox.Margin = new Padding(4, 5, 4, 5);
            AuthortextBox.Name = "AuthortextBox";
            AuthortextBox.Size = new Size(301, 31);
            AuthortextBox.TabIndex = 2;
            // 
            // LibralyIDtextBox
            // 
            LibralyIDtextBox.Location = new Point(100, 442);
            LibralyIDtextBox.Margin = new Padding(4, 5, 4, 5);
            LibralyIDtextBox.Name = "LibralyIDtextBox";
            LibralyIDtextBox.Size = new Size(305, 31);
            LibralyIDtextBox.TabIndex = 3;
            // 
            // CommitBtn
            // 
            CommitBtn.Location = new Point(177, 522);
            CommitBtn.Margin = new Padding(4, 5, 4, 5);
            CommitBtn.Name = "CommitBtn";
            CommitBtn.Size = new Size(171, 38);
            CommitBtn.TabIndex = 4;
            CommitBtn.Text = "Commit";
            CommitBtn.UseVisualStyleBackColor = true;
            CommitBtn.Click += CommitBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(221, 112);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(76, 25);
            label1.TabIndex = 5;
            label1.Text = "Book ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(221, 218);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(102, 25);
            label2.TabIndex = 6;
            label2.Text = "Book name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(221, 327);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(67, 25);
            label3.TabIndex = 7;
            label3.Text = "Author";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(221, 412);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(86, 25);
            label4.TabIndex = 8;
            label4.Text = "Libraly ID";
            // 
            // FindButton
            // 
            FindButton.Location = new Point(424, 142);
            FindButton.Margin = new Padding(4, 5, 4, 5);
            FindButton.Name = "FindButton";
            FindButton.Size = new Size(107, 38);
            FindButton.TabIndex = 9;
            FindButton.Text = "Find";
            FindButton.UseVisualStyleBackColor = true;
            FindButton.Click += FindButton_Click;
            // 
            // EditButton
            // 
            EditButton.Location = new Point(540, 140);
            EditButton.Margin = new Padding(4, 5, 4, 5);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(107, 38);
            EditButton.TabIndex = 10;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += EditButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(656, 142);
            DeleteButton.Margin = new Padding(4, 5, 4, 5);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(107, 38);
            DeleteButton.TabIndex = 11;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // GetAllBtn
            // 
            GetAllBtn.Location = new Point(611, 570);
            GetAllBtn.Margin = new Padding(4, 5, 4, 5);
            GetAllBtn.Name = "GetAllBtn";
            GetAllBtn.Size = new Size(107, 38);
            GetAllBtn.TabIndex = 12;
            GetAllBtn.Text = "GetAll";
            GetAllBtn.UseVisualStyleBackColor = true;
            GetAllBtn.Click += GetAllBtn_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(424, 198);
            richTextBox1.Margin = new Padding(4, 5, 4, 5);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(523, 359);
            richTextBox1.TabIndex = 13;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1146, 129);
            label5.Name = "label5";
            label5.Size = new Size(48, 25);
            label5.TabIndex = 14;
            label5.Text = "Chat";
            // 
            // ChatTextBox
            // 
            ChatTextBox.Location = new Point(1073, 198);
            ChatTextBox.Name = "ChatTextBox";
            ChatTextBox.Size = new Size(207, 31);
            ChatTextBox.TabIndex = 15;
            // 
            // SendMessageBtn
            // 
            SendMessageBtn.Location = new Point(1121, 265);
            SendMessageBtn.Name = "SendMessageBtn";
            SendMessageBtn.Size = new Size(112, 34);
            SendMessageBtn.TabIndex = 16;
            SendMessageBtn.Text = "Send";
            SendMessageBtn.UseVisualStyleBackColor = true;
            SendMessageBtn.Click += SendMessageBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1314, 750);
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
            Margin = new Padding(4, 5, 4, 5);
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
    }
}
