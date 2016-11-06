using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZooApp.Models;
using ZooApp.Services;
using ZooApp.ViewModels;

namespace ZooApp.MvcClient.Controllers
{
    public class AnimalController : Controller
    {
        AnimalService animalService = new AnimalService();
        // GET: Animal
        public ActionResult Index()
        {
            
            var viewAnimals =  animalService.GetAnimals();
            return View(viewAnimals);
        }


        public ActionResult Details(int id)
        {
           ViewAnimal animal = animalService.GetAnimal(id);

            return View(animal);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Animal animal)
        {
            bool saved = animalService.Save(animal);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
           Animal animal = animalService.GetDbAnimal(id);
            return View(animal);
        }
        [HttpPost]
        public ActionResult Edit(Animal animal)
        {
            bool saved = animalService.Update(animal);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
           Animal animal = animalService.GetDbAnimal(id);
            return View(animal);
        }
        [HttpPost]
        public ActionResult Delete(Animal animal)
        {
            bool saved = animalService.Delete(animal);
            return RedirectToAction("Index");
        }
    }
}