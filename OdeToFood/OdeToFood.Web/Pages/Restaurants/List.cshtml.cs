using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace OdeToFood.Web
{
	using S = String;
	public class ListModel : PageModel
	{
		private readonly IConfiguration _configuration;
		private readonly IRestaurant _restaurant;

		public S Message { get; set; }
		public IEnumerable<Restaurants.Restaurant> Restaurants { get; set; }
		public ListModel(IConfiguration configuration, IRestaurant restaurant)
		{
			_configuration = configuration;
			_restaurant = restaurant;
		}
		public void OnGet()
		{
			Message = _configuration["Message"];

			Restaurants = _restaurant.GetRestaurants();
			
		}
	}
}