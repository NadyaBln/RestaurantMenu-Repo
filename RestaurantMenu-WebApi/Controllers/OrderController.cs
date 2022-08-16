using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RestaurantMenu_BusinessLogic.Services;
using RestaurantMenu_Entities.Entities;
using System.Threading.Tasks;

namespace RestaurantMenu_WebApi.Controllers
{
    [ApiController]
    [Route("order")]
    public class OrderController : ControllerBase
    {
        //to use automapper we should use it as dependency
        private readonly IMapper _mapper;

        //and use Interface - Interface moves us to abstraction
        //add BL layer, that's why use OrderService
        private readonly IOrderService _orderService;

        //initialization via constructor
        public OrderController(IOrderService orderService, IMapper mapper)
        {
            this._orderService = orderService;
            this._mapper = mapper;
        }

        //controller methods realization
        //GET method
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            //use repo from constructor
            var orders = await this._orderService.GetAllAsync();

            //returns Orders in OK request 
            return this.Ok(orders);
        }

        //create
        [HttpPost("create")]
        public async Task<IActionResult> Create([FromBody] Orders orders)
        {
            this._mapper.Map<Orders>(orders);
            await this._orderService.AddAsync(orders);
            return this.Ok();
        }
    }
}
