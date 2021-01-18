using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;


namespace BAL
{
    public class balSetDetail
    {
        public List<dtoSetDetail> GetSetDetails()
        {
            dalSetDetail dalSetDetail = new dalSetDetail();
            List<dtoSetDetail> listEmp = new List<dtoSetDetail>();
            DataTable SetDetails = dalSetDetail.GetSetDetails();
            for (int i = 0; i < SetDetails.Rows.Count; i++)
            {
                dtoSetDetail SetDetail = new dtoSetDetail();
                DataRow row = SetDetails.Rows[i];
                SetDetail.FilmID = Convert.ToInt32(row[0]);
                SetDetail.SetID = Convert.ToInt32(row[1]);
                SetDetail.TotalSeats = Convert.ToInt32(row[2]);
                SetDetail.TotalEmptySeats = Convert.ToInt32(row[3]);
                SetDetail.ShowingDate = Convert.ToDateTime(row[4]);
                SetDetail.RoomID = Convert.ToInt32(row[5]);
                listEmp.Add(SetDetail);
            }
            return listEmp;
        }
        public int GetRoomID(int filmID, int setID)
        {
            int roomID = -1;
            dalSetDetail dal = new dalSetDetail();
            DataTable data = dal.GetSetDetails();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                DataRow row = data.Rows[i];
                if(Convert.ToInt32(row[0]) == filmID && Convert.ToInt32(row[1]) == setID)
                {
                    roomID = Convert.ToInt32(row[5]);
                }
            }
            return roomID;
        }
        public int Insert(dtoSetDetail dtoSetDetail)
        {
            dalSetDetail dal = new dalSetDetail();
            int count = dal.Insert(dtoSetDetail);
            return count;
        }
    }
}
