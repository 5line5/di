using FractalPainting.Fractals;
using FractalPainting.Infrastructure;
using Ninject;

namespace FractalPainting.App.Actions
{
	public class KochFractalAction : IUiAction, INeed<IImageHolder>, INeed<Palette>
	{
		private IImageHolder imageHolder;
		private Palette palette;

		public void SetDependency(IImageHolder dependency)
		{
			imageHolder = dependency;
		}

		public void SetDependency(Palette dependency)
		{
			palette = dependency;
		}

		public string Category => "��������";
		public string Name => "������ ����";
		public string Description => "������ ����";

		public void Perform()
		{
			var container = new StandardKernel();
			container.Bind<IImageHolder>().ToConstant(imageHolder);
			container.Bind<Palette>().ToConstant(palette);

			container.Get<KochPainter>().Paint();
		}
	}
}