using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Warehouse.Data.Reponsitories.Implements;
using Warehouse.Models.Domain;
using Warehouse.Models.DTO;

namespace WareHouseAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
  /*  [Authorize(Roles = "Writer")]*/
    public class WareController : ControllerBase
    {
        private readonly IUnitWork _unitWork;
        private readonly IMapper _mapper;

        public WareController(IUnitWork unitWork, IMapper mapper)
        {
            _unitWork = unitWork;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllWarehouses()
        {
            var warehouses = await _unitWork.wareRepository.GetAllAsync();
            var response = _mapper.Map<List<WareDto>>(warehouses);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateWarehouse([FromBody] WareRequestDto request)
        {
            var warehouse = _mapper.Map<Ware>(request);
            await _unitWork.wareRepository.CreateAsync(warehouse);
            var response = _mapper.Map<WareDto>(warehouse);
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var warehouse = await _unitWork.wareRepository.GetByIdAsync(id);
            if (warehouse == null)
            {
                return NotFound();
            }

            var response = _mapper.Map<WareDto>(warehouse);
            return Ok(response);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] WareRequestDto request)
        {
            var warehouse = _mapper.Map<Ware>(request);
            warehouse.Id = id;

            var updatedWarehouse = await _unitWork.wareRepository.UpdateAsync(warehouse);
            if (updatedWarehouse == null)
            {
                return NotFound();
            }

            var response = _mapper.Map<WareDto>(updatedWarehouse);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var warehouse = await _unitWork.wareRepository.DeleteAsync(id);
            if (warehouse == null)
            {
                return NotFound();
            }

            var response = _mapper.Map<WareDto>(warehouse);
            return Ok(response);
        }
    }
}
