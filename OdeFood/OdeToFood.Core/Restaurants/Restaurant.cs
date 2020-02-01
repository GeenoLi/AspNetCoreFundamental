using System;

namespace OdeToFood
{
	using S = String;

	partial class Restaurants
	{
		public sealed class Restaurant
		{
			public static Restaurant Make(int id,S name,S location,CuisineType.IDs ids)
			{
				return new Restaurant(id,name,location,ids);
			}
			private Restaurant(int id, S name, S location, CuisineType.IDs ids)
			{
				Id = id;
				Name = name;
				Location = location;
				CuisineType = ids;
			}
			public int Id { get;}
			public S Name { get;}
			public S Location { get;}

			public CuisineType.IDs CuisineType { get; set; }

		}

	}
	
}
