using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace MyPhotos
{
    public partial class GUI : Form
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source=WINDOWS-G851JRV\SQLEXPRESS;Initial Catalog=MyPhotos;Integrated Security=True");
        private OpenFileDialog openFileDialog1;

        public GUI()
        {
            InitializeComponent();
        }

        private void PathLabel_Click(object sender, EventArgs e)
        {

        }

        private void TypeOfPhotoLabel_Click(object sender, EventArgs e)
        {

        }

        private void PathString_TextChanged(object sender, EventArgs e)
        {

        }

        private void LocationString_TextChanged(object sender, EventArgs e)
        {

        }

        private void LocationLabel_Click(object sender, EventArgs e)
        {

        }

        private void TypeOfPhotoString_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreationDateString_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreatinoDateLabel_Click(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "F:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    PathString.Text = filePath.Substring(0, filePath.LastIndexOf("\\"));
                    NameString.Text = filePath.Substring(filePath.LastIndexOf("\\")+1);
                    FileInfo fi = null;
                    try
                    {
                        fi = new FileInfo(filePath);
                        CreationDateString.Text =  fi.CreationTime.ToString();
                        
                    }
                    catch(System.IO.FileNotFoundException ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }

           
        }

        private void AddToButton_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fdb = new FolderBrowserDialog() { Description = "Select folder for the image to be put" }) ;
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            try
            {
                sqlCon.Open();
                SqlCommand sqlCmd;
                DateTime now = DateTime.Now;
                Random random =  new Random();
                int num = random.Next();
                String location = LocationString.Text;
                String typeOfPhoto = TypeOfPhotoString.Text;
                String path = PathString.Text;
                String creationDate = CreationDateString.Text;
                String name = NameString.Text;
                String query = "Insert into MyPhotos.dbo.Photos (Id,CreationDate, TypeOfPhoto, Location , Path, Name)VALUES" +
                    "( '"+ num + "','" + creationDate + "','" + typeOfPhoto + "','" +location+ "','" +path+"','"+name+"')";
                sqlCmd = new SqlCommand(query, sqlCon);
                sqlCmd.ExecuteNonQuery();
                sqlCon.Close();
            }
            catch(Exception ex)
            {
                sqlCon.Close();
                MessageBox.Show(ex.ToString());
            }
        }

        private void NameString_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
