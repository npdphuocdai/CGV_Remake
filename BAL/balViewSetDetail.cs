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
        public List<dtoViewSetDetail> GetViewSetDetails()
        {
            dalViewSetDetail ViewSetDetail = new dalViewSetDetail();
            List<dtoViewSetDetail> listSet = new List<dtoViewSetDetail>();
            DataTable setDetails = ViewSetDetail.GetViewSetDetails();
            for(int i=0; i< setDetails.Rows.Count; i++)
            {
                dtoViewSetDetail setdetail = new dtoViewSetDetail();
                DataRow row = setDetails.Rows[i];
                setdetail.FilmName = row[0].ToString();
                setdetail.StartTime = Convert.ToDateTime(row[1]);
                listSet.Add(setdetail);
            }
            return listSet;
        }
    }
}
