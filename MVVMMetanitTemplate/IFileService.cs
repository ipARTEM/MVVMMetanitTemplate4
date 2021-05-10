using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMMetanitTemplate
{
    public interface IFileService
    {
        /// <summary>
        /// для открытия файла
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        List<Phone> Open(string filename);

        /// <summary>
        /// сохраняет данные из списка в файле по определенному пути.
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="phonesList"></param>
        void Save(string filename, List<Phone> phonesList);
    }
}
