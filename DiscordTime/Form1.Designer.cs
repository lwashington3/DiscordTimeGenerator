namespace DiscordTime
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
			TimestampLabel = new Label();
			button1 = new Button();
			dateTimePicker1 = new DateTimePicker();
			FormatsBox = new ComboBox();
			flowLayoutPanel1 = new FlowLayoutPanel();
			tableLayoutPanel1 = new TableLayoutPanel();
			flowLayoutPanel1.SuspendLayout();
			tableLayoutPanel1.SuspendLayout();
			SuspendLayout();
			// 
			// TimestampLabel
			// 
			TimestampLabel.Dock = DockStyle.Bottom;
			TimestampLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
			TimestampLabel.ForeColor = SystemColors.Control;
			TimestampLabel.Location = new Point(3, 135);
			TimestampLabel.Name = "TimestampLabel";
			TimestampLabel.Size = new Size(320, 32);
			TimestampLabel.TabIndex = 0;
			TimestampLabel.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// button1
			// 
			button1.AutoSize = true;
			button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			button1.Dock = DockStyle.Fill;
			button1.Location = new Point(163, 3);
			button1.Name = "button1";
			button1.Size = new Size(154, 94);
			button1.TabIndex = 1;
			button1.Text = "Copy to Clipboard";
			button1.UseVisualStyleBackColor = true;
			button1.Click += CopyToClipboard;
			// 
			// dateTimePicker1
			// 
			dateTimePicker1.CustomFormat = "dddd, MMMM dd, yyyy - hh:mm:ss tt";
			dateTimePicker1.Format = DateTimePickerFormat.Custom;
			dateTimePicker1.Location = new Point(3, 3);
			dateTimePicker1.MinDate = new DateTime(2023, 3, 2, 0, 0, 0, 0);
			dateTimePicker1.Name = "dateTimePicker1";
			dateTimePicker1.Size = new Size(320, 23);
			dateTimePicker1.TabIndex = 2;
			dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
			// 
			// FormatsBox
			// 
			FormatsBox.Dock = DockStyle.Fill;
			FormatsBox.FormattingEnabled = true;
			FormatsBox.Location = new Point(3, 3);
			FormatsBox.Name = "FormatsBox";
			FormatsBox.Size = new Size(154, 23);
			FormatsBox.TabIndex = 3;
			FormatsBox.Text = "Format";
			FormatsBox.SelectionChangeCommitted += FormatsBox_SelectionChangeCommitted;
			// 
			// flowLayoutPanel1
			// 
			flowLayoutPanel1.Controls.Add(dateTimePicker1);
			flowLayoutPanel1.Controls.Add(tableLayoutPanel1);
			flowLayoutPanel1.Controls.Add(TimestampLabel);
			flowLayoutPanel1.Dock = DockStyle.Fill;
			flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
			flowLayoutPanel1.Location = new Point(0, 0);
			flowLayoutPanel1.Name = "flowLayoutPanel1";
			flowLayoutPanel1.Size = new Size(323, 176);
			flowLayoutPanel1.TabIndex = 4;
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 2;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.Controls.Add(FormatsBox, 0, 0);
			tableLayoutPanel1.Controls.Add(button1, 1, 0);
			tableLayoutPanel1.Location = new Point(3, 32);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 1;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.Size = new Size(320, 100);
			tableLayoutPanel1.TabIndex = 4;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(323, 176);
			Controls.Add(flowLayoutPanel1);
			FormBorderStyle = FormBorderStyle.SizableToolWindow;
			Name = "Form1";
			Text = "Discord Timestamp Generator";
			flowLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Label TimestampLabel;
		private Button button1;
		private DateTimePicker dateTimePicker1;
		private ComboBox FormatsBox;
		private FlowLayoutPanel flowLayoutPanel1;
		private TableLayoutPanel tableLayoutPanel1;
	}
}