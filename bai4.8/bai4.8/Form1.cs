namespace bai4._8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OpenStudentListMenuItem_Click(object? sender, EventArgs e)
        {
            foreach (Form child in MdiChildren)
            {
                if (child is StudentListForm)
                {
                    child.Activate();
                    return;
                }
            }

            var studentListForm = new StudentListForm(this)
            {
                MdiParent = this
            };
            studentListForm.Show();
        }

        public void UpdateProgressStatus(int percent)
        {
            progressStatusLabel.Text = $"Đang nạp dữ liệu: {percent}%";
        }

        public void SetProgressStatus(string message)
        {
            progressStatusLabel.Text = message;
        }
    }
}
