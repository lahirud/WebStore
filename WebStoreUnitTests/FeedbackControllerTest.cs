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
        }

        [Fact]
        public void GetIndexShouldReturnOk()
        {
        }

        [Fact]
        public void GetIndexShouldReturnFeedbacks()
        {
        }
        
        [Fact]
        public void AddFeedbackShouldReturnOk()
        {
        }
        
        [Fact]
        public void AddFeedbackShouldValidateEmail()
        {
        }
    }
}
