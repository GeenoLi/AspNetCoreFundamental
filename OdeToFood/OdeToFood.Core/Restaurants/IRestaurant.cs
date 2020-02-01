using System.Collections.Generic;

namespace OdeToFood
{
	public interface IRestaurant
	{
		IEnumerable<Restaurants.Restaurant> GetRestaurants();
	}
}
