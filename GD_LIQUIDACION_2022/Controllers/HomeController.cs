using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace GD_LIQUIDACION_2022.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        // 'POST: Login
        [HttpPost()]
        [ValidateAntiForgeryToken()]
        public ActionResult Index([Bind(Include = "Usuario,Password")] Home.Models.Login LoginModel)
        {
            var WebLogin = new WebLogin.loginSoapClient();
            if (ModelState.IsValid)
            {
                try
                {
                    string Usuario = WebLogin.recibe_datos_usuario(LoginModel.Usuario, LoginModel.Password);
                    string ErrorLogin = Strings.InStr(Usuario, "Error").ToString();
                    if (Conversions.ToDouble(ErrorLogin) == 0)
                    {
                        {
                            var withBlock = Session;
                            withBlock.Add("Usuario", Usuario.Split().GetValue(0));
                            withBlock.Add("NombreUsuario", Usuario.Split().GetValue(1));
                            withBlock.Timeout = 666;
                        }

                        return RedirectToAction("Index", "Default", new { area = "Admin" });
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "Usuario o Contraseña incorrectas");
                    }
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError(string.Empty, ex.ToString());
                }
            }

            return View();
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}