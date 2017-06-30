using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using common.Model;

namespace Asiri_ERP.Controllers.RRHH
{
    public class PacienteController : Controller
    {
        private AsiriContext db = new AsiriContext();

        // GET: Paciente
        public ActionResult Index()
        {
            var rHUt07_paciente = db.RHUt07_paciente.Include(r => r.RHUt09_persona);
            return View(rHUt07_paciente.ToList());
        }

        // GET: Paciente/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RHUt07_paciente rHUt07_paciente = db.RHUt07_paciente.Find(id);
            if (rHUt07_paciente == null)
            {
                return HttpNotFound();
            }
            return View(rHUt07_paciente);
        }

        // GET: Paciente/Create
        public ActionResult Create()
        {
            ViewBag.idPersona = new SelectList(db.RHUt09_persona, "idPersona", "tipoPersoneria");
            return View();
        }

        // POST: Paciente/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idPaciente,codPaciente,numHistoriaClinica,grupoSanguineo,activo,fecRegistro,fecModificacion,fecEliminacion,idUsuario,idUsuarioModificar,idUsuarioEliminar,idPersona")] RHUt07_paciente rHUt07_paciente)
        {
            if (ModelState.IsValid)
            {
                db.RHUt07_paciente.Add(rHUt07_paciente);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.idPersona = new SelectList(db.RHUt09_persona, "idPersona", "tipoPersoneria", rHUt07_paciente.idPersona);
            return View(rHUt07_paciente);
        }

        // GET: Paciente/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RHUt07_paciente rHUt07_paciente = db.RHUt07_paciente.Find(id);
            if (rHUt07_paciente == null)
            {
                return HttpNotFound();
            }
            ViewBag.idPersona = new SelectList(db.RHUt09_persona, "idPersona", "tipoPersoneria", rHUt07_paciente.idPersona);
            return View(rHUt07_paciente);
        }

        // POST: Paciente/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idPaciente,codPaciente,numHistoriaClinica,grupoSanguineo,activo,fecRegistro,fecModificacion,fecEliminacion,idUsuario,idUsuarioModificar,idUsuarioEliminar,idPersona")] RHUt07_paciente rHUt07_paciente)
        {
            if (ModelState.IsValid)
            {
                db.Entry(rHUt07_paciente).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.idPersona = new SelectList(db.RHUt09_persona, "idPersona", "tipoPersoneria", rHUt07_paciente.idPersona);
            return View(rHUt07_paciente);
        }

        // GET: Paciente/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RHUt07_paciente rHUt07_paciente = db.RHUt07_paciente.Find(id);
            if (rHUt07_paciente == null)
            {
                return HttpNotFound();
            }
            return View(rHUt07_paciente);
        }

        // POST: Paciente/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            RHUt07_paciente rHUt07_paciente = db.RHUt07_paciente.Find(id);
            db.RHUt07_paciente.Remove(rHUt07_paciente);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
