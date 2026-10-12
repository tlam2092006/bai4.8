namespace bai4._8
{
    public partial class StudentListForm : Form
    {
        private readonly Form1 parentForm;
        private readonly Button loadButton;
        private readonly ProgressBar progressBar;
        private readonly Label percentLabel;
        private readonly Label statusLabel;
        private readonly ListBox studentListBox;

        public StudentListForm(Form1 parentForm)
        {
            this.parentForm = parentForm;
            Text = "Danh sách sinh viên";
            Width = 620;
            Height = 420;
            MinimumSize = new Size(500, 320);
            StartPosition = FormStartPosition.CenterParent;

            loadButton = new Button
            {
                AutoSize = true,
                Text = "Nạp dữ liệu",
                Location = new Point(20, 20)
            };
            loadButton.Click += LoadButton_Click;

            progressBar = new ProgressBar
            {
                Location = new Point(20, 65),
                Size = new Size(470, 24),
                Minimum = 0,
                Maximum = 100
            };

            percentLabel = new Label
            {
                AutoSize = true,
                Location = new Point(500, 69),
                Text = "0%"
            };

            statusLabel = new Label
            {
                AutoSize = true,
                Location = new Point(20, 105),
                Text = "Sẵn sàng"
            };

            studentListBox = new ListBox
            {
                Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right,
                Location = new Point(20, 135),
                Size = new Size(550, 220)
            };

            Controls.Add(loadButton);
            Controls.Add(progressBar);
            Controls.Add(percentLabel);
            Controls.Add(statusLabel);
            Controls.Add(studentListBox);
        }

        private async void LoadButton_Click(object? sender, EventArgs e)
        {
            loadButton.Enabled = false;
            progressBar.Value = 0;
            percentLabel.Text = "0%";
            statusLabel.Text = "Đang nạp dữ liệu...";
            studentListBox.Items.Clear();

            var progress = new Progress<int>(percent =>
            {
                progressBar.Value = percent;
                percentLabel.Text = $"{percent}%";
                parentForm.UpdateProgressStatus(percent);
            });

            try
            {
                List<Student> students = await LoadStudentsAsync(progress);
                studentListBox.Items.AddRange(students.Cast<object>().ToArray());
                statusLabel.Text = $"Hoàn tất: đã nạp {students.Count} sinh viên.";
                parentForm.SetProgressStatus("Nạp dữ liệu hoàn tất");
            }
            catch (Exception ex)
            {
                statusLabel.Text = "Nạp dữ liệu thất bại.";
                parentForm.SetProgressStatus("Nạp dữ liệu thất bại");
                MessageBox.Show(this, $"Không thể nạp dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                loadButton.Enabled = true;
            }
        }

        private async Task<List<Student>> LoadStudentsAsync(IProgress<int> progress)
        {
            return await Task.Run(async () =>
            {
                var students = new List<Student>();
                string[] names =
                {
                    "Nguyễn An", "Trần Bình", "Lê Chi", "Phạm Dũng", "Hoàng Giang",
                    "Vũ Hà", "Đặng Khánh", "Bùi Lan", "Đỗ Minh", "Phan Ngọc"
                };

                progress.Report(0);
                for (int i = 0; i < names.Length; i++)
                {
                    await Task.Delay(300);
                    students.Add(new Student(names[i], "Công nghệ thông tin"));
                    progress.Report((i + 1) * 100 / names.Length);
                }

                return students;
            });
        }

        private sealed record Student(string Name, string Major)
        {
            public override string ToString() => $"{Name} - {Major}";
        }
    }
}
