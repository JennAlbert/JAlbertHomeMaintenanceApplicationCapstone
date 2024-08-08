using Microsoft.EntityFrameworkCore;
using ServiceStack.DataAnnotations;
using SQLitePCL;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace JAlbertHomeMaintenanceCapstone.Models
{
	
	public class UserChoreModel
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Supply { get; set; }
		public string Repeat { get; set; }
		public int TimeSpent { get; set; }
		public string EmailAddress { get; set; }
		public string ResidenceType { get; set; }
	}
}
