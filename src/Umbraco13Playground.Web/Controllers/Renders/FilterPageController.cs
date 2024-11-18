using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Web.Common.Controllers;
using Umbraco13Playground.Web.Data;
using Umbraco13Playground.Web.Models;

namespace Umbraco13Playground.Web.Controllers.Renders
{
	public class FilterPageController : RenderController //hijacks the render of the FilterPage docType
	{
		public FilterPageController(ILogger<RenderController> logger, ICompositeViewEngine compositeViewEngine,
			IUmbracoContextAccessor umbracoContextAccessor) : base(logger, compositeViewEngine, umbracoContextAccessor)
		{
		}

		[HttpGet]
		public IActionResult Index(string? slug)
		{
			if (slug == null)
			{
				var model = new FilterViewModel
				{
					Items = null,
					TotalPages = 0,
					CurrentPage = 1
				};
				return CurrentTemplate(model); // This renders the page with the current template
			}

			var item = Fruits.Items.FirstOrDefault(x => x.Slug == slug);
			if (item == null)
			{
				return NotFound();
			}

			return View("~/Views/DetailPage.cshtml", item); // This renders the page with the replaced template
		}

		[HttpPost]
		public IActionResult Index(FilterViewModel model)
		{
			int pageSize = 2;

			var filteredItems = string.IsNullOrWhiteSpace(model.Filter)
			? Fruits.Items
				: Fruits.Items.Where(x => x.Name.Contains(model.Filter, StringComparison.OrdinalIgnoreCase)).ToList();

			// Pagination logic
			var totalItems = filteredItems.Count;
			var totalPages = (int)Math.Ceiling(totalItems / (double)pageSize);
			var paginatedItems = filteredItems.Skip((model.CurrentPage - 1) * pageSize).Take(pageSize).ToList();

			// Pass data to the view
			return CurrentTemplate(new FilterViewModel
			{
				Items = paginatedItems,
				CurrentPage = model.CurrentPage,
				TotalPages = totalPages,
				Filter = model.Filter
			});
		}
	}
}
