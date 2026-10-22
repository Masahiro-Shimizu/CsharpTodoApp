using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TodoApp.Models;

namespace TodoApp.Forms
{
    public partial class EditForm : Form
    {
        private readonly TodoItem _item;

        public EditForm(TodoItem item)
        {
            InitializeComponent();
            _item = item;

            titleTextBox.Text = _item.Title;
            dueDateTimePicker.Value = _item.DueDate;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(titleTextBox.Text))
            {
                MessageBox.Show("タスク名を入力してください。", "入力エラー",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _item.Title = titleTextBox.Text;
            _item.DueDate = dueDateTimePicker.Value;

            DialogResult = DialogResult.OK;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}