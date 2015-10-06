using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Problem_02;

namespace TddWebApp
{
    public partial class _Default : System.Web.UI.Page
    {
        GuessGameEngine engine;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["GameEngine"] == null)
            {
                engine = new GuessGameEngine();
                engine.startGame();
            }
            else
                engine = (GuessGameEngine)Session["GameEngine"];

            if (!String.IsNullOrEmpty(txtInput.Text))
                lblOutput.Text += txtInput.Text + " " + engine.verifyGuess(Convert.ToInt32(txtInput.Text)) + "<br/>";

            if (!Page.IsPostBack)
                lblOutput.Text += "Enter value between 1-100<br/>";

            txtInput.Text = "";
            txtInput.Focus();

            Session["GameEngine"] = engine;

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {

        }
    }
}
