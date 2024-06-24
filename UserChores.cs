
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http.Connections;
using System.Dynamic;
using System.Net.Http.Headers;
using ICSharpCode.Decompiler.CSharp.Syntax.PatternMatching;
using MiNET.Worlds;

namespace JAlbertHomeMaintenanceCapstone
{
    public class UserChores
    {
        public string Name {  get; set; }
        public string Supply {  get; set; }
        public string Repeat {  get; set; }
        public int TimeSpent { get; set; }
        public string ResidenceType { get; set; }

    }
}


