using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

namespace BAL
{
    public class balViewSetDetail
    {
        public List<dtoViewSetDetail> GetSetDetails()
        {
            dalViewSetDetail ViewSetDetail = new dalViewSetDetail();
            List<dtoViewSetDetail> listSetFilm = new List<dtoViewSetDetail>();
            DataTable setDetails = ViewSetDetail.GetViewSetDetails();
            for (int i = 0; i < setDetails.Rows.Count; i++)
            {
                dtoViewSetDetail setdetail = new dtoViewSetDetail();
                DataRow row = setDetails.Rows[i];
                setdetail.FilmID = Convert.ToInt32(row[0]);
                setdetail.FilmName = row[1].ToString(); ;
                setdetail.SetID = Convert.ToInt32(row[2]);
                setdetail.StartTime = row[3].ToString();
                listSetFilm.Add(setdetail);
            }
            return listSetFilm;
        }
        public List<dtoViewSetDetailFilmName> GetViewSetFilmNameDetails()
        {
            dalViewSetDetail ViewSetDetail = new dalViewSetDetail();
            List<dtoViewSetDetailFilmName> listSetFilm = new List<dtoViewSetDetailFilmName>();
            DataTable setDetails = ViewSetDetail.GetViewSetDetails();
            for(int i=0; i< setDetails.Rows.Count; i++)
            {
                dtoViewSetDetailFilmName setdetail = new dtoViewSetDetailFilmName();
                DataRow row = setDetails.Rows[i];
                setdetail.FilmID = Convert.ToInt32(row[0]);
                setdetail.FilmName = row[1].ToString();;
                listSetFilm.Add(setdetail);
            }
            return listSetFilm;
        }
        public List<dtoViewSetDetailStartTime> GetViewSetStartTimeDetails()
        {
            dalViewSetDetail ViewSetDetail = new dalViewSetDetail();
            List<dtoViewSetDetailStartTime> listSetStart = new List<dtoViewSetDetailStartTime>();
            DataTable setDetails = ViewSetDetail.GetViewSetDetails();
            for (int i = 0; i < setDetails.Rows.Count; i++)
            {
                dtoViewSetDetailStartTime setdetail = new dtoViewSetDetailStartTime();
                DataRow row = setDetails.Rows[i];
                setdetail.SetID = Convert.ToInt32(row[2]);
                setdetail.StartTime = row[3].ToString();
                listSetStart.Add(setdetail);
            }
            return listSetStart;
        }
    }
}
