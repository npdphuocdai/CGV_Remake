using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class dalSetDetail : DatabaseServices
    {
        public List<dtoSetDetail> GetSetDetails()
        {
            List<dtoSetDetail> setDetails = new List<dtoSetDetail>();
            try
            {
                string sql = "SELECT * FROM [dbo].[SetDetail]";
                SqlDataReader reader = ReadData(sql);
                while (reader.Read())
                {
                    dtoSetDetail setDetail = new dtoSetDetail();
                    setDetail.FilmID = Convert.ToInt32((dtoSetDetail)reader[0]);
                    setDetail.SetID = Convert.ToInt32((dtoSetDetail)reader[1]);
                    setDetail.TotalSeats = Convert.ToInt32((dtoSetDetail)reader[2]);
                    setDetail.TotalEmptySeats = Convert.ToInt32((dtoSetDetail)reader[3]);
                    setDetail.ShowingDate = Convert.ToDateTime((dtoSetDetail)reader[4]);
                    setDetail.RoomID = Convert.ToInt32((dtoSetDetail)reader[5]);
                    setDetails.Add(setDetail);
                }
                reader.Close();
            }
            finally
            {
                CloseConnection();
            }
            return setDetails;
        }
    }
}
