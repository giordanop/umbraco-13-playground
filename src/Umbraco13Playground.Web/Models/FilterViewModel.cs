namespace Umbraco13Playground.Web.Models;

public class FilterViewModel
{
	public List<Item>? Items { get; set; }
	public int CurrentPage { get; set; }
	public int TotalPages { get; set; }
	public string Filter { get; set; }
}