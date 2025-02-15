namespace WhonetOrgCodeAdapter.Collections
{
    /// <summary>
    /// Словарь названий ПЦР-исследований
    /// </summary>
    public class PcrNames : Dictionary<PcrTypeEnum, string>
    {
        public PcrNames()
        {
            Add(PcrTypeEnum.Carbapenems, "Исследование на гены резистентности энтеробактерий и синегнойных палочек");
            Add(PcrTypeEnum.MRSA, "Исследование на метициллинрезистентность S. aureus");
            Add(PcrTypeEnum.Acinetobacter, "Исследование на гены резистентности Acinetobacter sp.");
            Add(PcrTypeEnum.VanAB, "Исследование на ванкомицинрезистентность");
        }
        /// <summary>
        /// Получение списка названий исследований для списков
        /// </summary>
        /// <returns>Список названий ПЦР-исследований</returns>
        public IEnumerable<string> GetNames()
        {
            foreach(KeyValuePair<PcrTypeEnum , string> kvp in this)
            {
                yield return kvp.Value;
            }
        }
    }
}
