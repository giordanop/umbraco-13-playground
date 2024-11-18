using Umbraco13Playground.Web.Models;

namespace Umbraco13Playground.Web.Data;


// Simulated backend data source
public static class Fruits
{
	public static readonly List<Item> Items =
	[
		new Item { Id = 1, Name = "Apple", Slug = "apple", Description = "A sweet fruit." },
		new Item { Id = 2, Name = "Crabapple", Slug = "crabapple", Description = "A small, tart apple." },
		new Item { Id = 3, Name = "Pineapple", Slug = "pineapple", Description = "A tropical, spiky fruit." },
		new Item { Id = 4, Name = "Guapple", Slug = "guapple", Description = "A hybrid fruit of guava and apple." },
		new Item
		{
			Id = 5, Name = "Apple Mango", Slug = "apple-mango",
			Description = "A variety of mango with apple-like taste."
		},

		new Item { Id = 6, Name = "Banana", Slug = "banana", Description = "A long, yellow fruit." },
		new Item { Id = 7, Name = "Cherry", Slug = "cherry", Description = "A small, round red fruit." },
		new Item { Id = 8, Name = "Date", Slug = "date", Description = "A sweet, brown fruit from the date palm." },
		new Item { Id = 9, Name = "Elderberry", Slug = "elderberry", Description = "A small, dark purple fruit." },
		new Item { Id = 10, Name = "Fig", Slug = "fig", Description = "A sweet, pear-shaped fruit." },
		new Item
		{
			Id = 11, Name = "Grape", Slug = "grape", Description = "A small, round fruit often used for wine."
		},

		new Item { Id = 12, Name = "Honeydew", Slug = "honeydew", Description = "A sweet, green melon." },
		new Item
		{
			Id = 13, Name = "Kiwi", Slug = "kiwi", Description = "A small, brown, fuzzy fruit with green flesh."
		},

		new Item { Id = 14, Name = "Lemon", Slug = "lemon", Description = "A sour, yellow citrus fruit." },
		new Item { Id = 15, Name = "Mango", Slug = "mango", Description = "A tropical stone fruit." },
		new Item
		{
			Id = 16, Name = "Nectarine", Slug = "nectarine",
			Description = "A smooth-skinned fruit similar to a peach."
		},

		new Item { Id = 17, Name = "Orange", Slug = "orange", Description = "A sweet, round citrus fruit." },
		new Item { Id = 18, Name = "Papaya", Slug = "papaya", Description = "A tropical fruit with orange flesh." },
		new Item
		{
			Id = 19, Name = "Quince", Slug = "quince", Description = "A yellow fruit often used for jelly."
		},

		new Item { Id = 20, Name = "Raspberry", Slug = "raspberry", Description = "A small, red berry." },
		new Item { Id = 21, Name = "Strawberry", Slug = "strawberry", Description = "A sweet, red, juicy berry." },
		new Item { Id = 22, Name = "Tangerine", Slug = "tangerine", Description = "A small, sweet citrus fruit." },
		new Item
		{
			Id = 23, Name = "Ugli Fruit", Slug = "ugli-fruit", Description = "A tangy, hybrid citrus fruit."
		},

		new Item
		{
			Id = 24, Name = "Watermelon", Slug = "watermelon",
			Description = "A large, juicy, green fruit with red flesh."
		}
	];
}