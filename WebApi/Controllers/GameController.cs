using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Http;
using PraticeSwagger.Models;
using System.Linq.Expressions;
using static System.Runtime.InteropServices.JavaScript.JSType;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;
using Microsoft.EntityFrameworkCore;

namespace PraticeSwagger.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class GameController : ControllerBase
	{
		private readonly GameDbContext  _gameDbContext;

		public GameController(GameDbContext gameDbContext)
		{
			_gameDbContext = gameDbContext;
		}

		[HttpGet]
		[Route("Games")]
		public List<GameTable> AllGames()
		{
			var result = _gameDbContext.Games.ToList();
			return result;
		}
		[HttpGet]
		[Route("Games/{id}")]
		public IActionResult GetById(int id)
		{
			var found = _gameDbContext.Games.FirstOrDefault(g => g.GameId == id);
			if (found == null)
			{
				return NotFound("Game not found");
			}
			return Ok(found);
		}


		[HttpPut]//Update the Games
		[Route("Games")]
		public GameTable PutStocks(GameTable data)
		{
			var found = _gameDbContext.Games.FirstOrDefault(g => g.GameId == data.GameId);
			if (found == null)
			{
				throw new Exception("Not Found");
			}
			found.GameName = data.GameName;
			found.GamePrice = data.GamePrice;

			_gameDbContext.SaveChanges();
			return found;
		}

		[HttpDelete]
		[Route("Games/{id}")]
		public IActionResult Deletestock(int id)
		{
			var found = _gameDbContext.Games.FirstOrDefault(g => g.GameId == id);
			if (found == null)
			{
				return NotFound("Game not found");
			}
			_gameDbContext.Games.Remove(found);
			_gameDbContext.SaveChanges();
			return Ok(found);
		}

		[HttpPost]
		[Route("Games")]
		public ObjectResult AddStock(GameTable game)
		{
			_gameDbContext.Games.Add(game);
			_gameDbContext.SaveChanges();
			return Ok("Added Successfully");
		}

	}
}
