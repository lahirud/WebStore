using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using WebStore.Controllers;
using WebStore.Models;
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
    }
}
