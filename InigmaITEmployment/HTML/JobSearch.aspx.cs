using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InigmaITEmployment.HTML
{
    public partial class JobSearch : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnViewJob_Click(object sender, EventArgs e)
        {
            Response.Redirect("Job.aspx");

        }

        protected void btnUpdateJob_Click(object sender, EventArgs e)
        {
            Response.Redirect("Update job.aspx");
        }

        protected void btnAddJob_Click(object sender, EventArgs e)
        {
            Response.Redirect("Add Job.aspx");
        }

        protected void btnDeleteJob_Click(object sender, EventArgs e)
        {
            Response.Redirect("Delete Job.aspx");
        }
    }
}