using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

[System.Serializable]
public class LevelText
{
    [XmlElement("BeginningText")]
    public string BeginningText;

    [XmlElement("EndText")]
    public string EndText;
}

[XmlRoot("Levels")]
public class LevelCollection
{

    [XmlArray("Level")]
    [XmlArrayItem("Entry")]
    public List<LevelText> entries = new List<LevelText>();

    public static LevelCollection Load(string path)
    {
        TextAsset _xml = Resources.Load<TextAsset>(path);

        XmlSerializer serializer = new XmlSerializer(typeof(LevelCollection));

        StringReader reader = new StringReader(_xml.text);

        LevelCollection text = serializer.Deserialize(reader) as LevelCollection;

        reader.Close();

        return text;

    }
}
