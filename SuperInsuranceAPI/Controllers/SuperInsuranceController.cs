using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SuperInsuranceAPI.Data;

namespace SuperInsuranceAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class SuperInsuranceController : ControllerBase
	{
		private readonly DataContext _context;

		public SuperInsuranceController(DataContext context)
		{
			_context = context;
		}

		[HttpGet]
		public async Task<ActionResult<List<SuperInsurance>>> GetSuperInsurances()
		{
			return Ok(await _context.SuperInsurances.ToListAsync());

		}

		[HttpPost]
		public async Task<ActionResult<List<SuperInsurance>>> CreateSuperHero(SuperInsurance insurance)
		{
			_context.SuperInsurances.Add(insurance);
			await _context.SaveChangesAsync();

			return Ok(await _context.SuperInsurances.ToListAsync());
		}

		[HttpPut]
		public async Task<ActionResult<List<SuperInsurance>>> UpdateSuperHero(SuperInsurance insurance)
		{
			var dbInsurance = await _context.SuperInsurances.FindAsync(insurance.Id);
			if (dbInsurance == null)
			{
				return BadRequest("hero Not found");
			}

			dbInsurance.PolicyNo = insurance.PolicyNo;
			dbInsurance.FirstName = insurance.FirstName;
			dbInsurance.LastName = insurance.LastName;
			dbInsurance.VehicleType = insurance.VehicleType;
			dbInsurance.Place = insurance.Place;
			dbInsurance.Policy = insurance.Policy;
			dbInsurance.Premium = insurance.Premium;
			dbInsurance.Contact = insurance.Contact;


			await _context.SaveChangesAsync();

			return Ok(await _context.SuperInsurances.ToListAsync());
		}

		[HttpDelete("{id}")]
		public async Task<ActionResult<List<SuperInsurance>>> DeleteSuperInsurance(int id)
		{
			var dbInsurance = await _context.SuperInsurances.FindAsync(id);
			if (dbInsurance == null)
			{
				return BadRequest("hero Not found");
			}
			_context.SuperInsurances.Remove(dbInsurance);
			await _context.SaveChangesAsync();

			return Ok(await _context.SuperInsurances.ToListAsync());
		}
	}
}