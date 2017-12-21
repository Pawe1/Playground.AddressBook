using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using AddressBook;
using NUnit.Framework;

namespace AddressBook.Tests
{
    [TestFixture]
    public class MultitestFixture
    {
        [Test]
        public void TestCreation()
        {
            Contacts sut = new AddressBook.Contacts();

            Contact c = new Contact()
            {
                Address="Zoppot 🏠",
                Name ="Andrzej",
                Surname ="Nieszczególny",
                Telephone ="1234"
            };

            sut.Items.Add(c);

            XmlSerializer serializer = new XmlSerializer(typeof(Contacts));

            TextWriter writer = new StreamWriter(@"C:\Spreadsheet\test.xml");  
            serializer.Serialize(writer, sut);  
            writer.Close();
        }


        [Test]
        public void TestLoading()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Contacts));

            TextReader reader = new StreamReader(@"C:\Spreadsheet\test.xml");
            var sut = serializer.Deserialize(reader);
            reader.Close();
        }
    }
}
