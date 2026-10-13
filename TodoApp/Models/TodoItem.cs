using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.Models
{
    internal class TodoItem
    {
        // タスク名
        public string Title { get; set; } = "";
        // 期限日
        public DateTime DueDate { get; set; }
        // 作成日
        public DateTime CreatedAt { get; set; }
        // 優先度
        public Priority Priority { get; set; }
        // 完了かどうか
        public bool Completed { get; set; }
    }
}
