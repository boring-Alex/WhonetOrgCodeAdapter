using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using WhonetOrgCodeAdapter.Collections;

namespace WhonetOrgCodeAdapter.Controllers
{
    /// <summary>
    /// Получение данных о исследовании по его индексу
    /// </summary>
    public class PcrFileController
    {
        private PcrNames _names = new PcrNames();
        private PcrFilesRegex _filesRegex = new PcrFilesRegex();
        public string GetPcrName(PcrTypeEnum pcrType)
        {
            return _names[pcrType];
        }
        public string GetPcrName(int pcrType)
        {
            return _names[(PcrTypeEnum)pcrType];
        }
        public Regex GetFilePattern(PcrTypeEnum pcrType)
        {
            return _filesRegex[pcrType];
        }
        public Regex GetFilePattern(int pcrType)
        {
            return _filesRegex[(PcrTypeEnum)pcrType];
        }
    }
}
