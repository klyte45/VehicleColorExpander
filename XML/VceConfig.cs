using System.Collections.Generic;
using System.Xml.Serialization;

namespace Klyte.VehicleColorExpander.XML
{
    [XmlRoot(ElementName = "vceConfig")]
    public class VceConfig
    {
        [XmlElement(ElementName = "vce")]
        public List<ColorConfigurationXml> ConfigList { get; set; }
    }
}
