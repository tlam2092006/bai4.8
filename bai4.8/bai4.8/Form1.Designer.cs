namespace bai4._8
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private MenuStrip menuStrip;
        private ToolStripMenuItem studentMenuItem;
        private ToolStripMenuItem openStudentListMenuItem;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel progressStatusLabel;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip = new MenuStrip();
            studentMenuItem = new ToolStripMenuItem();
            openStudentListMenuItem = new ToolStripMenuItem();
            statusStrip = new StatusStrip();
            progressStatusLabel = new ToolStripStatusLabel();
            menuStrip.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();
            //
            // menuStrip
            //
            menuStrip.Items.AddRange(new ToolStripItem[] { studentMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(800, 24);
            menuStrip.TabIndex = 0;
            //
            // studentMenuItem
            //
            studentMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openStudentListMenuItem });
            studentMenuItem.Name = "studentMenuItem";
            studentMenuItem.Size = new Size(67, 20);
            studentMenuItem.Text = "Sinh viên";
            //
            // openStudentListMenuItem
            //
            openStudentListMenuItem.Name = "openStudentListMenuItem";
            openStudentListMenuItem.Size = new Size(180, 22);
            openStudentListMenuItem.Text = "Nạp danh sách";
            openStudentListMenuItem.Click += OpenStudentListMenuItem_Click;
            //
            // statusStrip
            //
            statusStrip.Items.AddRange(new ToolStripItem[] { progressStatusLabel });
            statusStrip.Location = new Point(0, 428);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(800, 22);
            statusStrip.TabIndex = 1;
            //
            // progressStatusLabel
            //
            progressStatusLabel.Name = "progressStatusLabel";
            progressStatusLabel.Size = new Size(57, 17);
            progressStatusLabel.Text = "Sẵn sàng";
            //
            // Form1
            //
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip);
            Controls.Add(menuStrip);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip;
            Name = "Form1";
            Text = "Bài 4.8 - Async/Await và ProgressBar";
            WindowState = FormWindowState.Maximized;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
