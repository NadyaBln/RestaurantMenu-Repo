using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RestaurantMenu_BusinessLogic.Services;
using RestaurantMenu_DataAccess;
using RestaurantMenu_Entities.Entities;
using RestaurantMenu_WebApi.Models;
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
        [HttpGet]
        public async Task<IActionResult> GetOrder()
        {
            //use repo from constructor
            var orders = await this._orderService.GetAllAsync();

            //returns Orders in OK request 
            return this.Ok(orders);
        }


        [HttpPost("create")]
        public async Task<IActionResult> Create([FromBody] OrderModel orderModel)
        {
            //works
            //var dbContext = new MenuDataContext();
            //dbContext.Add(new OrderModel()
            //{
            //    //OrderId = orderModel.OrderId,
            //    //OrderItem = orderModel.OrderItem,
            //    OrderItemId = orderModel.OrderItemId,
            //    CreationDateTime = orderModel.CreationDateTime,
            //    GuestId = orderModel.GuestId,
            //    //Guest = orderModel.Guest,
            //    TableNumber = orderModel.TableNumber
            //});
            //dbContext.SaveChanges();

            //return this.Ok();

            var order = this._mapper.Map<Orders>(orderModel);
            await this._orderService.AddAsync(order);
            return this.Ok();
        }

        [HttpPut("{id:int}/edit")]
        public async Task<IActionResult> Update([FromBody] OrderModel orderModel, [FromRoute] int id)
        {
            //var dbContext = new MenuDataContext();
            //var result = dbContext.Update(Orders);

            //works
            //var order = this._mapper.Map<Orders>(orderModel);
            //await this._orderService.TryUpdateAsync(id, order);

            //return this.Ok();


            var order = this._mapper.Map<Orders>(orderModel);
            var result = await this._orderService.TryUpdateAsync(id, order);

            return result ? this.Ok() : this.NotFound();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var order = await this._orderService.GetByIdAsync(id);
            if (order == null)
            {
                return this.NotFound();
            }

            return this.Ok(order);
        }

        [HttpDelete("{id:int}/delete")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var orders = await this._orderService.GetByIdAsync(id);
            if (orders != null)
            {
                await this._orderService.DeleteAsync(orders);
                return this.Ok();
            }
            return this.NotFound();
        }
    }
}
