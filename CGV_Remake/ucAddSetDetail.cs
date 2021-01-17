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
using BAL;

namespace Viewer
{
    public partial class ucAddSetDetail : DevExpress.XtraEditors.XtraUserControl
    {
        public ucAddSetDetail()
        {
            InitializeComponent();
            BindingData();
        }
        balFilm balFilm = new balFilm();
        balSetDetail balSetDetail = new balSetDetail();
        balShowingSet balShowingSet = new balShowingSet();
        private static ucAddSetDetail _instance;
        public static ucAddSetDetail Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucAddSetDetail();
                }
                return _instance;
            }
        }
        public void BindingData()
        {
            DataSource.DataSource = balSetDetail.GetSetDetails();
            DataSourceFilm.DataSource = balFilm.GetFilms();
            DataSourceSet.DataSource = balShowingSet.GetShowingSets();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFilmID.Text == "" || txtRoomID.Text == "" || txtSetID.Text == "" || txtTotalSeats.Text == "" || dteShowingDate.Text == "")
                {
                    throw new Exception("Vui lòng nhập đầy đủ thông tin!");
                }
                else
                {
                    dtoSetDetail dtoSet = new dtoSetDetail();
                    dtoSet.FilmID = Convert.ToInt32(txtFilmID.Text);
                    dtoSet.SetID = Convert.ToInt32(txtSetID.Text);
                    dtoSet.RoomID = Convert.ToInt32(txtRoomID.Text);
                    dtoSet.ShowingDate = dteShowingDate.DateTime;
                    dtoSet.TotalEmptySeats = Convert.ToInt32(txtTotalSeats.Text);
                    dtoSet.TotalSeats = 0;
                    int count = balSetDetail.Insert(dtoSet);
                    txtFilmID.Text = "";
                    txtSetID.Text = "";
                    txtRoomID.Text = "";
                    txtTotalSeats.Text = "";
                    dteShowingDate.Text = "";
                    BindingData();
                    string mess = "Thông tin xuất chiếu đã được thêm thành công!" + "\nSố hàng đã được thêm: " + count.ToString();
                    XtraMessageBox.Show(mess, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
