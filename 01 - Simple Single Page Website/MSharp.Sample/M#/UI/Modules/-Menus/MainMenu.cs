using MSharp;

namespace Modules
{
	class MainMenu : MenuModule
	{
		public MainMenu()
		{
			WrapInForm(false);
			IsViewComponent();
			
			Item("Home").LinkCssClass("mark").OnClick(x =>
			{
				x.Go("#SlideLst");
			});

			Item("Features").OnClick(x =>
			{
				x.Go("#FeatureLst");
			});

			Item("About").OnClick(x =>
			{
				x.Go("#About");
			});

			Item("Clients").OnClick(x =>
			{
				x.Go("#ClientLst");
			});


			Item("Contact").OnClick(x =>
			{
				x.Go("#Contact");
			});

		}
	}
}
