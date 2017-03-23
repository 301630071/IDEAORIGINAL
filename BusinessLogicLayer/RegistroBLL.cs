using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class RegistroBLL
    {
        public static bool MandarRegistro(bool tipoRegistro, string matricula)
        {
            return DataAccessLayer.RegistroDAL.MandarRegistro(tipoRegistro, matricula);
        }
    }
}
