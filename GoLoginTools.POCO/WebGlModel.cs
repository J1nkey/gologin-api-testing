using GoLoginTools.POCO.Enumerables;

namespace GoLoginTools.POCO
{
	public class WebGlModel
	{
		public string mode { get; set; } = WebGlMode.noise.ToString();
		public int getClientRectNoise { get; set; } = 0;
		public double noise { get; set; } = 0.0d;
    }
}
