using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto.container;
using Projeto.Models;

namespace Projeto.Controllers
{
    public class HomeController : Controller
    {
        private readonly IClienteContainer clienteContainer;

        public HomeController(IClienteContainer clienteContainer)
        {
            this.clienteContainer = clienteContainer;
        }

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Cliente cliente)
        {
            try
            {
                this.clienteContainer.Add(cliente);
                return RedirectToAction(nameof(List));
            }
            catch
            {
                return View();
            }
        }

        // GET: Home/Edit/5
        public ActionResult Edit(int id)
        {
            return View(this.clienteContainer.Pesquisar(id));
        }

        // POST: Home/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Cliente cliente)
        {
            try
            {
                this.clienteContainer.Editar(cliente);
                // TODO: Add update logic here
                return RedirectToAction(nameof(List));
            }
            catch
            {
                return View();
            }
        }

        // GET: Home/Delete/5
        public ActionResult Delete(int id)
        {
            return View(this.clienteContainer.Pesquisar(id));
        }

        // POST: Home/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Del(Cliente cliente)
        {
            try
            {
                cliente = this.clienteContainer.Pesquisar(cliente.Id);
                this.clienteContainer.Delete(cliente);
                return RedirectToAction(nameof(List));
            }
            catch
            {
                return View();
            }
        }

        [HttpGet]
        public ActionResult List()
        {
            try
            {
                var resultado = this.clienteContainer.list();
                return View(resultado);
            }
            catch
            {
                return View();
            }
        }

    }
}