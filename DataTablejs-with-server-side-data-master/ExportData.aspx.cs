using DataTablejs_with_server_side_data_master.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DataTablejs_with_server_side_data_master
{
    public partial class ExportData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                if (!string.IsNullOrEmpty(Request.Form["mode"]))
                {
                    try
                    {
                        string mode = Convert.ToString(Request.Form["mode"]);
                        ColumnConfig columnConfig = new ColumnConfig(mode);
                        columnConfig.gridParams.ExportData();
                    }
                    catch (Exception)
                    {
                        //ex.SetLog("For Export Data");
                    }
                    finally
                    {
                        Response.Write("<script>window.parent.document.getElementsByClassName('dataTables_processing')[0].style.display='none';</script>");
                    }
                }
            }
        }
    }
}