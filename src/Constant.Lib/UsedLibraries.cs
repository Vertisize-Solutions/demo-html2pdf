using System.Collections.Generic;

namespace Constant.Lib
{
    public class UsedLibraries
    {
        public UsedLibraries()
        {
            usedLibraries = new List<LibraryModel>();
            usedLibraries.Add(new LibraryModel("iText", "7", "https://itextpdf.com/en/products/itext-7", "GNU Affero General Public License"));
        }

        public List<LibraryModel> usedLibraries { get; set; }
    }
}
