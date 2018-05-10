using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace waAgenda
{
    public partial class usuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SqlDataSourceUsuarios_Inserting(object sender, SqlDataSourceCommandEventArgs e)
        {     
        }

        protected void SqlDataSourceUsuarios_Inserted(object sender, SqlDataSourceStatusEventArgs e)
        {
            if (e.Exception != null)
            {
                lMsg.Text = "Inserindo um registro duplicado ou com campos em branco";
                e.ExceptionHandled = true;
            }
        }

        protected void SqlDataSourceUsuarios_Updated(object sender, SqlDataSourceStatusEventArgs e)
        {
            if (e.Exception != null)
            {
                lMsg.Text = "Alterando um registro sem informar todos os campos";
                e.ExceptionHandled = true;
            }
        }
    }
}