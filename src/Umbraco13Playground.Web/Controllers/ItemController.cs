using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Core.Cache;
using Umbraco.Cms.Core.Logging;
using Umbraco.Cms.Core.Routing;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Infrastructure.Persistence;
using Umbraco.Cms.Web.Website.Controllers;
using Umbraco13Playground.Web.Data;

namespace Umbraco13Playground.Web.Controllers;

public class ItemController : SurfaceController
{
	public ItemController(IUmbracoContextAccessor umbracoContextAccessor, IUmbracoDatabaseFactory databaseFactory,
		ServiceContext services, AppCaches appCaches, IProfilingLogger profilingLogger,
		IPublishedUrlProvider publishedUrlProvider) : base(umbracoContextAccessor, databaseFactory, services, appCaches,
		profilingLogger, publishedUrlProvider)
	{
	}

	public IActionResult Detail(string slug)
	{
		var item = Fruits.Items.FirstOrDefault(x => x.Slug == slug);
		if (item == null)
		{
			return NotFound();
		}
		return View("DetailPage", item); // Returns the Item object to the DetailPage view
	}
}