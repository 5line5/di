using System;
using FractalPainting.Fractals;
using FractalPainting.Infrastructure;
using Ninject;
using Ninject.Syntax;

namespace FractalPainting.App.Actions
{
	public class DragonFractalAction : IUiAction, INeed<IImageHolder>
	{
		private IImageHolder imageHolder;
		public string Category => "��������";
		public string Name => "������";
		public string Description => "������ �������-�������";

		public void Perform()
		{
			var dragonSettings = new DragonSettings();
			SettingsForm.For(dragonSettings).ShowDialog();

			var container = new StandardKernel();
			container.Bind<IImageHolder>().ToConstant(imageHolder);
			container.Bind<DragonSettings>().ToConstant(dragonSettings);
			container.Get<DragonPainter>().Paint();
		}

		public void SetDependency(IImageHolder dependency)
		{
			imageHolder = dependency;
		}
	}
}