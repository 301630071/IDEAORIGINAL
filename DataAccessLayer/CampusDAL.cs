using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class CampusDAL
    {
        //genera la conexión a la base de datos.
        private static IdeaContext db = new IdeaContext();

        //generar metodo estadico que me regrese una lista con la etiqueta brand.
        public static List<Campus> cargarComboBox()
        {
            //mandas a llamar la cadena de conexión
            return db.Campus.ToList();
        }
    }
}
