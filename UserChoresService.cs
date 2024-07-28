namespace JAlbertHomeMaintenanceCapstone
{
	public class UserChoresService
	{
		public List<UserChores> GetUserChores()
		{
			return new List<UserChores>
			{
				new UserChores
				{
					Id = 1,
					Name = "Clean the Oven",
					Supply = "Oven Cleaner",
					Repeat = "Annually",
					ResidenceType = "Apartment",
				},
				new UserChores
				{
					Id = 2,
					Name = "Clean the Fridge",
					Supply = "All Purpose Cleaner",
					Repeat = "Annually",
					ResidenceType = "Apartment"
				},
				new UserChores
				{
					Id = 3,
					Name = "Wash the windows",
					Supply = "Glass Cleaner",
					Repeat = "Annually",
					ResidenceType = "Apartment"
				},
				new UserChores
				{
					Id = 4,
					Name = "Clean the light fixtures/fans",
					Supply = "Dry Rag",
					Repeat = "Monthly",
					ResidenceType = "Apartment"
				},
				new UserChores
				{
					Id = 5,
					Name = "Shampoo the carpet",
					Supply = "Rug Doctor",
					Repeat = "Annually",
					ResidenceType = "Apartment"
				},
				new UserChores
				{
					Id = 6,
					Name = "Clean the windows/shades/curtains",
					Supply = "Glass Cleaner, soap and water",
					Repeat = "Annually",
					ResidenceType = "House"
				},
				new UserChores
				{
					Id = 7,
					Name = "Clean the vents",
					Supply = "Vacuum, soap and water",
					Repeat = "Annually",
					ResidenceType = "House"
				},
				new UserChores
				{
					Id = 8,
					Name = "Clean the attic/basement",
					Supply = "Duster, vaccuum",
					Repeat = "Monthly",
					ResidenceType = "House"
				},
				new UserChores
				{
					Id = 9,
					Name = "Spot clean the furniture",
					Supply = "Vaccuum, rag and cleaner of choice",
					Repeat = "Monthly",
					ResidenceType = "House"
				},
				new UserChores
				{
					Id = 10,
					Name = "Trim trees/bushes/plants in both yards",
					Supply = "Hedge clippers/professional service",
					Repeat = "Annually",
					ResidenceType = "House"
				},

			};
		}
	}
}