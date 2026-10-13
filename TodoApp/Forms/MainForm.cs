using TodoApp.Models;

namespace TodoApp
{
    // メインフォームのクラス
    public partial class MainForm : Form
    {
        // フィールド
        // newでインスタンス化
        private readonly List<TodoItem> _items = new(); // 本当のデータ
        // コンストラクタ
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 一覧を表示する処理
        /// </summary>
        // RefreshList()　インスタンスメソッド
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

        private void addButton_Click(object sender, EventArgs e)
        {
            // 指摘3: 空欄のチェック（タイトルが空、またはスペースのみなら処理を中断）
            if (string.IsNullOrWhiteSpace(taskInputTextBox.Text))
            {
                MessageBox.Show("タスク名を入力してください。", "入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // ここで処理を終了（これ以降のコードは実行されない）
            }

            // 指摘2: タブの選択番号（SelectedIndex）から Priority に変換（キャスト）
            Priority selectedPriority = tabControl1.SelectedIndex switch
            {
                0 => Priority.High,   // 「高」タブ（0番目）
                1 => Priority.Middle, // 「中」タブ（1番目）
                2 => Priority.Low,    // 「低」タブ（2番目）
                _ => Priority.Low     // 万が一のデフォルト
            };

            // 画面の入力値から TodoItem のインスタンスを生成
            TodoItem todoItem = new TodoItem
            {
                Title = taskInputTextBox.Text,
                DueDate = dueDateTimePicker.Value,
                CreatedAt = DateTime.Now,
                Priority = selectedPriority,
                Completed = false
            };

            // 指摘1: リスト（_items）に作った todoItem を追加する（★最重要）
            _items.Add(todoItem);

            // 入力欄のクリアと画面の更新
            taskInputTextBox.Clear();
            RefreshList();
        }

    }
}
