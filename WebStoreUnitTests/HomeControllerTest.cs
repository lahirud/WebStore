using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebStore.Controllers;
using WebStore.Models;
using WebStore.ViewModels;
using Xunit;

namespace WebStoreUnitTests
{
    public class HomeControllerTest
    {
        HomeController controller;
        IRepository cakesRepository;

        public HomeControllerTest()
        {
            // arrange
            cakesRepository = new MockCakeRepository();
            controller = new HomeController(cakesRepository);
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
        public void GetIndexShouldReturnList()
        {
            // act
            var okResult = controller.Index() as ViewResult;
            var viewModel = okResult.ViewData.Model as HomeViewModel;
            // assert
            Assert.IsAssignableFrom<IEnumerable<Cake>>(viewModel.Cakes);
        }

        [Fact]
        public void GetIndexShouldReturnItemsCount()
        {
            // act
            var okResult = controller.Index() as ViewResult;
            var viewModel = okResult.ViewData.Model as HomeViewModel;

            // assert
            var cakesList = (viewModel.Cakes) as List<Cake>;
            Assert.Equal(4, cakesList.Count);
        }

        [Fact]
        public void GetDetailsShouldReturnValidItem()
        {
            // act
            var okResult = controller.Detail(2) as ViewResult;
            var viewModel = okResult.ViewData.Model as Cake;

            // assert
            Assert.Equal("Blueberry Cheese Cake", viewModel.Name);
        }
    }
}
