namespace Ghost_T.Services
{
    public class host
    {
        private readonly IWebHostEnvironment _environment;

        public host(IWebHostEnvironment environment)
        {
            _environment = environment;
        }

        public string UploadFile(IFormFile file, string folder)
        {
            if (file != null)
            {

                var pathDir = Path.Combine(_environment.WebRootPath, folder);
                var fack = Path.GetRandomFileName() + "-" + file.FileName;
                var path = Path.Combine(pathDir, fack);

                using (FileStream streem = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(streem);
                    return fack;
                }

            }
            else
            {
                return string.Empty;
            }
        }
    }
}
