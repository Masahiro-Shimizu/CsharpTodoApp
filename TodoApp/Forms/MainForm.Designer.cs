namespace TodoApp
{
    partial class MainForm
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
            editButton = new Button();
            inputFormLabel = new Label();
            addButton = new Button();
            deleteButton = new Button();
            taskInputTextBox = new TextBox();
            dueDateLabel = new Label();
            dueDateTimePicker = new DateTimePicker();
            selectedTaskLabel = new Label();
            txtSelectedTextBox = new TextBox();
            txtCreatedAtLabel = new Label();
            txtDueLabel = new Label();
            createdAtDateTimePicker = new DateTimePicker();
            dueDateTimePicker1 = new DateTimePicker();
            taskListLabel = new Label();
            openButton = new Button();
            tabControl1 = new TabControl();
            highTabPage = new TabPage();
            highListBox = new ListBox();
            middleTabPage = new TabPage();
            middleListBox = new ListBox();
            lowTabPage = new TabPage();
            lowListBox = new ListBox();
            tabControl1.SuspendLayout();
            highTabPage.SuspendLayout();
            middleTabPage.SuspendLayout();
            lowTabPage.SuspendLayout();
            SuspendLayout();
            // 
            // editButton
            // 
            editButton.Location = new Point(66, 25);
            editButton.Margin = new Padding(2, 1, 2, 1);
            editButton.Name = "editButton";
            editButton.Size = new Size(48, 27);
            editButton.TabIndex = 2;
            editButton.Text = "編集";
            editButton.UseVisualStyleBackColor = true;
            // 
            // inputFormLabel
            // 
            inputFormLabel.AutoSize = true;
            inputFormLabel.Location = new Point(6, 8);
            inputFormLabel.Margin = new Padding(2, 0, 2, 0);
            inputFormLabel.Name = "inputFormLabel";
            inputFormLabel.Size = new Size(64, 15);
            inputFormLabel.TabIndex = 0;
            inputFormLabel.Text = "入力フォーム";
            // 
            // addButton
            // 
            addButton.Location = new Point(10, 25);
            addButton.Margin = new Padding(2, 1, 2, 1);
            addButton.Name = "addButton";
            addButton.Size = new Size(45, 27);
            addButton.TabIndex = 1;
            addButton.Text = "追加";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(126, 25);
            deleteButton.Margin = new Padding(2, 1, 2, 1);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(48, 27);
            deleteButton.TabIndex = 3;
            deleteButton.Text = "削除";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // taskInputTextBox
            // 
            taskInputTextBox.Location = new Point(12, 60);
            taskInputTextBox.Margin = new Padding(2, 1, 2, 1);
            taskInputTextBox.Multiline = true;
            taskInputTextBox.Name = "taskInputTextBox";
            taskInputTextBox.Size = new Size(316, 124);
            taskInputTextBox.TabIndex = 4;
            // 
            // dueDateLabel
            // 
            dueDateLabel.AutoSize = true;
            dueDateLabel.Location = new Point(10, 189);
            dueDateLabel.Margin = new Padding(2, 0, 2, 0);
            dueDateLabel.Name = "dueDateLabel";
            dueDateLabel.Size = new Size(31, 15);
            dueDateLabel.TabIndex = 5;
            dueDateLabel.Text = "期日";
            // 
            // dueDateTimePicker
            // 
            dueDateTimePicker.Location = new Point(64, 189);
            dueDateTimePicker.Margin = new Padding(2, 1, 2, 1);
            dueDateTimePicker.Name = "dueDateTimePicker";
            dueDateTimePicker.Size = new Size(265, 23);
            dueDateTimePicker.TabIndex = 6;
            // 
            // selectedTaskLabel
            // 
            selectedTaskLabel.AutoSize = true;
            selectedTaskLabel.Location = new Point(12, 217);
            selectedTaskLabel.Margin = new Padding(2, 0, 2, 0);
            selectedTaskLabel.Name = "selectedTaskLabel";
            selectedTaskLabel.Size = new Size(80, 15);
            selectedTaskLabel.TabIndex = 7;
            selectedTaskLabel.Text = "選択中のタスク";
            // 
            // txtSelectedTextBox
            // 
            txtSelectedTextBox.Location = new Point(12, 233);
            txtSelectedTextBox.Margin = new Padding(2, 1, 2, 1);
            txtSelectedTextBox.Multiline = true;
            txtSelectedTextBox.Name = "txtSelectedTextBox";
            txtSelectedTextBox.Size = new Size(316, 120);
            txtSelectedTextBox.TabIndex = 8;
            // 
            // txtCreatedAtLabel
            // 
            txtCreatedAtLabel.AutoSize = true;
            txtCreatedAtLabel.Location = new Point(10, 355);
            txtCreatedAtLabel.Margin = new Padding(2, 0, 2, 0);
            txtCreatedAtLabel.Name = "txtCreatedAtLabel";
            txtCreatedAtLabel.Size = new Size(43, 15);
            txtCreatedAtLabel.TabIndex = 9;
            txtCreatedAtLabel.Text = "入力日";
            // 
            // txtDueLabel
            // 
            txtDueLabel.AutoSize = true;
            txtDueLabel.Location = new Point(12, 386);
            txtDueLabel.Margin = new Padding(2, 0, 2, 0);
            txtDueLabel.Name = "txtDueLabel";
            txtDueLabel.Size = new Size(31, 15);
            txtDueLabel.TabIndex = 10;
            txtDueLabel.Text = "期日";
            // 
            // createdAtDateTimePicker
            // 
            createdAtDateTimePicker.Location = new Point(69, 354);
            createdAtDateTimePicker.Margin = new Padding(2, 1, 2, 1);
            createdAtDateTimePicker.Name = "createdAtDateTimePicker";
            createdAtDateTimePicker.Size = new Size(260, 23);
            createdAtDateTimePicker.TabIndex = 11;
            // 
            // dueDateTimePicker1
            // 
            dueDateTimePicker1.Location = new Point(68, 386);
            dueDateTimePicker1.Margin = new Padding(2, 1, 2, 1);
            dueDateTimePicker1.Name = "dueDateTimePicker1";
            dueDateTimePicker1.Size = new Size(261, 23);
            dueDateTimePicker1.TabIndex = 12;
            // 
            // taskListLabel
            // 
            taskListLabel.AutoSize = true;
            taskListLabel.Location = new Point(355, 11);
            taskListLabel.Margin = new Padding(2, 0, 2, 0);
            taskListLabel.Name = "taskListLabel";
            taskListLabel.Size = new Size(58, 15);
            taskListLabel.TabIndex = 13;
            taskListLabel.Text = "タスク一覧";
            // 
            // openButton
            // 
            openButton.Location = new Point(729, 9);
            openButton.Margin = new Padding(2, 1, 2, 1);
            openButton.Name = "openButton";
            openButton.Size = new Size(43, 19);
            openButton.TabIndex = 14;
            openButton.Text = "開く";
            openButton.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(highTabPage);
            tabControl1.Controls.Add(middleTabPage);
            tabControl1.Controls.Add(lowTabPage);
            tabControl1.Location = new Point(355, 33);
            tabControl1.Margin = new Padding(2, 1, 2, 1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(429, 388);
            tabControl1.TabIndex = 15;
            // 
            // highTabPage
            // 
            highTabPage.AutoScroll = true;
            highTabPage.Controls.Add(highListBox);
            highTabPage.Location = new Point(4, 24);
            highTabPage.Margin = new Padding(2, 1, 2, 1);
            highTabPage.Name = "highTabPage";
            highTabPage.Padding = new Padding(2, 1, 2, 1);
            highTabPage.Size = new Size(421, 360);
            highTabPage.TabIndex = 0;
            highTabPage.Text = "高";
            highTabPage.UseVisualStyleBackColor = true;
            // 
            // highListBox
            // 
            highListBox.FormattingEnabled = true;
            highListBox.ItemHeight = 15;
            highListBox.Location = new Point(-4, 0);
            highListBox.Margin = new Padding(2, 1, 2, 1);
            highListBox.Name = "highListBox";
            highListBox.Size = new Size(422, 364);
            highListBox.TabIndex = 16;
            highListBox.SelectedIndexChanged += highListBox_SelectedIndexChanged;
            // 
            // middleTabPage
            // 
            middleTabPage.Controls.Add(middleListBox);
            middleTabPage.Location = new Point(4, 24);
            middleTabPage.Margin = new Padding(2, 1, 2, 1);
            middleTabPage.Name = "middleTabPage";
            middleTabPage.Padding = new Padding(2, 1, 2, 1);
            middleTabPage.Size = new Size(421, 360);
            middleTabPage.TabIndex = 1;
            middleTabPage.Text = "中";
            middleTabPage.UseVisualStyleBackColor = true;
            // 
            // middleListBox
            // 
            middleListBox.Dock = DockStyle.Fill;
            middleListBox.FormattingEnabled = true;
            middleListBox.ItemHeight = 15;
            middleListBox.Location = new Point(2, 1);
            middleListBox.Margin = new Padding(2, 1, 2, 1);
            middleListBox.Name = "middleListBox";
            middleListBox.Size = new Size(417, 358);
            middleListBox.TabIndex = 0;
            middleListBox.SelectedIndexChanged += middleListBox_SelectedIndexChanged;
            // 
            // lowTabPage
            // 
            lowTabPage.Controls.Add(lowListBox);
            lowTabPage.Location = new Point(4, 24);
            lowTabPage.Margin = new Padding(2, 1, 2, 1);
            lowTabPage.Name = "lowTabPage";
            lowTabPage.Size = new Size(421, 360);
            lowTabPage.TabIndex = 2;
            lowTabPage.Text = "低";
            lowTabPage.UseVisualStyleBackColor = true;
            // 
            // lowListBox
            // 
            lowListBox.Dock = DockStyle.Fill;
            lowListBox.FormattingEnabled = true;
            lowListBox.ItemHeight = 15;
            lowListBox.Location = new Point(0, 0);
            lowListBox.Margin = new Padding(2, 1, 2, 1);
            lowListBox.Name = "lowListBox";
            lowListBox.Size = new Size(421, 360);
            lowListBox.TabIndex = 0;
            lowListBox.SelectedIndexChanged += lowListBox_SelectedIndexChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 432);
            Controls.Add(tabControl1);
            Controls.Add(openButton);
            Controls.Add(taskListLabel);
            Controls.Add(dueDateTimePicker1);
            Controls.Add(createdAtDateTimePicker);
            Controls.Add(txtDueLabel);
            Controls.Add(txtCreatedAtLabel);
            Controls.Add(txtSelectedTextBox);
            Controls.Add(selectedTaskLabel);
            Controls.Add(dueDateTimePicker);
            Controls.Add(dueDateLabel);
            Controls.Add(taskInputTextBox);
            Controls.Add(deleteButton);
            Controls.Add(editButton);
            Controls.Add(addButton);
            Controls.Add(inputFormLabel);
            Margin = new Padding(2, 1, 2, 1);
            Name = "MainForm";
            Text = "ToDoアプリ";
            tabControl1.ResumeLayout(false);
            highTabPage.ResumeLayout(false);
            middleTabPage.ResumeLayout(false);
            lowTabPage.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label inputFormLabel;
        private Button addButton;
        private Button deleteButton;
        private TextBox taskInputTextBox;
        private Label dueDateLabel;
        private DateTimePicker dueDateTimePicker;
        private Label selectedTaskLabel;
        private TextBox txtSelectedTextBox;
        private Label txtCreatedAtLabel;
        private Label txtDueLabel;
        private DateTimePicker createdAtDateTimePicker;
        private DateTimePicker dueDateTimePicker1;
        private Label taskListLabel;
        private Button openButton;
        private TabControl tabControl1;
        private TabPage highTabPage;
        private TabPage middleTabPage;
        private TabPage lowTabPage;
        private ListBox highListBox;
        private ListBox middleListBox;
        private ListBox lowListBox;
        private Button editButton;
    }
}
