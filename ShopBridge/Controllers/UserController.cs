using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopBridge.Models;
using ShopBridge.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopBridge.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserServices _iuserServices;
        public UserController(IUserServices iuserServices)
        {
            this._iuserServices = iuserServices;
        }
        [HttpGet]
        [Route("CheckIfUserisValid/{email}/{password}")]
        public async Task<IActionResult> CheckIfUserisValid(string email, string password)
        {
            try
            {
                return new ObjectResult(await _iuserServices.CheckIfUserisValid(email, password));
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return null;
            }
        }
        [HttpGet]
        [Route("GetProductByCategury/{category}")]
        public async Task<IActionResult> GetProductByCategury(string category)
        {
            try
            {
                return new ObjectResult(await _iuserServices.GetProductByCategury(category));
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPost]
        [Route("Orders/AddOrder")]
        public IActionResult AddOrder(Order order)
        {
            try
            {
                return new ObjectResult(_iuserServices.AddOrder(order));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        [HttpPost]
        [Route("Users/AddUser")]
        public IActionResult AddUser(User user)
        {
            try
            {
                return new ObjectResult(_iuserServices.AddUser(user));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        [HttpGet]
        [Route("Orders/GetAllOrders/{id}")]
        public IActionResult GetAllOrders(int id)
        {
            try
            {
                return new ObjectResult(_iuserServices.GetAllOrders(id));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        [HttpPut]
        [Route("Orders/UpdateOrder")]
        public IActionResult UpdateProduct(Order order)
        {
            try
            {
                return new ObjectResult(_iuserServices.UpdateOrder(order));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
            
        }

        [HttpDelete]
        [Route("Orders/DeleteOrder/{id}")]
        public IActionResult  DeleteOrder(int id)
        {
            try
            {
                return new ObjectResult(_iuserServices.DeleteOrder(id));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
            
        }
    }
}
