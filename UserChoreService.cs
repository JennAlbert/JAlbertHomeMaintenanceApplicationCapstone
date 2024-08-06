namespace JAlbertHomeMaintenanceCapstone
{//This class provides a list to the user of chores they may not have thought about. On the Home Maintenance
	//List Razor Page they will see a table with the elements of this list in rows. Going forward I would like
	//to provide the list where it only shows the chores based on ResidenceType if the user chooses Apartment
	//or House on the Chore Form. 
	public static class UserChoreService
	{
		public static List<UserChore> GetUserChores()
		{
			return new List<UserChore>
			{
				new UserChore
				{
					Id = 1,
					Name = "Clean the Oven",
					Supply = "Oven Cleaner",
					Repeat = "Annually",
					ResidenceType = "Apartment",
				},
				new UserChore
				{
					Id = 2,
					Name = "Clean the Fridge",
					Supply = "All Purpose Cleaner",
					Repeat = "Annually",
					ResidenceType = "Apartment"
				},
				new UserChore
				{
					Id = 3,
					Name = "Wash the windows",
					Supply = "Glass Cleaner",
					Repeat = "Annually",
					ResidenceType = "Apartment"
				},
				new UserChore
				{
					Id = 4,
					Name = "Clean the light fixtures/fans",
					Supply = "Dry Rag",
					Repeat = "Monthly",
					ResidenceType = "Apartment"
				},
				new UserChore
				{
					Id = 5,
					Name = "Shampoo the carpet",
					Supply = "Rug Doctor",
					Repeat = "Annually",
					ResidenceType = "Apartment"
				},
				new UserChore
				{
					Id = 6,
					Name = "Clean the windows/shades/curtains",
					Supply = "Glass Cleaner, soap and water",
					Repeat = "Annually",
					ResidenceType = "House"
				},
				new UserChore
				{
					Id = 7,
					Name = "Clean the vents",
					Supply = "Vacuum, soap and water",
					Repeat = "Annually",
					ResidenceType = "House"
				},
				new UserChore
				{
					Id = 8,
					Name = "Clean the attic/basement",
					Supply = "Duster, vaccuum",
					Repeat = "Monthly",
					ResidenceType = "House"
				},
				new UserChore
				{
					Id = 9,
					Name = "Spot clean the furniture",
					Supply = "Vaccuum, rag and cleaner of choice",
					Repeat = "Monthly",
					ResidenceType = "House"
				},
				new UserChore
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