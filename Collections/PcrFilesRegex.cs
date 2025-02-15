using System.Text.RegularExpressions;

namespace WhonetOrgCodeAdapter.Collections
{
    /// <summary>
    /// Словарь регулярных выражений для поиска файлов по названию
    /// </summary>
    public class PcrFilesRegex : Dictionary<PcrTypeEnum, Regex>
    {
        public PcrFilesRegex()
        {
            Add(PcrTypeEnum.Carbapenems, new Regex(@"MBL[0-9]{2}RUS.PCR"));
            Add(PcrTypeEnum.MRSA, new Regex(@"MRSA[0-9]{2}RUS.PCR"));
            Add(PcrTypeEnum.Acinetobacter, new Regex(@"Acinetobacter[0-9]{2}RUS.PCR"));
            Add(PcrTypeEnum.VanAB, new Regex(@"vanAvanB[0-9]{2}RUS.PCR"));
        }
    }
}
