using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PedidosOnline.Models;
using PedidosOnline.Utilidades;

namespace PedidosOnline.Controllers
{
    public class PerfilController : Controller
    {
        PedidosOnlineEntities db = new PedidosOnlineEntities();
        [CheckSessionOut]
        public ActionResult Usuarios()
        {
            List<Usuario> Lista = db.Usuario.ToList();
            return View(Lista);
        }
        [CheckSessionOut]
        public ActionResult Usuario(int? rowid)
        {
            Usuario user = new Usuario();
            if (rowid>0)
            {
                user = db.Usuario.Where(f => f.RowID == rowid).FirstOrDefault();
            }
            return View(user);
        }
        [HttpPost]
        public JsonResult Usuario_()
        {
            try
            {
                int rowid=int.Parse(Request.Params["rowid"]);
                //form = DeSerialize(form);
                Usuario usuario = db.Usuario.Where(f => f.RowID == rowid).FirstOrDefault();


                if (usuario == null)
                {
                    usuario = new Usuario();
                    usuario.FechaCreacion = UtilTool.GetDateTime();
                    usuario.UsuarioCreacion = ((Usuario)Session["curUser"]).NombreUsuario;
                    
                }
                else
                {
                    usuario.FechaActualizacion = UtilTool.GetDateTime();
                    usuario.UsuarioActualizacion = ((Usuario)Session["curUser"]).NombreUsuario;
                }
                usuario.Contraseña = UtilTool.CryptPasswd(Request.Params["clave"].ToString(), Constantes.CryptString);
                usuario.NombreUsuario = Request.Params["nombre_usuario"];
                int estado = Convert.ToInt16(Request.Params["ind_activo"]);
                if (estado == 1)
                {
                    usuario.Activo = true;
                }
                else
                {
                    usuario.Activo = false;
                }
                if (rowid == null || rowid <= 0)
                    db.Usuario.Add(usuario);


                db.SaveChanges();


                return Json(usuario.RowID);
            }
            catch (Exception e)
            {
                Response.StatusCode = 500;
                Response.StatusDescription = "Error: " + e.Message.ToString();
                return Json("Se presento un problema al almacenar la información");
            }
        }
	}
}