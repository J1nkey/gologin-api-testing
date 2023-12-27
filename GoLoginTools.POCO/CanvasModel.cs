using GoLoginTools.POCO.Enumerables;

namespace GoLoginTools.POCO
{
	public class CanvasModel
	{
        public string mode { get; set; } = CanvasMode.off.ToString();
        public int noise { get; set; }
    }
}
