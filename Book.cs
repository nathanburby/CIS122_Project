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

		public Book(string title, string author, string isbn, int publicationDate)
		{
			_title = title;
			_author = author;
			_isbn = isbn;
			_publicationDate = publicationDate;
		}

		public Book(string title, string isbn) : this(title, string.Empty, isbn, -1) { }

		public Book() : this("N/a", "N/a", "N/a", -1) { }

		public override bool Equals(object obj)
		{
			if (obj is Book other)
				return _isbn == other._isbn;
			return false;
		}

		public override int GetHashCode()
		{
			return _isbn.GetHashCode();
		}
	}
}
