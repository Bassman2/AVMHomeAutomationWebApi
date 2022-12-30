﻿using System.Xml.Serialization;

namespace AVMHomeAutomation
{
    public class EtsiUnitInfo
    {
        [XmlElement("etsideviceid")]
        public string EtsiDeviceId { get; set; }

        [XmlElement("unittype")]
        public XmlEnum<UnitType> UnitType { get; set; }

        [XmlElement("interfaces")]
        public XmlEnumList<Interfaces> Interfaces { get; set; }
    }
}
