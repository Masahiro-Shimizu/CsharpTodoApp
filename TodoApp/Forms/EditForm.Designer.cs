namespace TodoApp.Forms
{
    partial class EditForm
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
            titleNameLabel = new Label();
            titleTextBox = new TextBox();
            priorityLabel = new Label();
            comboBox1 = new ComboBox();
            dueDateTimeLabel = new Label();
            dueDateTimePicker = new DateTimePicker();
            doneCheckBox = new CheckBox();
            createdAtLabel = new Label();
            createdAtTextBox = new TextBox();
            okButton = new Button();
            cancelButton = new Button();
            SuspendLayout();
            // 
            // titleNameLabel
            // 
            titleNameLabel.AutoSize = true;
            titleNameLabel.Location = new Point(12, 9);
            titleNameLabel.Name = "titleNameLabel";
            titleNameLabel.Size = new Size(86, 32);
            titleNameLabel.TabIndex = 0;
            titleNameLabel.Text = "タイトル";
            // 
            // titleTextBox
            // 
            titleTextBox.Location = new Point(12, 44);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(1020, 39);
            titleTextBox.TabIndex = 1;
            // 
            // priorityLabel
            // 
            priorityLabel.AutoSize = true;
            priorityLabel.Location = new Point(12, 103);
            priorityLabel.Name = "priorityLabel";
            priorityLabel.Size = new Size(86, 32);
            priorityLabel.TabIndex = 2;
            priorityLabel.Text = "優先度";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 144);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(494, 40);
            comboBox1.TabIndex = 3;
            // 
            // dueDateTimeLabel
            // 
            dueDateTimeLabel.AutoSize = true;
            dueDateTimeLabel.Location = new Point(541, 103);
            dueDateTimeLabel.Name = "dueDateTimeLabel";
            dueDateTimeLabel.Size = new Size(62, 32);
            dueDateTimeLabel.TabIndex = 4;
            dueDateTimeLabel.Text = "期日";
            // 
            // dueDateTimePicker
            // 
            dueDateTimePicker.Location = new Point(541, 145);
            dueDateTimePicker.Name = "dueDateTimePicker";
            dueDateTimePicker.Size = new Size(491, 39);
            dueDateTimePicker.TabIndex = 5;
            // 
            // doneCheckBox
            // 
            doneCheckBox.AutoSize = true;
            doneCheckBox.Location = new Point(12, 207);
            doneCheckBox.Name = "doneCheckBox";
            doneCheckBox.Size = new Size(151, 36);
            doneCheckBox.TabIndex = 6;
            doneCheckBox.Text = "完了にする";
            doneCheckBox.UseVisualStyleBackColor = true;
            // 
            // createdAtLabel
            // 
            createdAtLabel.AutoSize = true;
            createdAtLabel.Location = new Point(14, 271);
            createdAtLabel.Name = "createdAtLabel";
            createdAtLabel.Size = new Size(86, 32);
            createdAtLabel.TabIndex = 7;
            createdAtLabel.Text = "入力日";
            // 
            // createdAtTextBox
            // 
            createdAtTextBox.Location = new Point(134, 268);
            createdAtTextBox.Name = "createdAtTextBox";
            createdAtTextBox.ReadOnly = true;
            createdAtTextBox.Size = new Size(898, 39);
            createdAtTextBox.TabIndex = 8;
            // 
            // okButton
            // 
            okButton.Location = new Point(724, 597);
            okButton.Name = "okButton";
            okButton.Size = new Size(141, 57);
            okButton.TabIndex = 9;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(904, 592);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(128, 67);
            cancelButton.TabIndex = 10;
            cancelButton.Text = "キャンセル";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // EditForm
            // 
            AcceptButton = okButton;
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = cancelButton;
            ClientSize = new Size(1060, 690);
            Controls.Add(cancelButton);
            Controls.Add(okButton);
            Controls.Add(createdAtTextBox);
            Controls.Add(createdAtLabel);
            Controls.Add(doneCheckBox);
            Controls.Add(dueDateTimePicker);
            Controls.Add(dueDateTimeLabel);
            Controls.Add(comboBox1);
            Controls.Add(priorityLabel);
            Controls.Add(titleTextBox);
            Controls.Add(titleNameLabel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "タスクの編集";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleNameLabel;
        private TextBox titleTextBox;
        private Label priorityLabel;
        private ComboBox comboBox1;
        private Label dueDateTimeLabel;
        private DateTimePicker dueDateTimePicker;
        private CheckBox doneCheckBox;
        private Label createdAtLabel;
        private TextBox createdAtTextBox;
        private Button okButton;
        private Button cancelButton;
    }
}