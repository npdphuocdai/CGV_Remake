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
    class balShowingSet
    {
        public List<dtoShowingSet> GetShowingSets()
        {
            dalShowingSet dalShowingSet = new dalShowingSet();
            List<dtoShowingSet> listEmp = new List<dtoShowingSet>();
            DataTable ShowingSets = dalShowingSet.GetShowingSets();
            for (int i = 0; i < ShowingSets.Rows.Count; i++)
            {
                dtoShowingSet ShowingSet = new dtoShowingSet();
                DataRow row = ShowingSets.Rows[i];
                ShowingSet.SetID = Convert.ToInt32(row[0]);
                ShowingSet.StartTime = Convert.ToDateTime(row[1]);
                ShowingSet.EndTime = Convert.ToDateTime(row[2]);
                listEmp.Add(ShowingSet);
            }
            return listEmp;
        }
    }
}
