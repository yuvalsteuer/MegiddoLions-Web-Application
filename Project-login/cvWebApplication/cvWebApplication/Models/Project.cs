using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace cvWebApplication.Models
{
	public class Project
	{
		private static int id = 0;
		public int Id { get; set; }
		public string Name { get; set; }
		public string Url { get; set; }


		public Project(string name, string url)
		{
			Name = name;
			Url = url;
			Id = id;
			id++;

		}

		
	}
}