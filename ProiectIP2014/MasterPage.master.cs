﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage {
    protected void Page_Load(object sender, EventArgs e) {
        if (!IsPostBack) {
            if (HttpContext.Current.User.Identity.IsAuthenticated) {
                (LoginView2.FindControl("HyperLinkProfil") as HyperLink).NavigateUrl = "~/Profil.aspx?username=" + Profile.UserName;
            }
        }
    }
}
