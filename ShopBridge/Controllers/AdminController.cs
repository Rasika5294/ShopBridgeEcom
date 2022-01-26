using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopBridge.Models;
using ShopBridge.Services;
using System;
using System.Threading.Tasks;

namespace ShopBridge.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IAdminServices _iadminservices;
        public AdminController(IAdminServices iadminservices)
        {
            this._iadminservices = iadminservices;
        }
        [HttpGet]
        [Route("CheckIfAdminisValid/{email}/{password}")]
        public async Task<IActionResult> CheckIfAdminisValid(string email, string password)
        {
            try
            {
                return new ObjectResult(await _iadminservices.CheckIfAdminisValid(email, password));
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return null;
            }
        }
        [HttpGet]
        [Route("Product/GetAllProduct")]
        public async Task<IActionResult> GetAllProducts()
        {
            try
            {
                return new ObjectResult(await _iadminservices.GetAllProducts());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        [HttpGet]
        [Route("Product/GetProductById/{id}")]
        public async Task<IActionResult> GetProductById(int id)
        {
            try
            {
                return new ObjectResult(await _iadminservices.GetProductById(id));
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return null;
            }
        }
        [HttpPost]
        [Route("Product/AddProduct")]
        public IActionResult AddProduct(Product product)
        {
            try
            {
                return new ObjectResult(_iadminservices.AddProduct(product));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        [HttpDelete]
        [Route("Product/DeleteProduct/{id}")]
        public IActionResult DeleteProduct(int id)
        {
            try
            {
                return new ObjectResult(_iadminservices.DeleteProduct(id));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }

        }

        [HttpPut]
        [Route("Product/UpdateProduct")]
        public IActionResult UpdateProduct(Product product)
        {
            try
            {
                return new ObjectResult (_iadminservices.UpdateProduct(product));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
            
        }

        [HttpPost]
        [Route("User/AddUser")]
        public IActionResult AddUser(User user)
        {
            try
            {
                return new ObjectResult(_iadminservices.AddUser(user));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        [HttpGet]
        [Route("Product/GetAllUsers")]
        public async Task<IActionResult> GetAllUsers()
        {
            try
            {
                return new ObjectResult(await _iadminservices.GetAllUsers());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

    }

}
