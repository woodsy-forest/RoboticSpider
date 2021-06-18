using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoboticSpider.Dto;
using RoboticSpider.Enums;
using RoboticSpider.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoboticSpider.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpiderController : ControllerBase
    {

        [HttpGet("move")]
        public async Task<IActionResult> MoveSpider (SpiderInputDto _spider)
        {

            try
            {
                var spider = new Spider(_spider.MaxX, _spider.MaxY, _spider.CurrX, _spider.CurrY, _spider.Direction);
                spider.SetMove(_spider.Commands);
                var output = new SpiderOutputDto();
                output.CurrX = spider.CurrX;
                output.CurrY = spider.CurrY;
                output.Direction = spider.Direction;

                return await Task.Run(() => Ok(output));

            }
            catch (Exception ex)
            {
                //500 - Internal Server Error
                return StatusCode(500, ex.Message);
            }
        }
    }
}
