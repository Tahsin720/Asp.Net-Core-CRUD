using Medic_App.Data;
using Medic_App.Models;
using Microsoft.AspNetCore.Mvc;

namespace Medic_App.Controllers

{
    public class MedicInfoController : Controller
    {
        private readonly ApplicationDbContext _db; 
        public MedicInfoController(ApplicationDbContext db)
        {
            _db = db;  
        }
        public IActionResult Index()
        {
            IEnumerable<Medic_Info> objInfo = _db.Medic_Infos;
            return View(objInfo);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Medic_Info obj)
        {
            if (ModelState.IsValid)
            {
                _db.Medic_Infos.Add(obj);
                _db.SaveChanges();
                return Redirect("Index");
            }
            return View(obj);
         
        }

        public IActionResult Edit(int? id)
        {
            if(id == null || id == 0)
            {
                return NotFound();
            }
            var Medic_Info = _db.Medic_Infos.Find(id);
            if (Medic_Info == null)
            {
                return NotFound(Medic_Info);
            }
            return View(Medic_Info); 
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Medic_Info obj)
        {
            if (ModelState.IsValid)
            {
                _db.Medic_Infos.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var Medic_Info = _db.Medic_Infos.Find(id);
            
            if (Medic_Info == null)
            {
                return NotFound(Medic_Info);
            }
            _db.Medic_Infos.Remove(Medic_Info);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
