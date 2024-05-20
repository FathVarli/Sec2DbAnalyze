using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Sec2DbAnalyze.Dto.Concrete;
using Sec2DbAnalyze.ServiceLayer.Mock;
using Sec2DbAnalyze.ServiceLayer.Test;

namespace Sec2DbAnalyze.Controllers
{
    [ApiController]
    [Route("test")]
    public class TestController : ControllerBase
    {
        private readonly ILogger<TestController> _logger;
        private readonly ITestService _testService;

        public TestController(ITestService testService, ILogger<TestController> logger)
        {
            _testService = testService;
            _logger = logger;
        }

        [HttpGet]
        [Route("users")]
        public async Task<IActionResult> GetListUser([FromQuery] UserFilterDto userFilterDto)
        {
            var result = await _testService.GetListUser(userFilterDto);
            return Ok(result);
        }

        [HttpGet]
        [Route("user")]
        public async Task<IActionResult> GetUser([FromQuery] UserFilterDto userFilterDto)
        {
            var result = await _testService.GetUser(userFilterDto);
            return Ok(result);
        }
        
        
        [HttpGet]
        [Route("identities")]
        public async Task<IActionResult> GetListIdentity([FromQuery] IdentityFilterDto identityFilterDto)
        {
            var result = await _testService.GetListIdentity(identityFilterDto);
            return Ok(result);
        }

        [HttpGet]
        [Route("identity")]
        public async Task<IActionResult> GetIdentity([FromQuery] IdentityFilterDto identityFilterDto)
        {
            var result = await _testService.GetIdentity(identityFilterDto);
            return Ok(result);
        }
        
        [HttpPost]
        [Route("user")]
        public async Task<IActionResult> UpdateUser(UserFilterDto userFilterDto)
        {
            await _testService.UpdateUser(userFilterDto);
            return Ok("Success");
        }
        
        
    }
}