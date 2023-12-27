namespace GoLoginTools.POCO
{
	public class StorageModel
	{
        public bool local { get; set; } = true;
		public bool extensions { get; set; } = true;
        public bool bookMarks { get; set; }  = true;
        public bool history { get; set; }    = true;
        public bool passwords { get; set; }  = true;
        public bool session { get; set; } = true;
        public bool indexedDb { get; set; } = false;
    }
}
