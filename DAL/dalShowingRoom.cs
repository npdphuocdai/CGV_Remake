﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    class dalShowingRoom : DatabaseServices
    {
        public List<dtoShowingRoom> GetListRooms()
        {
            List<dtoShowingRoom> rooms = new List<dtoShowingRoom>();
            try
            {
                string sql = "SELECT * FROM [dbo].[ShowingRoom]";
                SqlDataReader reader = ReadData(sql);
                while (reader.Read())
                {
                    dtoShowingRoom room = new dtoShowingRoom();
                    room.RoomID = Convert.ToInt32((dtoShowingSet)reader[0]);
                    room.RoomType = ((dtoShowingSet)reader[1]).ToString();
                    room.NumberOfSeats = Convert.ToInt32((dtoShowingSet)reader[2]);
                    rooms.Add(room);
                }
                reader.Close();
            }
            finally
            {
                CloseConnection();
            }
            return rooms;
        }
        /// <summary>
        /// Hàm thêm phòng chiếu
        /// </summary>
        /// <param name="room"></param>
        /// <returns></returns>
        public int InsertShowingRoom(dtoShowingRoom room)
        {
            int count = 0;
            try
            {
                string sql = "INSERT [dbo].[ShowingRoom] ([RoomType], [NumberOfSeats]) VALUES ( @RoomType, @NumberOfSeats)";
                SqlParameter parameterRoomType = new SqlParameter("@RoomType", SqlDbType.NVarChar);
                parameterRoomType.Value = room.RoomType;
                SqlParameter parameterNumberOfSeats = new SqlParameter("@NumberOfSeats", SqlDbType.Int);
                parameterNumberOfSeats.Value = room.NumberOfSeats;
                count = InsertUpdateDeleteData(sql, new[] { parameterRoomType, parameterNumberOfSeats });
            }
            finally
            {
                CloseConnection();
            }
            return count;
        }
        /// <summary>
        /// Hàm cập nhập phòng chiếu
        /// </summary>
        /// <param name="room"></param>
        /// <returns></returns>
        public int UpdateShowingRoom(dtoShowingRoom room)
        {
            int count = 0;
            try
            {
                string sql = "UPDATE [dbo].[ShowingRoom] SET [RoomType] = @RoomType, [NumberOfSeats] = @NumberOfSeats WHERE [RoomID] = @RoomID";
                SqlParameter parameterRoomID = new SqlParameter("@RoomID", SqlDbType.Int);
                parameterRoomID.Value = room.RoomID;
                SqlParameter parameterRoomType = new SqlParameter("@RoomType", SqlDbType.NVarChar);
                parameterRoomType.Value = room.RoomType;
                SqlParameter parameterNumberOfSeats = new SqlParameter("@NumberOfSeats", SqlDbType.Int);
                parameterNumberOfSeats.Value = room.NumberOfSeats;
                count = InsertUpdateDeleteData(sql, new[] { parameterRoomType, parameterNumberOfSeats });
            }
            finally
            {
                CloseConnection();
            }
            return count;
        }
    }
}