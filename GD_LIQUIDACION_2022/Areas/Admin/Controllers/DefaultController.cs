using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GD_LIQUIDACION_2022.Areas.Admin.Controllers
{
    [Route("Admin")]
    public class DefaultController : Controller
    {
        private readonly Models.REM_MUN.REM_MUN REM_MUN_DB = new Models.REM_MUN.REM_MUN();
        private readonly Models.REM_MUN_PAE.REM_MUN_PAE REM_MUN_PAE_DB = new Models.REM_MUN_PAE.REM_MUN_PAE();
        private readonly Models.INFORMES.Informes INFORMES_DB = new Models.INFORMES.Informes();

        public ActionResult Plantas()
        {
            ViewBag.TotalPlanta = (from FichaFuncionario in REM_MUN_DB.FichaFuncionarios
                                   join FichaMunicipal in REM_MUN_DB.FichaMunicipals on FichaFuncionario.Id_Funcionario equals FichaMunicipal.Id_Funcionario
                                   where FichaMunicipal.TipoCargo == 0 & FichaFuncionario.Activo == 0
                                   select FichaFuncionario.Id_Funcionario);
            return View();
        }


        // GET: Admin/Default
        public ActionResult Index()
        {
            return View();
        }

        // GET: Admin/Default/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/Default/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Default/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Default/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/Default/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Default/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/Default/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        private string GetTipoProceso(int TipoProceso)
        {
            string TipoProcesoAux = string.Empty;
            switch (TipoProceso)
            {
                case 0:
                    {
                        TipoProcesoAux = "PLANTAS";
                        break;
                    }

                case 1:
                    {
                        TipoProcesoAux = "CONTRATAS";
                        break;
                    }

                case 2:
                    {
                        TipoProcesoAux = "HONORARIOS";
                        break;
                    }

                case 3:
                    {
                        TipoProcesoAux = "COD";
                        break;
                    }

                case 4:
                    {
                        TipoProcesoAux = "PGE";
                        break;
                    }
            }

            return TipoProcesoAux;
        }
    }
}
