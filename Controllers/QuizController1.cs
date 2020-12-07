using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.Models;
using FinalProject.Repos;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
    public class QuizController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }



        public IActionResult Vquiz()
        {
            QuizTools model = new QuizTools();
            return View(model);

        }

      

        [HttpPost]
        public IActionResult Vquiz(QuizTools model)
        {
            var quizModel = new QuizModel();//new instance of quiz model.
            if (model.Season == "winter")
            {
                quizModel.QuizToolInstance = model;// accessing the data entered from quiztools instancw. 
                // from the quiz model.
                quizModel.Score = 5;// change score. replace score with int in own table.
            }

            model.Score = quizModel.Score;
            //var repo = new FinalContext();
            //repo.QuizResults.Add(quizModel);
            //repo.SaveChanges();

            return View(model);
        }

        public IActionResult QuizResult() 
        {
            return View();
        }
    }
}
