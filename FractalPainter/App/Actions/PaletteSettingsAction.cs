using FractalPainting.Infrastructure;

namespace FractalPainting.App.Actions
{
	public class PaletteSettingsAction : IUiAction, INeed<Palette>
	{
		private Palette palette;
		public string Category => "���������";
		public string Name => "�������...";
		public string Description => "����� ��� ��������� ���������";

		public void Perform()
		{
			SettingsForm.For(palette).ShowDialog();
		}
		public void SetDependency(Palette dependency)
		{
			palette = dependency;
		}
	}
}