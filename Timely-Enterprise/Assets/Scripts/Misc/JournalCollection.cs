using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

[System.Serializable]
public class JournalEntry
{
    [XmlAttribute("date")]
    public string date;

    [XmlElement("Paragraph1")]
    public string paragraph1;

    [XmlElement("Paragraph2")]
    public string paragraph2;
}

[XmlRoot("JournalEntries")]
public class JournalCollection {

    [XmlArray("Person")]
    [XmlArrayItem("Entry")]
    public List<JournalEntry> entries = new List<JournalEntry>();

    public static JournalCollection Load(string path)
    {
        TextAsset _xml = Resources.Load<TextAsset>(path);

        XmlSerializer serializer = new XmlSerializer(typeof(JournalCollection));

        StringReader reader = new StringReader(_xml.text);

        JournalCollection text = serializer.Deserialize(reader) as JournalCollection;

        reader.Close();

        return text;

    }
}
