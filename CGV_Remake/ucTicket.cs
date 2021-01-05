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

namespace Viewer
{
    public partial class ucTicket : DevExpress.XtraEditors.XtraUserControl
    {
        public ucTicket()
        {
            InitializeComponent();
        }
        private static ucTicket _instance;
        public static ucTicket Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucTicket();
                }
                return _instance;
            }
        }
        private void ucTicket_Load(object sender, EventArgs e)
        {
            grcSelectMovie.Height = Convert.ToInt32(layTicket.Height * 0.2);
            layLueMovie.Height = Convert.ToInt32(layGrSelectMovie.Height * 0.5);
            layLueShowingset.Height = Convert.ToInt32(layGrSelectMovie.Height * 0.5);
            layBtnSelect.Height = Convert.ToInt32(layLueMovie.Height + layLueShowingset.Height);
        }

        private void ucTicket_Resize(object sender, EventArgs e)
        {
            grcSelectMovie.Height = Convert.ToInt32(layTicket.Height * 0.2);
            layLueMovie.Height = Convert.ToInt32(layGrSelectMovie.Height * 0.5);
            layLueShowingset.Height = Convert.ToInt32(layGrSelectMovie.Height * 0.5);
            layBtnSelect.Height = Convert.ToInt32(layLueMovie.Height + layLueShowingset.Height);
        }
    }
}
