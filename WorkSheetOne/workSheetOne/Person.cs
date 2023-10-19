using System;

namespace workSheetOne
{
	public class Person
	{
		private int id;
		private string name;
		private int age;
		private string locality;
		private string favouriteColour;

		public Person(int id)
		{
			this.id = id;
		}

		public Person(int id, string name, int age, string locality, string favouriteColour)
		{
			this.id = id;
			this.name = name;
			this.age = age;
			this.locality = locality;
			this.favouriteColour = favouriteColour;
		}

		public string GetName()
		{
			return name;
		}
	}
}


