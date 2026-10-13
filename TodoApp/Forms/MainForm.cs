using TodoApp.Models;

namespace TodoApp
{
    public partial class MainForm : Form
    {
        private readonly List<TodoItem> _items = new(); // 本当のデータ
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 一覧を表示する処理
        /// </summary>
        private void RefreshList()
        {
            // 各リストボックスの初期化
            highListBox.Items.Clear();
            middleListBox.Items.Clear();
            lowListBox.Items.Clear();

            foreach (var item in _items)
            {
                switch (item.Priority)
                {
                    case Priority.High: highListBox.Items.Add(item); break;
                    case Priority.Middle: middleListBox.Items.Add(item); break;
                    case Priority.Low: lowListBox.Items.Add(item); break;
                }
            }
        }
    }
}
