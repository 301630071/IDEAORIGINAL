using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class CampusBLL
    {
        public static List<Campus> cargarComboBox()
        {
            return DataAccessLayer.CampusDAL.cargarComboBox();
        }
    }
}
