using System;
using System.Collections.Generic;
using RazorEngine.Templating;
using ServiceStack.Markdown;

namespace RazorEngine
{
	public interface IRazorTemplate : ITemplate, ITemplatePage
	{
		string Layout { get; }
		Dictionary<string, Action> Sections { get; }
		IRazorTemplate ChildTemplate { get; set;  }
	}
}