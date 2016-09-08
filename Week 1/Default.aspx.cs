using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Week_1
{
    public partial class _Default : Page
    {
        /// <summary>
        /// This method executes everytime the page loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            HelloLable.Text = "Good Bye.";
        }
    }
}