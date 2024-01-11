namespace GoLoginTools.Services
{
    public static class RandomService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns>Return two items (string), first is vendor, second is renderer</returns>
        public static (string, string) GetRandomWebGL()
        {
            var formatWebGLRenderer = "ANGLE ({0}, {1} (0X0000{2}) Direct3D11 vs_5_0 ps_5_0, D3D11";
            var formatWebGLVendor = "Google Inc. ({0})";
            Random rand = new Random();
            string vendor = rand.NextInt64() % 2 == 0 ? "NVIDIA" : "NVIDIA";    // NVIDIA : INTEL

            if(vendor == "NVIDIA")
            {
                var vgas = LocalFileService.readAllLinesTextFile(Environment.CurrentDirectory + @"\Resources\nvidia-vgas.txt");
                var gpu = vgas[rand.NextInt64(vgas.Count() - 1)];
                formatWebGLRenderer = string.Format(formatWebGLRenderer, vendor, gpu, rand.Next(0, 65_535).ToString("X"));
                formatWebGLVendor = string.Format(formatWebGLVendor, vendor);
            }
            else
            {
                vendor = "Intel";
                var vgas = LocalFileService.readAllLinesTextFile(Environment.CurrentDirectory + @"\Resources\intel-vgas.txt");
                var gpu = vgas[rand.NextInt64(vgas.Count() - 1)];
                formatWebGLRenderer = string.Format(formatWebGLRenderer, vendor, gpu, rand.Next(0, 65_535).ToString("X"));
                formatWebGLVendor = string.Format(formatWebGLVendor, vendor);
            }

            return (formatWebGLVendor, formatWebGLRenderer);
        }
    }
}
