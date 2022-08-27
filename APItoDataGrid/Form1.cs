using System.Net.Http.Json;

namespace APItoDataGrid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:4001/");
            HttpResponseMessage response = client.GetAsync("api/experiences").Result;
            var candidate = response.Content.ReadFromJsonAsync<IEnumerable<Candidate>>().Result;
            dataGridView1.DataSource = candidate;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}