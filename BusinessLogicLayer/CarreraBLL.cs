using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class CarreraBLL
    {
        public static List<Carrera> cargarComboBox()
        {
            return DataAccessLayer.CarreraDAL.cargarComboBox();
        }
    }
}
