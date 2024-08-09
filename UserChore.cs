
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http.Connections;
using System.Dynamic;
using System.Net.Http.Headers;
using ICSharpCode.Decompiler.CSharp.Syntax.PatternMatching;
using MiNET.Worlds;

namespace JAlbertHomeMaintenanceCapstone
{//This class contains the properties for the variable UserChore used in the Chore Form Razor Page. 
    //A UserChore is any chore the user will enter into the form with the intent of making their own
    //chore list within the application. This class is made to be written to a database within the program.
    //When the user navigates to the Household Maintenance List Razor page they should see records returned
    //from the database that lists out their chores based on their email address. 
    public class UserChore

    {
        public long Id { get; set; }
        public string Name {  get; set; }
        public string EmailAddress { get; set; }
        public string Supply {  get; set; }
        public string Repeat {  get; set; }
        public int TimeSpent { get; set; }
        public string ResidenceType { get; set; }


    }
	
	}
