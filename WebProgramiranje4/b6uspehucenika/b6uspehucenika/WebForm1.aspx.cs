﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace b6uspehucenika
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_Sorting(object sender, GridViewSortEventArgs e)
        {
            //zabranjuje sortiranje po ovim poljima naredni kod
            if(e.SortExpression == "Razred" || e.SortExpression == "Odlican" ||
                e.SortExpression == "Vrlodobar" || e.SortExpression == "Dobar"||
                e.SortExpression == "Dovoljan" || e.SortExpression == "Nedovoljan")
            {
                e.Cancel = true;
                Message.Text = "Nije dozvoljeno sortiranje po ovom polju.";
                SortInformationLabel.Text = "";
            }
            else
            {
                Message.Text = "";
            }
        }

        protected void GridView1_Sorted(object sender, EventArgs e)
        {
            string srb, pom = GridView1.SortDirection.ToString();
            if (pom == "Ascending") srb = "rastucem";
            else srb = "opadajucem";
            SortInformationLabel.Text = "Sortirano je po polju " +
                " u " + srb + " poretku.";
        }
    }
}