using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace TestApp.Models.Database
{
    public class DbContext
    {
        public List<string> getUsuarios()
        {
            var userList = new List<string>();
            using (var db = new TestEntities())
            {
                var users = from u in db.usuarios
                            orderby u.nombre
                            select u;

                foreach (var user in users)
                {
                    var aux = string.Format("Nombre: {0} Apellido: {1} Email: {2}", user.nombre, user.apellido, user.email);
                    userList.Add(aux);
                }
            }
            return userList;
        }
    }
}