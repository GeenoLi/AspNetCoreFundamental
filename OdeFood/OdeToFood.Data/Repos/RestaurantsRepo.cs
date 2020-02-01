using System.Collections.Generic;
using System.Linq;

namespace OdeToFood.Data
{
	using M = Restaurants.Restaurant;
	public class RestaurantsRepo : IRestaurant
	{
		public IEnumerable<M> GetRestaurants()
			=> Enumerable.Range(1, 10).Select(
				x => M.Make
				(
					x, "jack", "usa", CuisineType.IDs.ChuanCai
				)).ToList();
	}
}
