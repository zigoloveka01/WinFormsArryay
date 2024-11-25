namespace WinFormsArryay
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
            button1 = new Button();
            button2 = new Button();
            txt_intup = new TextBox();
            lbl_Data = new Label();
            button3 = new Button();
            label2 = new Label();
            label3 = new Label();
            button4 = new Button();
            button5 = new Button();
            checkedListBox1 = new CheckedListBox();
            listBox1 = new ListBox();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 28);
            button1.Name = "button1";
            button1.Size = new Size(178, 80);
            button1.TabIndex = 0;
            button1.Text = "Array";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(12, 129);
            button2.Name = "button2";
            button2.Size = new Size(178, 76);
            button2.TabIndex = 1;
            button2.Text = "Array2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txt_intup
            // 
            txt_intup.Location = new Point(248, 72);
            txt_intup.Multiline = true;
            txt_intup.Name = "txt_intup";
            txt_intup.Size = new Size(134, 335);
            txt_intup.TabIndex = 2;
            // 
            // lbl_Data
            // 
            lbl_Data.BackColor = SystemColors.Info;
            lbl_Data.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Data.Location = new Point(556, 72);
            lbl_Data.Name = "lbl_Data";
            lbl_Data.Size = new Size(129, 335);
            lbl_Data.TabIndex = 3;
            lbl_Data.Text = "label1";
            lbl_Data.Click += label1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(410, 72);
            button3.Name = "button3";
            button3.Size = new Size(110, 88);
            button3.TabIndex = 4;
            button3.Text = "GetData";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(248, 39);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 5;
            label2.Text = "พิมพ์รายชื่อ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(556, 39);
            label3.Name = "label3";
            label3.Size = new Size(105, 20);
            label3.TabIndex = 6;
            label3.Text = "รายชื่อบันทึกแล้ว";
            // 
            // button4
            // 
            button4.Location = new Point(410, 192);
            button4.Name = "button4";
            button4.Size = new Size(110, 83);
            button4.TabIndex = 7;
            button4.Text = "GetNumber";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(12, 257);
            button5.Name = "button5";
            button5.Size = new Size(178, 112);
            button5.TabIndex = 8;
            button5.Text = "Array 2 มิติ";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(712, 293);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(150, 114);
            checkedListBox1.TabIndex = 9;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(712, 161);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150, 104);
            listBox1.TabIndex = 10;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(712, 72);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(150, 28);
            comboBox1.TabIndex = 11;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(890, 450);
            Controls.Add(comboBox1);
            Controls.Add(listBox1);
            Controls.Add(checkedListBox1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(lbl_Data);
            Controls.Add(txt_intup);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox txt_intup;
        private Label lbl_Data;
        private Button button3;
        private Label label2;
        private Label label3;
        private Button button4;
        private Button button5;
        private CheckedListBox checkedListBox1;
        private ListBox listBox1;
        private ComboBox comboBox1;
    }
}
