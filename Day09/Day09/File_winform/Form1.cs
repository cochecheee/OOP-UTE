namespace File_winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            rtShow.Text = "";
        }

        private void btn_Hienthi_Click(object sender, EventArgs e)
        {
            FileInfo testFile = new FileInfo("D:\\Lap trinh huong doi tuong - OOP\\Day09\\Day09");
            if (rdbt.Checked == true)
            {
                if (testFile.Exists)
                {
                    rtShow.Text = testFile.FullName + " exist."
                                + "Creation time: " + testFile.CreationTime
                                + "Last Write Time: " + testFile.LastWriteTime
                                + "Directory name: " + testFile.DirectoryName;
                }
                else
                {
                    rtShow.Text = testFile.FullName + " does not exist.";
                }
            }

            if(rdbt_createDisk.Checked == true)
            {
                String dirPath = "D:\\Lap trinh huong doi tuong - OOP\\Day09\\Day09";

                bool exist = Directory.Exists(dirPath);

                if (!exist)
                {
                    rtShow.Text = dirPath + " does not exist." + "\n" +
                                "Creare directory: " + dirPath + "\n"
                                + "Nhan them 1 lan nua de hien thi thong tin thu muc vua tao";

                    Directory.CreateDirectory(dirPath);
                }
                else
                {
                    DirectoryInfo parentInfo = Directory.GetParent(dirPath);
                    rtShow.Text = "Directory Information " + dirPath + "\n"
                        + "Creation Time: " + Directory.GetCreationTime(dirPath)
                         +"Last Write Time: " + Directory.GetLastWriteTime(dirPath) + "\n"
                           + "Parent directory: " + parentInfo.FullName;
                }

            }

        }
    }
}