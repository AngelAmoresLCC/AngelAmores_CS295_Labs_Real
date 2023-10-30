using Microsoft.AspNetCore.Mvc;
using CommunityOfMars.Models;

namespace CommunityOfMars.Controllers
{
	public class QuizController : Controller
	{
		public Dictionary<int, string> Questions { get; set; }
		public Dictionary<int, string> Answers { get; set; }
		public IActionResult Index()
		{
			return View();
		}

		public Quizzes LoadQuestions(Quizzes model)
		{
			// Temporary set of hard-coded questions
			// In the future, these will be read in from a file
			/*Questions.Add(1, "The correct answer is 5");
			Answers.Add(1, "5");
			Questions.Add(2, "The correct answer is winter");
			Answers.Add(2, "Winter");*/
			//TODO: load questions and answers into the model
			/*model.Questions = Questions;
			model.Answers = Answers;*/
			return model;
		}
	}
}
