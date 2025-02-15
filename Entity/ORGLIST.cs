using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WhonetOrgCodeAdapter.Entity
{
    /// <summary>
    /// Представление записи таблицы данных WHONET по микроорганизмам
    /// </summary>
    [XmlRoot(ElementName = "ORGLIST")]
    public class ORGLIST
    {

        [XmlElement(ElementName = "ID")]
        public int ID { get; set; }

        [XmlElement(ElementName = "ORG")]
        public string ORG { get; set; }

        [XmlElement(ElementName = "GRAM")]
        public string GRAM { get; set; }

        [XmlElement(ElementName = "ORGANISM")]
        public string ORGANISM { get; set; }

        [XmlElement(ElementName = "ORG_CLEAN")]
        public string ORGCLEAN { get; set; }

        [XmlElement(ElementName = "STATUS")]
        public string STATUS { get; set; }

        [XmlElement(ElementName = "ORG_GROUP")]
        public string ORGGROUP { get; set; }

        [XmlElement(ElementName = "GENUS")]
        public string GENUS { get; set; }

        [XmlElement(ElementName = "GENUS_CODE")]
        public string GENUSCODE { get; set; }

        [XmlElement(ElementName = "SCT_CODE")]
        public int SCTCODE { get; set; }

        [XmlElement(ElementName = "SCT_TEXT")]
        public string SCTTEXT { get; set; }
    }


}
