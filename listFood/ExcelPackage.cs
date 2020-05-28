using System.IO;

namespace listFood
{
    internal class ExcelPackage
    {
        private FileInfo fileInfo;

        public ExcelPackage(FileInfo fileInfo)
        {
            this.fileInfo = fileInfo;
        }

        public object Workbook { get; internal set; }
    }
}