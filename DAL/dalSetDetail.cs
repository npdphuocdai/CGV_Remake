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
        public DataTable GetSetDetails()
        {
            DataTable setDetails = new DataTable();
            try
            {
                string sql = "SELECT * FROM [dbo].[SetDetail]";
                SqlDataAdapter adapter = Adapter(sql);
                if (adapter != null)
                {
                    adapter.Fill(setDetails);
                }
            }
            finally
            {
                CloseConnection();
            }
            return setDetails;
        }
        public int Insert(dtoSetDetail dtoSetDetail)
        {
            int count = 0;
            try
            {
                string sql = "INSERT [dbo].[SetDetail] ([FilmID], [SetID], [RoomID], [TotalSeats], [TotalEmptySeats], [ShowingDate]) VALUES (@FilmID, @SetID, @RoomID, @TotalSeats, @TotalEmptySeats, @ShowingDate)";
                SqlParameter parameterFilmID = new SqlParameter("@FilmID", SqlDbType.Int);
                parameterFilmID.Value = dtoSetDetail.FilmID;
                SqlParameter parameterSetID = new SqlParameter("@SetID", SqlDbType.Int);
                parameterSetID.Value = dtoSetDetail.SetID;
                SqlParameter parameterRoomID = new SqlParameter("@RoomID", SqlDbType.Int);
                parameterRoomID.Value = dtoSetDetail.RoomID;
                SqlParameter parameterTotalSeats = new SqlParameter("@TotalSeats", SqlDbType.Int);
                parameterTotalSeats.Value = dtoSetDetail.TotalSeats;
                SqlParameter parameterTotalEmptySeats = new SqlParameter("@TotalEmptySeats", SqlDbType.Int);
                parameterTotalEmptySeats.Value = dtoSetDetail.TotalEmptySeats;
                SqlParameter parameterShowingDate = new SqlParameter("@ShowingDate", SqlDbType.DateTime);
                parameterShowingDate.Value = dtoSetDetail.ShowingDate;
                count = InsertUpdateDeleteData(sql, new[] { parameterFilmID, parameterSetID, parameterRoomID, parameterTotalSeats, parameterTotalEmptySeats, parameterShowingDate });
            }
            finally
            {
                CloseConnection();
            }
            return count;
        }
    }
}
