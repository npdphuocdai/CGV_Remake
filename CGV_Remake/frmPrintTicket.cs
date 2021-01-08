using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using DevExpress.XtraReports.Parameters;

namespace Viewer
{
    public partial class frmPrintTicket : DevExpress.XtraEditors.XtraForm
    {
        public frmPrintTicket()
        {
            InitializeComponent();
        }
        public void PrintTicket(dtoViewTicket ticket)
        {
            rptTicket rptTicket = new rptTicket();
            foreach(Parameter p in rptTicket.Parameters)
            {
                p.Visible = false;
            }
            rptTicket.InitData(ticket);
            docViewTicket.DocumentSource = rptTicket;
            rptTicket.CreateDocument();
        }
    }
}