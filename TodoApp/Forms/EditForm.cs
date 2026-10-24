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
    /// <summary>
    /// タスクを編集するダイアログ。
    /// MainForm から ShowDialog() で開かれ、OKで閉じたときだけ内容が反映される。
    /// </summary>
    public partial class EditForm : Form
    {
        // 編集するタスク。MainForm の _items に入っているものと「同じ実体」。
        // TodoItem はクラス(参照型)なので、ここで書き換えると MainForm 側のデータも変わる。
        // readonly は「別のタスクに差し替えない」という意味。中身(Title など)は変えられる。
        private readonly TodoItem _item;

        /// <summary>
        /// コンストラクタ。ダイアログを開く前に、編集するタスクを受け取る。
        /// </summary>
        /// <param name="item">編集したいタスク(MainForm で選ばれているもの)</param>
        public EditForm(TodoItem item)
        {
            // デザイナーで置いた部品(TextBox など)を作る。部品を使う前に必ず先に呼ぶ。
            InitializeComponent();

            // 受け取ったタスクを、他のメソッド(okButton_Click)でも使えるように保持する
            _item = item;

            // 開いた時点で、現在の値を入力欄に表示しておく(編集の元になる値)
            titleTextBox.Text = _item.Title;
            dueDateTimePicker.Value = _item.DueDate;
        }

        /// <summary>
        /// OKボタンを押したときの処理。入力を検査して、問題なければタスクに書き戻す。
        /// </summary>
        private void okButton_Click(object sender, EventArgs e)
        {
            // タスク名が空またはスペースだけなら、メッセージを出して中断する。
            // return するので、下の書き換えとダイアログを閉じる処理は実行されない(画面は開いたまま)
            if (string.IsNullOrWhiteSpace(titleTextBox.Text))
            {
                MessageBox.Show("タスク名を入力してください。", "入力エラー",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 入力内容を、タスクに書き戻す。
            // _item は MainForm の _items 内のタスクと同じ実体なので、
            // ここで書き換えるだけで、MainForm 側にも反映される(戻り値を返す必要がない)
            _item.Title = titleTextBox.Text;
            _item.DueDate = dueDateTimePicker.Value;

            // 「OKで閉じた」と呼び出し元に伝える。
            // DialogResult に値を入れると、ダイアログは自動で閉じる。
            // MainForm は ShowDialog() の結果が OK のときだけ、保存と画面の更新をする
            DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// キャンセルボタンを押したときの処理。何も書き換えずに閉じる。
        /// </summary>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            // 「キャンセルで閉じた」と伝える。_item は書き換えていないので、元のまま残る。
            // MainForm は結果が OK ではないので、保存も画面の更新もしない
            DialogResult = DialogResult.Cancel;
        }
    }
}