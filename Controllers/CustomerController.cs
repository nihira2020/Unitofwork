using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Unitofwork.Modelss;

namespace Unitofwork.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IUnitofWork unitofWork;
        public CustomerController(IUnitofWork work) {
            this.unitofWork = work;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var _data= await this.unitofWork.customerrepo.GetAllAsync();
            return Ok(_data);
        }
        [HttpGet("Getbycode/{id}")]
        public async Task<IActionResult> Getbycode(int id)
        {
            var _data = await this.unitofWork.customerrepo.GetAsync(id);
            return Ok(_data);
        }
        [HttpPost("Create")]
        public async Task<IActionResult> Create(TblCustomer tblCustomer)
        {
            var _data = await this.unitofWork.customerrepo.AddEntity(tblCustomer);
            await this.unitofWork.CompleteAsync();
            return Ok(_data);
        }
        [HttpPut("Update")]
        public async Task<IActionResult> Update(TblCustomer tblCustomer)
        {
            var _data = await this.unitofWork.customerrepo.UpdateEntity(tblCustomer);
            await this.unitofWork.CompleteAsync();
            return Ok(_data);
        }
        [HttpDelete("Remove")]
        public async Task<IActionResult> Remove(int id)
        {
            var _data = await this.unitofWork.customerrepo.DeleteEntity(id);
            await this.unitofWork.CompleteAsync();
            return Ok(_data);
        }
    }
}
