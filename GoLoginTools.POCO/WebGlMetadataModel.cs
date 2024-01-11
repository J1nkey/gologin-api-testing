using GoLoginTools.POCO.Enumerables;

namespace GoLoginTools.POCO
{
	public class WebGlMetadataModel
	{
        public string mode { get; set; } = WebGlMetadataMode.mask.ToString();
        public string vendor { get; set; } = "Google Inc. (NVIDIA)";
        public string renderer { get; set; } = "ANGLE (NVIDIA, NVIDIA GeForce RTX 3080 Ti Laptop GPU (0x00002420) Direct3D11 vs_5_0 ps_5_0, D3D11)";
    }
}
