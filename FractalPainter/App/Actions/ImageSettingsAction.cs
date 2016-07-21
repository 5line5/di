using FractalPainting.Infrastructure;

namespace FractalPainting.App.Actions
{
	public class ImageSettingsAction : IUiAction, INeed<IImageSettingsProvider>, INeed<IImageHolder>
	{
		private IImageSettingsProvider imageSettingsProvider;
		private IImageHolder imageHolder;
		public string Category => "���������";
		public string Name => "�����������...";
		public string Description => "������� �����������";

		public void Perform()
		{
			var imageSettings = imageSettingsProvider.ImageSettings;
			SettingsForm.For(imageSettings).ShowDialog();
			imageHolder.RecreateImage(imageSettings);
		}

		public void SetDependency(IImageSettingsProvider dependency)
		{
			imageSettingsProvider = dependency;
		}

		public void SetDependency(IImageHolder dependency)
		{
			imageHolder = dependency;
		}
	}
}