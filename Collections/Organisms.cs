using WhonetOrgCodeAdapter.Entity;
using System.Xml.Serialization;

namespace WhonetOrgCodeAdapter.Collections
{
    /// <summary>
    /// Список микроорганизмов ORGLIST WHONET
    /// </summary>
    public class Organisms : List<ORGLIST>
    {
        private string _pathToFile = Path.Combine(Directory.GetCurrentDirectory(),"Data","ORGLIST.xml");
        /// <summary>
        /// Загрузка данных из xml
        /// </summary>
        public void Load()
        {
            Clear();
            TrimExcess();
            List<ORGLIST> tempObj = new List<ORGLIST>();
            using (StringReader reader = new StringReader(_pathToFile))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<ORGLIST>));
                tempObj = (List<ORGLIST>)serializer.Deserialize(reader);
            }
            AddRange(tempObj);
        }
        public Organisms()
        {
            Load();
        }
    }
}
