﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SupportApplication.Models;
using SupportApplication.Repositories;

namespace SupportApplication.Controllers
{
    public class MessagesController : Controller
    {

        private readonly MessagesRepository messagesRepository;

        public MessagesController(MessagesRepository messagesRepository)
        {
            this.messagesRepository = messagesRepository;
        }



        // GET: MesaggesController
        public ActionResult Index()
        {
            var model = messagesRepository.GetAllMessages();

            return View(model);
        }

        // GET: MesaggesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MesaggesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MesaggesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Messages message)
        {
            try
            {
                messagesRepository.Add(message);


                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MesaggesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MesaggesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MesaggesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MesaggesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
