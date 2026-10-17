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

        // 追加ボタンを押したときの処理
        private void addButton_Click(object sender, EventArgs e)
        {
            // 空欄のチェック（タイトルが空、またはスペースのみなら処理を中断）
            //もし、未入力かスペースがタスク入力欄に入力されていたら
            if (string.IsNullOrWhiteSpace(taskInputTextBox.Text))
            {
                // メッセージボックスを表示する　OKが押されるまで待機する
                MessageBox.Show("タスク名を入力してください。", "入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // ここで処理を終了（これ以降のコードは実行されない）
            }

            // switch式で番号から対応する優先度を決める
            Priority selectedPriority = tabControl1.SelectedIndex switch
            {
                0 => Priority.High,   // 「高」タブ（0番目）
                1 => Priority.Middle, // 「中」タブ（1番目）
                2 => Priority.Low,    // 「低」タブ（2番目）
                // 通らないけど書いておかないと困る
                _ => Priority.Low     // 万が一のデフォルト
            };

            // 画面の入力値から TodoItem のインスタンスを生成
            TodoItem todoItem = new TodoItem　// {}内でそれぞれのデータに値を渡している　オブジェクトの初期化値
            {
                // タスク名
                Title = taskInputTextBox.Text,
                // 期限日
                DueDate = dueDateTimePicker.Value,
                // 作成日
                CreatedAt = DateTime.Now,
                // 優先度
                Priority = selectedPriority,
                // 完了かどうか 消しても動く新しいタスクは未完了で始める　boolは何も設定しないと false になるため
                Completed = false
            };

            // リスト（_items）に作った todoItem を追加する　これがないとタスクが追加されない
            _items.Add(todoItem);

            // 入力欄のクリアと画面の更新　順番逆でも変化はない
            taskInputTextBox.Clear();
            RefreshList();
        }

        // 優先度高中低の共通メソッド
        private void ShowTaskDetail(ListBox targetListBox) // どのListBoxかを引数に設定する
        {
            if (targetListBox.SelectedItem == null)
            {
                return;
            }

            // TODO: 1. 選ばれている行の TodoItem を取り出す
            // objekt型ってなんぞ？
            // 選ばれている項目が TodoItem だったら、selectedItem として使えるようにする
            if (targetListBox.SelectedItem is TodoItem selectedItem)
            {
                // TODO: 3. 詳細欄に表示する
                // 選択中のタスク名 インスタンスで生成した変数を入れる
                txtSelectedTextBox.Text = selectedItem.Title; // タスク名ならtxtSelectedTextBox.Textに
                                                              // 入力日を選択して表示する
                createdAtDateTimePicker.Value = selectedItem.CreatedAt; // 表示形式をvalueで指定
                                                                        // 期限日を選択して表示する
                dueDateTimePicker1.Value = selectedItem.DueDate;
            }
        }
        // 優先度高の中にあるタスクを選択したときに詳細欄に表示する処理
        private void highListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 引数はDesigner.csで定義されているもの
            ShowTaskDetail(highListBox);
        }
    }
}