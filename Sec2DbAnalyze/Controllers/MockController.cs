using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Sec2DbAnalyze.ServiceLayer.Mock;

namespace Sec2DbAnalyze.Controllers
{
    [ApiController]
    [Route("mock")]
    public class MockController : ControllerBase
    {
        private readonly ILogger<MockController> _logger;
        private readonly IMockService _mockService;

        public MockController(ILogger<MockController> logger, IMockService mockService)
        {
            _logger = logger;
            _mockService = mockService;
        }
        
        [HttpGet]
        [Route("as-mock")]
        public async Task<IActionResult> CreateAccountService()
        {
            await _mockService.CreateAccountAndService();
            return Ok("Success");
        }

        [HttpGet]
        public async Task<IActionResult> Create(int i)
        {
            await _mockService.CreatePartialMockDate(i);
            return Ok("Success");
        }
        
        
    }
}