using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS122_Project
{
	public class Book
	{
		public string _title;
		public string _author;
		public string _isbn;
		public int _publicationDate;

		public Book(string title, string isbn) : this(title, string.Empty, isbn, -1)
		{
			this._title = title;
			this._isbn = isbn;
		}

		public Book(string title, string author, string isbn, int publicationDate)
		{
			this._title = title;
			this._author = author;
			this._isbn = isbn;
			this._publicationDate = publicationDate;
		}

		public Book() : this("N/a", "N/a", "N/a", -1) { }


	}
}
