using System;
using System.IO;
using System.Windows;
using System.Xml;
using System.Xml.Serialization;
using PM_Utils;

namespace MethApp
{
    class Serialisateur<T>
    {
        string fileName;
        string dir;
        Exception exception;

        string path => dir + "\\" + fileName + ".xml";

        public Serialisateur(string fileName, string dir)
        {
            this.fileName = fileName;
            this.dir = dir;
        }

        public Exception GetException()
        {
            return exception;
        }

        public bool Save(T obj)
        {
            try
            {
                using (StreamWriter w = new StreamWriter(path))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(T));
                    serializer.Serialize(w, obj);
                    w.Close();
                }
                return true;
            }
            catch (Exception e)
            {
                exception = e;
                return false;
            }

        }

        public bool CanLoad(T obj)
        {
            bool res;

            try
            {
                using (XmlReader r = new XmlTextReader(path))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(T));
                    res = serializer.CanDeserialize(r);
                    r.Close();
                }
                return res;
            }
            catch (Exception e)
            {
                exception = e;
                return false;
            }
        }

        public T Load(out bool ok)
        {
            T obj = default(T);

            try
            {
                using (StreamReader r = new StreamReader(path))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(T));
                    obj = (T)serializer.Deserialize(r);
                    r.Close();
                }
                ok = true;
                return obj;
            }
            catch (Exception e)
            {
                exception = e;
                ok = false;
                return obj;
            }
        }
    }
}
