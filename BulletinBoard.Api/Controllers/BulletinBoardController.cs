using BulletinBoard.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Net;

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
        /// <summary>
        /// Initializes <see cref="BulletinBoardController"/>
        /// </summary>
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
        /// <returns>A collection of elements <see cref="BulletinBoardDto"/>.</returns>
        [HttpGet]
        [ProducesResponseType(typeof(IReadOnlyCollection<BulletinBoardDto>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetAllAsync()
        {
            return await Task.FromResult(Ok());
        }

        /// <summary>
        /// Returns a specific bulletin board.
        /// </summary>
        /// <returns>An element <see cref="BulletinBoardDto"/>.</returns>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(BulletinBoardDto), (int)HttpStatusCode.OK)]
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