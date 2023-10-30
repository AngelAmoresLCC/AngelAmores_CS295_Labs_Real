using CommunityOfMars.Controllers;
using CommunityOfMars.Models;
using Microsoft.AspNetCore.Mvc;

namespace MarsTests
{
	public class QuizTests
	{
		[Fact]
		public void TestLoadQuestions()
		{
			//Arrange
			var controller = new QuizController();
			var model = new Quizzes();

			//Act
			var loadedModel = controller.LoadQuestions(model);

			//Assert
			Assert.NotNull(controller.Questions);
			Assert.NotEmpty(controller.Questions);
			Assert.NotNull(controller.Answers);
			Assert.NotEmpty(controller.Answers);
			Assert.NotNull(loadedModel.Questions);
			Assert.NotEmpty(loadedModel.Questions);
			Assert.NotNull(loadedModel.Answers);
			Assert.NotEmpty(loadedModel.Answers);
			Assert.Equal(controller.Questions, loadedModel.Questions);
			Assert.Equal(controller.Answers, loadedModel.Answers);
		}
	}
}