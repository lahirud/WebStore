using Microsoft.AspNetCore.Mvc;
using Moq;
using System.Collections.Generic;
using WebStore.Controllers;
using WebStore.Models;
using WebStore.ViewModels;
using Xunit;

namespace WebStoreUnitTests
{
    public class FeedbackControllerTest
    {
        private Mock<IFeedbackRepository> feedbackRepository;
        private FeedbackController controller;

        public FeedbackControllerTest()
        {
            feedbackRepository = new Mock<IFeedbackRepository>();
            controller = new FeedbackController(feedbackRepository.Object);
        }

        [Fact]
        public void GetIndexShouldReturnOk()
        {
            // act
            var okResult = controller.Index();

            // assert
            Assert.IsType<ViewResult>(okResult);
        }

        [Fact]
        public void GetIndexShouldReturnFeedbacks()
        {
            // arrange
            List<Feedback> feedbacks = new List<Feedback>(){
                new Feedback{FeedbackId=1, Email="test1@test.com", Name = "Test1", Message = "Test Message 1"},
                new Feedback{FeedbackId=2, Email="test2@test.com", Name = "Test2", Message = "Test Message 2"},
                new Feedback{FeedbackId=3, Email="test3@test.com", Name = "Test3", Message = "Test Message 3"},
            };

            feedbackRepository.Setup(repo => repo.GetAll()).Returns(feedbacks);

            // act
            var okResult = controller.Index() as ViewResult;
            var viewModel = okResult.ViewData.Model as FeedbackViewModel;

            // assert
            var feedbackList = (viewModel.Feedbacks) as List<Feedback>;
            Assert.Equal(3, feedbackList.Count);
        }
        
        [Fact]
        public void AddFeedbackShouldReturnOk()
        {
            // arrange
            var feedback = new Feedback{FeedbackId=1, Email="test1@test.com", Name = "Test1", Message = "Test Message 1"};

            // act
            var okResult = controller.Index(feedback);

            // assert
            Assert.IsType<RedirectToActionResult>(okResult);
        }
        
        [Fact]
        public void AddFeedbackShouldValidateEmail()
        {
            // arrange
            var feedback = new Feedback{FeedbackId=1, Email="test1", Name = "Test1", Message = "Test Message 1"};

            // act
            controller.ModelState.AddModelError("Email", "The email address is not entered in a correct format");
            var okResult = controller.Index(feedback) as ViewResult;

            // assert
            Assert.Equal(1, okResult.ViewData.ModelState.ErrorCount);
        }
    }
}
