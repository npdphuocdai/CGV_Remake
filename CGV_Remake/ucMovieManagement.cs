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
using BAL;
using DTO;

namespace Viewer
{
    public partial class ucMovieManagement : DevExpress.XtraEditors.XtraUserControl
    {
        public ucMovieManagement()
        {
            InitializeComponent();
            BindingData();
        }
        balFilm balFilm = new balFilm();
        balGenre balGenre = new balGenre();
        private static ucMovieManagement _instance;
        public static ucMovieManagement Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucMovieManagement();
                }
                return _instance;
            }
        }
        public void BindingData()
        {
            DataSource.DataSource = balFilm.GetFilms();
            DataSourceGenre.DataSource = balGenre.GetGenres();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                dtoFilms dtoFilms = new dtoFilms();
                dtoFilms = dgvViewFilm.GetFocusedRow() as dtoFilms;
                if (dtoFilms.FilmName == "" || dtoFilms.Duration.ToString() == "" || dtoFilms.ReleaseDate.ToString() == "" || dtoFilms.StopDate.ToString() == "" || dtoFilms.GenreID.ToString() == "")
                {
                    throw new Exception("Vui lòng không để trống thông tin!");
                }
                else
                {
                    int count = balFilm.Update(dtoFilms);
                    XtraMessageBox.Show("Cập nhập thông tin movie thành công! \nSố hàng đã được cập nhập: " + count.ToString(), "Succesful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFilmName.Text == "" || txtGenre.Text == "" || dteReleaseDate.Text == "" || dteStopDate.Text == "" || tseDuration.Text == "" )
                {
                    throw new Exception("Vui lòng nhập đầy đủ thông tin!");
                }
                else
                {
                    dtoFilms dtoFilms = new dtoFilms();
                    dtoFilms.FilmName = txtFilmName.Text;
                    dtoFilms.GenreID = Convert.ToInt32(txtGenre.Text);
                    dtoFilms.Duration = tseDuration.TimeSpan;
                    dtoFilms.ReleaseDate = dteReleaseDate.DateTime;
                    dtoFilms.StopDate = dteStopDate.DateTime;
                    int count = balFilm.Insert(dtoFilms);
                    txtFilmName.Text = "";
                    txtGenre.Text = "";
                    dteReleaseDate.Text = "";
                    dteStopDate.Text = "";
                    tseDuration.Text = "";
                    BindingData();
                    string mess = "Thông tin khách hàng đã được thêm thành công!" + "\nSố hàng đã được thêm: " + count.ToString();
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
