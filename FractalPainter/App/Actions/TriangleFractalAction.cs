using FractalPainting.Fractals;
using FractalPainting.Infrastructure;
using Ninject;

namespace FractalPainting.App.Actions
{
	public class TriangleFractalAction : IUiAction, INeed<IImageHolder>
	{
		private IImageHolder imageHolder;
		public string Category => "��������";
		public string Name => "�����������";
		public string Description => "����������� �����������";
		public void Perform()
		{
			var container = new StandardKernel();
			container.Bind<IImageHolder>().ToConstant(imageHolder);

			container.Get<TrianglePainter>().Paint();
		}

		public void SetDependency(IImageHolder dependency)
		{
			imageHolder = dependency;
		}
	}
}