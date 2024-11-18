using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Core.Cache;
using Umbraco.Cms.Core.Logging;
using Umbraco.Cms.Core.Routing;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Infrastructure.Persistence;
using Umbraco.Cms.Web.Website.Controllers;

namespace Umbraco13Playground.Web.Controllers.Surfaces
{
	public class FilterPageController : SurfaceController
	{
		public FilterPageController(IUmbracoContextAccessor umbracoContextAccessor, IUmbracoDatabaseFactory databaseFactory, ServiceContext services, AppCaches appCaches, IProfilingLogger profilingLogger, IPublishedUrlProvider publishedUrlProvider) : base(umbracoContextAccessor, databaseFactory, services, appCaches, profilingLogger, publishedUrlProvider)
		{
		}

		// Simulated backend data source
		private readonly List<string> _items = new List<string>
		{
			"Apple", "Crabapple", "Pineapple", "Guapple", "Apple Mango", "Banana", "Cherry", "Date", "Elderberry", "Fig", "Grape",
			"Honeydew", "Kiwi", "Lemon", "Mango", "Nectarine", "Orange", "Papaya",
			"Quince", "Raspberry", "Strawberry", "Tangerine", "Ugli Fruit", "Watermelon"
		};

		[HttpPost]
		public IActionResult FilterResults(string filter, int page = 1, int pageSize = 2)
		{
			// Filter the list
			var filteredItems = string.IsNullOrWhiteSpace(filter)
				? _items
				: _items.Where(x => x.Contains(filter, StringComparison.OrdinalIgnoreCase)).ToList();

			// Pagination logic
			var totalItems = filteredItems.Count;
			var totalPages = (int)Math.Ceiling(totalItems / (double)pageSize);
			var paginatedItems = filteredItems.Skip((page - 1) * pageSize).Take(pageSize).ToList();

			// Pass data to the view
			return View("ResultPage", new FilterViewModel
			{
				Items = paginatedItems,
				CurrentPage = page,
				TotalPages = totalPages,
				Filter = filter
			});
		}

	}

	// ViewModel for the filter results
	public class FilterViewModel
	{
		public List<string> Items { get; set; }
		public int CurrentPage { get; set; }
		public int TotalPages { get; set; }
		public string Filter { get; set; }
	}
}
