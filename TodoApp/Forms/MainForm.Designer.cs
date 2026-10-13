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
            Button editButton;
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
            editButton = new Button();
            tabControl1.SuspendLayout();
            highTabPage.SuspendLayout();
            middleTabPage.SuspendLayout();
            lowTabPage.SuspendLayout();
            SuspendLayout();
            // 
            // editButton
            // 
            editButton.Location = new Point(122, 53);
            editButton.Name = "editButton";
            editButton.Size = new Size(89, 58);
            editButton.TabIndex = 2;
            editButton.Text = "編集";
            editButton.UseVisualStyleBackColor = true;
            // 
            // inputFormLabel
            // 
            inputFormLabel.AutoSize = true;
            inputFormLabel.Location = new Point(12, 18);
            inputFormLabel.Name = "inputFormLabel";
            inputFormLabel.Size = new Size(128, 32);
            inputFormLabel.TabIndex = 0;
            inputFormLabel.Text = "入力フォーム";
            // 
            // addButton
            // 
            addButton.Location = new Point(18, 53);
            addButton.Name = "addButton";
            addButton.Size = new Size(84, 58);
            addButton.TabIndex = 1;
            addButton.Text = "追加";
            addButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(234, 53);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(90, 58);
            deleteButton.TabIndex = 3;
            deleteButton.Text = "削除";
            deleteButton.UseVisualStyleBackColor = true;
            // 
            // taskInputTextBox
            // 
            taskInputTextBox.Location = new Point(23, 129);
            taskInputTextBox.Multiline = true;
            taskInputTextBox.Name = "taskInputTextBox";
            taskInputTextBox.Size = new Size(584, 260);
            taskInputTextBox.TabIndex = 4;
            // 
            // dueDateLabel
            // 
            dueDateLabel.AutoSize = true;
            dueDateLabel.Location = new Point(18, 403);
            dueDateLabel.Name = "dueDateLabel";
            dueDateLabel.Size = new Size(62, 32);
            dueDateLabel.TabIndex = 5;
            dueDateLabel.Text = "期日";
            // 
            // dueDateTimePicker
            // 
            dueDateTimePicker.Location = new Point(118, 403);
            dueDateTimePicker.Name = "dueDateTimePicker";
            dueDateTimePicker.Size = new Size(489, 39);
            dueDateTimePicker.TabIndex = 6;
            // 
            // selectedTaskLabel
            // 
            selectedTaskLabel.AutoSize = true;
            selectedTaskLabel.Location = new Point(23, 463);
            selectedTaskLabel.Name = "selectedTaskLabel";
            selectedTaskLabel.Size = new Size(160, 32);
            selectedTaskLabel.TabIndex = 7;
            selectedTaskLabel.Text = "選択中のタスク";
            // 
            // txtSelectedTextBox
            // 
            txtSelectedTextBox.Location = new Point(23, 498);
            txtSelectedTextBox.Multiline = true;
            txtSelectedTextBox.Name = "txtSelectedTextBox";
            txtSelectedTextBox.Size = new Size(584, 252);
            txtSelectedTextBox.TabIndex = 8;
            // 
            // txtCreatedAtLabel
            // 
            txtCreatedAtLabel.AutoSize = true;
            txtCreatedAtLabel.Location = new Point(18, 757);
            txtCreatedAtLabel.Name = "txtCreatedAtLabel";
            txtCreatedAtLabel.Size = new Size(86, 32);
            txtCreatedAtLabel.TabIndex = 9;
            txtCreatedAtLabel.Text = "入力日";
            // 
            // txtDueLabel
            // 
            txtDueLabel.AutoSize = true;
            txtDueLabel.Location = new Point(22, 823);
            txtDueLabel.Name = "txtDueLabel";
            txtDueLabel.Size = new Size(62, 32);
            txtDueLabel.TabIndex = 10;
            txtDueLabel.Text = "期日";
            // 
            // createdAtDateTimePicker
            // 
            createdAtDateTimePicker.Location = new Point(128, 756);
            createdAtDateTimePicker.Name = "createdAtDateTimePicker";
            createdAtDateTimePicker.Size = new Size(479, 39);
            createdAtDateTimePicker.TabIndex = 11;
            // 
            // dueDateTimePicker1
            // 
            dueDateTimePicker1.Location = new Point(126, 823);
            dueDateTimePicker1.Name = "dueDateTimePicker1";
            dueDateTimePicker1.Size = new Size(481, 39);
            dueDateTimePicker1.TabIndex = 12;
            // 
            // taskListLabel
            // 
            taskListLabel.AutoSize = true;
            taskListLabel.Location = new Point(660, 23);
            taskListLabel.Name = "taskListLabel";
            taskListLabel.Size = new Size(116, 32);
            taskListLabel.TabIndex = 13;
            taskListLabel.Text = "タスク一覧";
            // 
            // openButton
            // 
            openButton.Location = new Point(1353, 19);
            openButton.Name = "openButton";
            openButton.Size = new Size(79, 40);
            openButton.TabIndex = 14;
            openButton.Text = "開く";
            openButton.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(highTabPage);
            tabControl1.Controls.Add(middleTabPage);
            tabControl1.Controls.Add(lowTabPage);
            tabControl1.Location = new Point(660, 70);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(796, 828);
            tabControl1.TabIndex = 15;
            // 
            // highTabPage
            // 
            highTabPage.AutoScroll = true;
            highTabPage.Controls.Add(highListBox);
            highTabPage.Location = new Point(8, 46);
            highTabPage.Name = "highTabPage";
            highTabPage.Padding = new Padding(3);
            highTabPage.Size = new Size(780, 774);
            highTabPage.TabIndex = 0;
            highTabPage.Text = "高";
            highTabPage.UseVisualStyleBackColor = true;
            // 
            // highListBox
            // 
            highListBox.FormattingEnabled = true;
            highListBox.Location = new Point(0, 0);
            highListBox.Name = "highListBox";
            highListBox.Size = new Size(780, 772);
            highListBox.TabIndex = 16;
            // 
            // middleTabPage
            // 
            middleTabPage.Controls.Add(middleListBox);
            middleTabPage.Location = new Point(8, 46);
            middleTabPage.Name = "middleTabPage";
            middleTabPage.Padding = new Padding(3);
            middleTabPage.Size = new Size(780, 774);
            middleTabPage.TabIndex = 1;
            middleTabPage.Text = "中";
            middleTabPage.UseVisualStyleBackColor = true;
            // 
            // middleListBox
            // 
            middleListBox.Dock = DockStyle.Fill;
            middleListBox.FormattingEnabled = true;
            middleListBox.Location = new Point(3, 3);
            middleListBox.Name = "middleListBox";
            middleListBox.Size = new Size(774, 768);
            middleListBox.TabIndex = 0;
            // 
            // lowTabPage
            // 
            lowTabPage.Controls.Add(lowListBox);
            lowTabPage.Location = new Point(8, 46);
            lowTabPage.Name = "lowTabPage";
            lowTabPage.Size = new Size(780, 774);
            lowTabPage.TabIndex = 2;
            lowTabPage.Text = "低";
            lowTabPage.UseVisualStyleBackColor = true;
            // 
            // lowListBox
            // 
            lowListBox.Dock = DockStyle.Fill;
            lowListBox.FormattingEnabled = true;
            lowListBox.Location = new Point(0, 0);
            lowListBox.Name = "lowListBox";
            lowListBox.Size = new Size(780, 774);
            lowListBox.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1468, 921);
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
            Name = "Form1";
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
    }
}
