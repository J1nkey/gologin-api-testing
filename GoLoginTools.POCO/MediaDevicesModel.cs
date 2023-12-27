namespace GoLoginTools.POCO
{
	public class MediaDevicesModel
	{
        public int videoInputs { get; set; }
        public int audioInputs { get; set; }
        public int audioOutputs { get; set; }
        public bool enableMasking { get; set; } = false;
    }
}
