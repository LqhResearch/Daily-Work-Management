using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace DailyWorkManagement
{
    class XmlSerialize
    {
        public static void SerializeToXML(object data, string filePath)
        {
            File.WriteAllText(filePath, ""); // Xoá nội dung file trước khi thêm vào
            FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write);
            XmlSerializer sr = new XmlSerializer(typeof(PlanData));
            sr.Serialize(fs, data);
            fs.Close();
        }

        public static object DeserializeToXML(string filePath)
        {
            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            try
            {
                XmlSerializer sr = new XmlSerializer(typeof(PlanData));
                object result = sr.Deserialize(fs);
                fs.Close();
                return result;
            }
            catch (Exception ex)
            {
                fs.Close();
                MessageBox.Show(ex.Message);
                throw new Exception();
            }
        }
    }
}
