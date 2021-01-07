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
    public class balShowingRoom
    {
        public List<dtoShowingRoom> GetShowingRooms()
        {
            dalShowingRoom dalShowingRoom = new dalShowingRoom();
            List<dtoShowingRoom> listEmp = new List<dtoShowingRoom>();
            DataTable ShowingRooms = dalShowingRoom.GetShowingRooms();
            for (int i = 0; i < ShowingRooms.Rows.Count; i++)
            {
                dtoShowingRoom ShowingRoom = new dtoShowingRoom();
                DataRow row = ShowingRooms.Rows[i];
                ShowingRoom.RoomID = Convert.ToInt32(row[0]);
                ShowingRoom.RoomType = row[1].ToString();
                ShowingRoom.NumberOfSeats = Convert.ToInt32(row[2]);
                listEmp.Add(ShowingRoom);
            }
            return listEmp;
        }
    }
}
