using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using classLibrary;

namespace InigmaITEmployment.HTML
{
    public partial class WebForm1 : Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCancelAdd_Click(object sender, EventArgs e)
        {
            Response.Redirect("JobSearch.aspx");
        }

        void Add()
        {
            clsJobCollection JobBook = new clsJobCollection();
            //the code below is to validate the data on the web form
            string Error = JobBook.ThisJob.Valid(txtAddJobName.Text, txtAddJobDescription.Text, txtAddDate.Text, txtAddStaffId.Text, txtAddEmployerId.Text);
            if (Error == "")
            {
                JobBook.ThisJob.Job Name = txtAddJobName.Text;
                JobBook.ThisJob.Job Description = txtAddJobDescription.Text;
                JobBook.ThisJob.Date posted = Convert.ToDateTime(txtAddDate.Text);
                JobBook.ThisJob.Staff ID = Convert.ToInt32(txtAddStaffId.Text);
                JobBook.ThisJob.Employer id = Convert.ToInt32(txtAddEmployerId);
                JobBook.Add();
            }
            else
            {
                lblAddError.Text = "There were problems with the data you entered" + Error;
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Add();
            Response.Redirect("JobSearch.aspx");
        }
    }
}