namespace WinFormsArryay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] student = new string[5];
            student[0] = "คิม";
            student[1] = "คิด";
            student[2] = "ฟาม";
            student[3] = "ปราม";
            student[4] = "เฟรม";
            string test = "";
            int n = student.Length; // หาขนาดของ Array
            for (int i = 0; i < n; i++)
            {
                test += student[i] + Environment.NewLine; // ขึ้นบรรทัดใหม่

            }
            MessageBox.Show(test);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] Fruits = { "แมว", "หมา", "ลิง", "สนุข", "ม้า", "กบ", "ชนี", "วัว" };
            string myFruits = "";
            foreach (string str in Fruits)
            {
                myFruits += str + Environment.NewLine;
            }
            MessageBox.Show(myFruits, "สัตย์ของฉัน");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] data = txt_intup.Lines; //นำข้อมูลแต่ละบรรทัดไปใส่ใน Array

            string result = "";
            foreach (string str in data)
            {
                if (str != "") //เช็คค่่าว่าง ถ้าว่างจะไม่ทำ
                {
                    result += str + Environment.NewLine;
                }
                // result += str + Environment.NewLine;    

            }
            lbl_Data.Text = result;


        }

        private void button4_Click(object sender, EventArgs e)
        {
            string[] data = txt_intup.Lines;
            string resuli = "";
            int sum = 0;
            foreach (var str in data)
            {
                int x = 0;
                if (int.TryParse(str, out x))
                {
                    sum += x;
                    resuli += x.ToString() + Environment.NewLine;
                }
                MessageBox.Show(sum.ToString(), "ผลรวมตัวเลข");
                lbl_Data.Text = resuli;



            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string[,] student = new string[3, 2];
            student[0, 0] = "เอ็ม";
            student[0, 1] = "หนองบัว";
            student[1, 0] = "ครีม";
            student[1, 1] = "อุกร";
            student[2, 0] = "ฟลุค";
            student[2, 1] = "สกล";
            string ResultData = "";
            int m = student.GetLength(0);
            int n = student.GetLength(1);
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    ResultData += student[i, j] + "-";



                }
                ResultData += Environment.NewLine;
            }
            MessageBox.Show(ResultData, "แสดงข้อมูลใน Array 2 มิติ");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = comboBox1.SelectedIndex.ToString() + " - ";
            str += comboBox1.SelectedItem;
            MessageBox.Show(str);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] Fruits = { "แมว", "หมา", "ลิง", "สนุข", "ม้า", "กบ", "ชนี", "วัว" };
            comboBox1.Items.AddRange(Fruits);
            listBox1.Items.AddRange(Fruits);
            checkedListBox1.Items.AddRange(Fruits);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = listBox1.SelectedIndex.ToString() + " - ";
            str += listBox1.SelectedItem;
            MessageBox.Show(str);
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = checkedListBox1.SelectedIndex.ToString() + " - ";
            str += checkedListBox1.SelectedItem;
            MessageBox.Show(str);
        }
    }
}
