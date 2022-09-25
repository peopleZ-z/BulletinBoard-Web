using Microsoft.AspNetCore.Mvc;

namespace BulletinBoard.Api.Controllers
{
    /// <summary>
    /// Working with the bulletin board.
    /// </summary>
    [ApiController]
    [Route("v1/[controller]")]
    public class BulletinBoardController : ControllerBase
    {
        #region Fields
        private readonly ILogger<BulletinBoardController> _logger;
        #endregion

        #region CTOR
        public BulletinBoardController(ILogger<BulletinBoardController> logger)
        {
            _logger = logger;
        }
        #endregion

        // CRUD

        #region CREATE
        #endregion

        #region READ
        /// <summary>
        /// Returns a list of bulletin boards.
        /// </summary>
        /// <returns>ActionReasult Ok.</returns>
        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            return await Task.FromResult(Ok());
        }

        // Get a specific one
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync()
        {
            return await Task.FromResult(Ok());
        }
        #endregion

        #region UPDATE
        #endregion

        #region DELETE
        #endregion
    }
}