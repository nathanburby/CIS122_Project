using CIS122_Project;

internal class Program
{
	private static void Main(string[] args)
	{
		// Create Library instance
		Library library = new Library();

		// Create some books
		Book book1 = new Book("Book One", "Author A", "ISBN-1111", 2001);
		Book book2 = new Book("Book Two", "Author B", "ISBN-2222", 2002);
		Book book3 = new Book("Book Three", "Author C", "ISBN-3333", 2003);

		Console.WriteLine("==== TESTING LIBRARY METHODS ====\n");

		// Test: Add Books
		Console.WriteLine("Adding books...");
		library.AddBook(book1);
		library.AddBook(book2);
		Console.WriteLine("Books added successfully (Expected: True)\n");

		// Test: Delete an existing book
		Console.WriteLine("Deleting Book Two...");
		bool deleted = library.DeleteBook(book2);
		Console.WriteLine($"Book deleted: {deleted} (Expected: True)\n");

		// Test: Delete a non-existing book
		Console.WriteLine("Deleting Book Three (which was never added)...");
		deleted = library.DeleteBook(book3);
		Console.WriteLine($"Book deleted: {deleted} (Expected: False)\n");

		// Test: Replace a book successfully
		Console.WriteLine("Replacing Book One with Book Three...");
		bool replaced = library.Replace(book1, book3);
		Console.WriteLine($"Book replaced: {replaced} (Expected: True)\n");

		// Test: Replace a non-existing book
		Console.WriteLine("Trying to replace Book Two (which was deleted) with Book One...");
		replaced = library.Replace(book2, book1);
		Console.WriteLine($"Book replaced: {replaced} (Expected: False)\n");

		// Test: Replace a book with itself
		Console.WriteLine("Trying to replace Book Three with itself...");
		replaced = library.Replace(book3, book3);
		Console.WriteLine($"Book replaced: {replaced} (Expected: False)\n");

		Console.WriteLine("==== TESTING COMPLETED ====");
	}
}