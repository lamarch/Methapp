using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Xml;

namespace MethApp
{
    class FileLoadSave<T>
    {
        public readonly string FileName;
        public readonly string Dir;
        Exception exception;

        string path
        {
            get {
                return Dir + "\\" + FileName + ".xml";
            }
        }

        public FileLoadSave(string fileName, string dir)
        {
            this.FileName = fileName;
            this.Dir = dir;
        }

        public Exception GetException()
        {
            return exception;
        }

        public bool Save(T obj)
        {
            if (obj.GetType() != typeof(T))
                throw new Exception("L'objet passé en arguments n'a pas le même type que le type référencé lors de l'instaciation !");
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
                using (StreamReader r = new StreamReader(this.path))
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
