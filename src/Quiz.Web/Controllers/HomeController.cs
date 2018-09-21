using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Quiz.Core.Entities;
using Quiz.Core.Interfaces;
using Quiz.Web.Models;

namespace Quiz.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAsyncRepository<Question> _questionRepository;
        private readonly IAsyncRepository<QuestionCategory> _questionCategoryRepository;
        private readonly IAsyncRepository<QuestionOption> _questionOptionRepository;
        private readonly IAsyncRepository<QuestionAnswer> _questionAnswerRepository;
        public HomeController(
            IAsyncRepository<Question> questionRepository,
            IAsyncRepository<QuestionCategory> questionCategoryRepository,
            IAsyncRepository<QuestionOption> questionOptionRepository,
            IAsyncRepository<QuestionAnswer> questionAnswerRepository
            )
        {
            this._questionRepository = questionRepository;
            this._questionAnswerRepository = questionAnswerRepository;
            this._questionCategoryRepository = questionCategoryRepository;
            this._questionOptionRepository = questionOptionRepository;
        }
        public async Task<IActionResult> Index()
        {
            var questionCategories = await _questionCategoryRepository.ListAllAsync();
            return View(questionCategories);
        }

        public IActionResult About(int id)
        {
            ViewData["Message"] = "Your application description page." + id;

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
