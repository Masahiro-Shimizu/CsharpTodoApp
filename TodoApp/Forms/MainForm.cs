using TodoApp.Forms;
using TodoApp.Models;
using TodoApp.Services;
using System.Diagnostics;

namespace TodoApp
{
    // メインフォームのクラス
    public partial class MainForm : Form
    {
        // フィールド
        // newでインスタンス化
        private readonly List<TodoItem> _items = new(); // 本当のデータ

        private readonly TodoStorage _storage = new();
        // コンストラクタ
        public MainForm()
        {
            InitializeComponent();
            _items.AddRange(_storage.Load());
            RefreshList();
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
            Priority selectedPriority = tabControl1.SelectedIndex
            switch
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

            // 保存を呼ぶ
            _storage.Save(_items);

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

            // 選ばれている行の TodoItem を取り出す
            // C#のあらゆる型の、いちばん大もとの型 何が入っているかわからない箱のようなもの
            // 選ばれている項目が TodoItem だったら、selectedItem として使えるようにする
            if (targetListBox.SelectedItem is TodoItem selectedItem)
            {
                // 詳細欄に表示する
                // 選択中のタスク名 インスタンスで生成した変数を入れる
                txtSelectedTextBox.Text = selectedItem.Title; // タスク名ならtxtSelectedTextBox.Textに
                // 入力日を選択して表示する
                createdAtDateTimePicker.Value = selectedItem.CreatedAt; // DateTimePicker の Value に日付をそのまま渡している
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

        private void middleListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 引数はDesigner.csで定義されているもの
            ShowTaskDetail(middleListBox);
        }

        private void lowListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 引数はDesigner.csで定義されているもの
            ShowTaskDetail(lowListBox);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            // 今開いているタブのListBoxを取得する
            ListBox currentListBox = null;

            // 1. いま開いているタブから、対象のListBoxを決める
            //    (ヒント: addButton_Click で優先度を決めたときと同じく、
            //     tabControl1 の「選択中のタブの番号」を見る)
            //    (ヒント: 決めたListBoxを入れる変数を1つ用意すると、
            //     以降の処理を1回ずつ書くだけで済む)
            //    (ヒント: 型は ListBox。highListBox などを代入できる)
            if (tabControl1.SelectedIndex == 0)
            {
                currentListBox = highListBox;
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                currentListBox = middleListBox;
            }
            else if (tabControl1.SelectedIndex == 2)
            {
                currentListBox = lowListBox;
            }



            // 3. 選ばれている行から TodoItem を取り出す
            //    (ヒント: ShowTaskDetail の is TodoItem selectedItem と同じ形)
            //    (取り出せなかったときは、ここでも終わる)
            if (currentListBox.SelectedItem is TodoItem selectedItem)
            {
                // 4. 削除してよいか、確認する(任意。あとから足してもOK)
                //    (ヒント: MessageBox.Show の引数で、Yes / No のボタンにできる)
                //    (ヒント: 押されたボタンは DialogResult で分かる。No なら終わる)
                DialogResult result = MessageBox.Show(
                    $"「{selectedItem.Title}」を削除してもよろしいですか？", "削除の確認",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                    );

                if (result == DialogResult.No)
                {
                    return;
                }

                // 5. _items から、取り出した TodoItem を消す
                //    (ヒント: Add の反対のメソッド。List の Remove を調べる)
                //    (注意: 消すのは ListBox ではなく _items。「本当のデータ」はこちら)
                _items.Remove(selectedItem);

                _storage.Save(_items);

                // 6. 一覧を作り直す
                //    (ヒント: 追加ボタンの最後と同じ。なぜ呼ぶのか、説明できる?)
                RefreshList();

                // 7. 詳細欄をどうするか決める
                //    (ヒント: 消したタスクの内容が詳細欄に残るのは、使う人が混乱する)
                //    (ヒント: タスク名の欄は、空にする方法を ShowTaskDetail から探す)
                //    (日付の欄は、DateTimePicker なので空にはできない。どうするかは自分で決める)
                txtSelectedTextBox.Text = "";
                dueDateTimePicker1.Value = DateTime.Now;
            }
            else
            {
                // 2. 何も選ばれていなければ、メッセージを出して終わる
                //    (ヒント: ShowTaskDetail の最初の if と同じ考え方)
                //    (ヒント: メッセージは MessageBox.Show。addButton_Click に書き方の見本がある)
                if (currentListBox.SelectedItem == null)
                {
                    MessageBox.Show("タスクを選択してください。", "入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }

        private ListBox GetCurrentListBox()
        {
            return tabControl1.SelectedIndex switch
            {
                0 => highListBox,
                1 => middleListBox,
                _ => lowListBox
            };
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            ListBox currentListBox = GetCurrentListBox();

            if (currentListBox.SelectedItem is not TodoItem selectedItem)
            {
                MessageBox.Show("タスクを選択してください。", "入力エラー",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var editForm = new EditForm(selectedItem))
            {
                if (editForm.ShowDialog(this) == DialogResult.OK)
                {
                    _storage.Save(_items);
                    ShowTaskDetail(currentListBox);
                    RefreshList();
                }
            }
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = _storage.FolderPath,
                UseShellExecute = true
            });
        }
    }
}