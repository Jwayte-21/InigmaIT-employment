using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InigmaITEmployment.HTML
{
    public partial class Update_Job : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCancelUpdate_Click(object sender, EventArgs e)
        {
            Response.Redirect("JobSearch.aspx");
        }
    }
}