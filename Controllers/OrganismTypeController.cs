using WhonetOrgCodeAdapter.Collections;
using WhonetOrgCodeAdapter.Entity;

namespace WhonetOrgCodeAdapter.Controllers
{
    /// <summary>
    /// Получение информации о микроорганизме по его коду
    /// </summary>
    public class OrganismTypeController
    {
        private Organisms _orgs = new Organisms();
        private string _orgCode = "";
        /// <summary>
        /// Сеттер для кода на проверку
        /// </summary>
        public string OrgCode
        {
            set
            {
                if(value.Length != 3) { throw new ArgumentException("Длина кода должна равняться трём!"); }
                _orgCode = value;
            }
        }
        /// <summary>
        /// Является ли данный код микроорганизма первичным, который изменится в дальнейшем
        /// </summary>
        /// <returns>Истина если код в дальнейшем поменяется</returns>
        /// <exception cref="ArgumentException"></exception>
        public bool IsPreliminary()
        {
            if(_orgCode == "") { throw new ArgumentException("Не указан код!"); }
            ORGLIST org = _orgs.First(x=>x.ORG == _orgCode.ToLower());
            if(org.GENUSCODE == "") { return true; }
            if(org.GENUSCODE.ToLower() == org.ORG.ToLower()) { return true; }
            if(org.SCTTEXT.ToLower().Contains("genus")) { return true; }
            if (org.SCTTEXT.ToLower().Contains("sp.")) { return true; }
            return false;
        }
        /// <summary>
        /// Проверка, подходит ли для данного микроорганизма такое исследование
        /// </summary>
        /// <param name="pcrType">Тип ПЦР-исследования</param>
        /// <returns>Истина, если подходит для данного микроорганизма</returns>
        public bool IsPcrAvaliable(PcrTypeEnum pcrType)
        {
            if (_orgCode == "") { throw new ArgumentException("Не указан код!"); }
            ORGLIST org = _orgs.First(x => x.ORG == _orgCode.ToLower());
            if(pcrType == PcrTypeEnum.MRSA) { return checkMrsa(org); }
            if (pcrType == PcrTypeEnum.Carbapenems) { return checkMBL(org); }
            if (pcrType == PcrTypeEnum.Acinetobacter) { return checkAcinetobacter(org); }
            if (pcrType == PcrTypeEnum.VanAB) { return checkVre(org); }
            throw new ArgumentException("Такой тип исследования еще не определён!");
        }
        private bool checkMrsa(ORGLIST checkedOrg)
        {
            return checkedOrg.GENUS == "Staphylococcus";
        }
        private bool checkMBL(ORGLIST checkedOrg)
        {
            return checkedOrg.ORGGROUP == "EBC" || checkedOrg.GENUS == "Pseudomonas";
        }
        private bool checkVre(ORGLIST checkedOrg)
        {
            return checkedOrg.GENUS == "Staphylococcus" || checkedOrg.GENUS == "Enterococcus";
        }
        private bool checkAcinetobacter(ORGLIST checkedOrg)
        {
            return checkedOrg.GENUS == "Acinetobacter";
        }
    }
}
