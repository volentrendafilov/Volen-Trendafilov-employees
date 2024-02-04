namespace PairOfEmployees
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            openFileDialog1 = new OpenFileDialog();
            selectFileButton = new Button();
            filePathTextBox = new TextBox();
            runButton = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // selectFileButton
            // 
            selectFileButton.Location = new Point(12, 12);
            selectFileButton.Name = "selectFileButton";
            selectFileButton.Size = new Size(110, 23);
            selectFileButton.TabIndex = 0;
            selectFileButton.Text = "Select File";
            selectFileButton.UseVisualStyleBackColor = true;
            selectFileButton.Click += selectFileButton_Click;
            // 
            // filePathTextBox
            // 
            filePathTextBox.Location = new Point(128, 12);
            filePathTextBox.Name = "filePathTextBox";
            filePathTextBox.ReadOnly = true;
            filePathTextBox.Size = new Size(464, 23);
            filePathTextBox.TabIndex = 1;
            // 
            // runButton
            // 
            runButton.Location = new Point(12, 416);
            runButton.Name = "runButton";
            runButton.Size = new Size(107, 23);
            runButton.TabIndex = 2;
            runButton.Text = "Run";
            runButton.UseVisualStyleBackColor = true;
            runButton.Click += runButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(128, 42);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(464, 397);
            dataGridView1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 55);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 4;
            label1.Text = "Select Date Format";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Auto", "yyyy-MM-dd", "M/d/yyyy", "MM/dd/yyyy", "dd/MM/yyyy", "yyyy.MM.dd", "dd-MMM-yy", "MM.dd.yy" });
            comboBox1.Location = new Point(12, 73);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(110, 23);
            comboBox1.TabIndex = 5;
            comboBox1.Text = "Auto";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(604, 450);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(runButton);
            Controls.Add(filePathTextBox);
            Controls.Add(selectFileButton);
            MaximizeBox = false;
            MaximumSize = new Size(620, 489);
            MinimumSize = new Size(620, 489);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pair Of Employees";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private Button selectFileButton;
        private TextBox filePathTextBox;
        private Button runButton;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Label label1;
        private ComboBox comboBox1;
    }
}
