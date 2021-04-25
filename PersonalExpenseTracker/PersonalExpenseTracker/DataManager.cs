using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalExpenseTracker
{
    class DataManager
    {
        private DataManager() { }

        private static readonly string _xmlFilePath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
            "ExpenseGuide.xml");

        private static ExpenseGuide _instance;

        private static readonly object _lock = new object();

        public static ExpenseGuide GetDataSetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        RefreshDataSetFromXML();
                    }
                }
            }

            return _instance;
        }

        public static Task RefreshXMLFromDataSetAsync()
        {
            return Task.Run(() => RefreshXMLFromDataSet());
        }

        public static void RefreshXMLFromDataSet()
        {
            try
            {
                if (File.Exists(_xmlFilePath))
                {
                    File.Delete(_xmlFilePath);
                }
                _instance.WriteXml(_xmlFilePath);
            }
            catch (Exception)
            {
                // TODO: log error
            }
        }

        private static void RefreshDataSetFromXML()
        {
            try
            {
                _instance = new ExpenseGuide();

                if (File.Exists(_xmlFilePath))
                    _instance.ReadXml(_xmlFilePath);
            }
            catch (Exception)
            {
                // TODO: log error
            }
        }
    }
}
