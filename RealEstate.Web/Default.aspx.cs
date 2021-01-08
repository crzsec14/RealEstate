using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RealEstate.Core.Entities;
using RealEstate.Core.Services;
namespace RealEstate.Web
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UserService usrService = new UserService();
            List<User> users = new List<User>();
            users = usrService.GetUsers();
            if (!IsPostBack)
            {
                repPeople.DataSource = users;
                repPeople.DataBind();
            }
        }
    }
}