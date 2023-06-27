using Microsoft.IdentityModel.Tokens;
using POS.BUSSINESSRULES;
using POS.Model;

namespace POS.UI
{
    public partial class Form1 : Form
    {
        MovieRules obj = new MovieRules();
        public int id = 0;
        public Boolean txtUpdate = false;
        public Form1()
        {
            InitializeComponent();
        }



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MovieDetails md = new MovieDetails();
            md.Name = txtName.Text;
            if (txtAmount.Text.IsNullOrEmpty())
            {
                md.Amount = 0;
            }
            else
            {
                md.Amount = Convert.ToDecimal(txtAmount.Text);

            }
            if (txtSeats.Text.IsNullOrEmpty())
            {
                md.NoOfSeats = 0;
            }
            else
            {
                md.NoOfSeats = Convert.ToInt32(txtSeats.Text);
            }

            md.MobileNumber = txtNumber.Text;
            md.MovieName = txtMoviename.Text;
            md.Mail = txtMail.Text;



            if (obj.AddMovie(md))
                MessageBox.Show("Done");
            else
                MessageBox.Show("failed");

            //gvDetails.DataSource = obj.GetMovieList();
        }

        private void gridViewDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = gvDetails[1, e.RowIndex].Value.ToString();
            txtMail.Text = gvDetails[2, e.RowIndex].Value.ToString();
            txtNumber.Text = gvDetails[3, e.RowIndex].Value.ToString();
            txtMoviename.Text = gvDetails[4, e.RowIndex].Value.ToString();
            txtSeats.Text = gvDetails[5, e.RowIndex].Value.ToString();
            txtAmount.Text = gvDetails[6, e.RowIndex].Value.ToString();
            id = int.Parse(gvDetails[0, e.RowIndex].Value.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gvDetails.DataSource = obj.GetMovieList();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MovieDetails md = new MovieDetails();
            md.Name = txtName.Text;
            if (txtAmount.Text.IsNullOrEmpty())
            {
                md.Amount = 0;
            }
            else
            {
                md.Amount = Convert.ToDecimal(txtAmount.Text);

            }
            if (txtSeats.Text.IsNullOrEmpty())
            {
                md.NoOfSeats = 0;
            }
            else
            {
                md.NoOfSeats = Convert.ToInt32(txtSeats.Text);
            }

            md.MobileNumber = txtNumber.Text;
            md.MovieName = txtMoviename.Text;
            md.Mail = txtMail.Text;
            md.Id = id;
            if (obj.UpdateMovie(md))
            {
                MessageBox.Show("Updated Successfully");
            }
            else
            {
                MessageBox.Show("Update Failed");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (obj.DeleteMovie(id))
            {
                MessageBox.Show("Record Deleted");
            }
            else
            {
                MessageBox.Show("Record Deletion Failed");
            }
        }
    }
}