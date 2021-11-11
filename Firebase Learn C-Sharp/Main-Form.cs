using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

using System.Data;
using System.Drawing.Imaging;

namespace Firebase_Learn_C_Sharp
{
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "IAHjmCQoZLBjUKwu72i9g6ECBBtkuavrADI5zHi7",
            BasePath = "https://fir-learn-c-sharp-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);

            if (client != null)
            {
                MessageBox.Show("Connection Established");
            }

            dt.Columns.Add("id");
            dt.Columns.Add("name");
            dt.Columns.Add("address");
            dt.Columns.Add("age");
            dt.Columns.Add("Image",typeof(Image));

            dataGridView1.DataSource = dt;
        }

        private async void insertButton_Click(object sender, EventArgs e)
        {
            FirebaseResponse resp = await client.GetTaskAsync("Counter/node");
            Counter_class get = resp.ResultAs<Counter_class>();

            MemoryStream ms = new MemoryStream();
            imageBox.Image.Save(ms, ImageFormat.Jpeg);

            byte [] a = ms.GetBuffer();

            string output = Convert.ToBase64String(a);

            var data = new Data
            {
                Id = (Convert.ToInt32(get.cnt) + 1).ToString(),
                Name = nameTextBox.Text,
                Address = addressTextBox.Text,
                Age = ageTextBox.Text,
                Img = output
            };

            SetResponse response = await client.SetTaskAsync("Information/" + data.Id, data);
            Data result = response.ResultAs<Data>();

            MessageBox.Show("Data Inserted " + result.Id);

            var obj = new Counter_class
            {
                cnt = data.Id
            };

            SetResponse response1 = await client.SetTaskAsync("Counter/node", obj);
        }

        private async void retrieveButton_Click(object sender, EventArgs e)
        {
            FirebaseResponse response = await client.GetTaskAsync("Information/" + idTextBox.Text);
            Data obj = response.ResultAs<Data>();

            idTextBox.Text = obj.Id;
            nameTextBox.Text = obj.Name;
            addressTextBox.Text = obj.Address;
            ageTextBox.Text = obj.Age;

            MessageBox.Show("Data Retrieved");
        }

        private async void updateButton_Click(object sender, EventArgs e)
        {
            var data = new Data
            {
                Id = idTextBox.Text,
                Name = nameTextBox.Text,
                Address = addressTextBox.Text,
                Age = ageTextBox.Text
            };

            FirebaseResponse response = await client.UpdateTaskAsync("Information/" + idTextBox.Text, data);
            Data result = response.ResultAs<Data>();
            MessageBox.Show("Data Updated at ID: " + result.Id);
        }

        private async void deleteButton_Click(object sender, EventArgs e)
        {
            FirebaseResponse response = await client.DeleteTaskAsync("Information/" + idTextBox.Text);
            MessageBox.Show("Deleted Element of Record : " + idTextBox.Text);
        }

        private async void deleteAllButton_Click(object sender, EventArgs e)
        {
            FirebaseResponse response = await client.DeleteTaskAsync("Information");
            MessageBox.Show("All elements deleted");
        }

        private async void getCounetrDataButton_Click(object sender, EventArgs e)
        {
            FirebaseResponse resp = await client.GetTaskAsync("Counter/node");
            Counter_class get = resp.ResultAs<Counter_class>();

            MessageBox.Show(get.cnt);
        }

        private void exportToDataGridViewButton_Click(object sender, EventArgs e)
        {
            export();
        }

        private async void export()
        {
            dt.Rows.Clear();

            int i = 0;
            FirebaseResponse respt1 = await client.GetTaskAsync("Counter/node");
            Counter_class obj1 = respt1.ResultAs<Counter_class>();
            int cnt = Convert.ToInt32(obj1.cnt);

            while (true)
            {
                if(i == cnt) break;
                i++;

                try
                {
                    FirebaseResponse resp2 = await client.GetTaskAsync("Information/" + i);
                    Data obj2 = resp2.ResultAs<Data>();

                    DataRow row = dt.NewRow();
                    row["id"] = obj2.Id;
                    row["name"] = obj2.Name;
                    row["address"] = obj2.Address;
                    row["age"] = obj2.Age;


                    // Image Code
                    byte[] b = Convert.FromBase64String(obj2.Img);

                    MemoryStream ms = new MemoryStream();
                    ms.Write(b, 0, Convert.ToInt32(b.Length));

                    Bitmap bm = new Bitmap(ms, false);

                    row["Image"] = bm;

                    dt.Rows.Add(row);
                }
                catch (Exception)
                {
                    throw;
                }
            }

            MessageBox.Show("Done");
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select Image";
            ofd.Filter = "Image Files(*.jpg) | *.jpg";

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                Image img = new Bitmap(ofd.FileName);
                imageBox.Image = img.GetThumbnailImage(350, 200, null, new IntPtr());
            }
        }

        private async void insertPictureButton_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            imageBox.Image.Save(ms,ImageFormat.Jpeg);

            byte[] a = ms.GetBuffer();

            string output = Convert.ToBase64String(a);

            var data = new Image_Model
            {
                Img = output
            };

            SetResponse response = await client.SetTaskAsync("Image/", data);
            Image_Model result = response.ResultAs<Image_Model>();

            imageBox.Image = null;

            MessageBox.Show("Image Inserted");
        }

        private async void retrievePictureButton_Click(object sender, EventArgs e)
        {
            FirebaseResponse response = await client.GetTaskAsync("Image/");
            Image_Model image = response.ResultAs<Image_Model>();

            byte[] b = Convert.FromBase64String(image.Img);

            MemoryStream ms = new MemoryStream();
            ms.Write(b,0,Convert.ToInt32(b.Length));

            Bitmap bm = new Bitmap(ms, false);
            ms.Dispose();

            imageBox.Image = bm;
        }
    }
}