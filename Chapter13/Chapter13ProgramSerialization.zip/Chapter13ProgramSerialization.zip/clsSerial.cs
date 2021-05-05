using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace Chapter13ProgramSerialization.zip
{
    class clsSerial
    {
        private string name;
        private string email;
        private int status;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }

        public int Status
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
            }
        }
        public int SerializeFriend(clsSerial myFriend)
        {
            try
            {
                BinaryFormatter format = new BinaryFormatter();
                FileStream myStream = new FileStream("Test.bin", FileMode.Create);
                format.Serialize(myStream, myFriend);
                myStream.Close();
            }
            catch (Exception ex)
            {
                string buff = ex.Message;
                return 0;
            }
            return 1;
        }

        public clsSerial DeserializeFriend()
        {
            clsSerial temp = new clsSerial();
            try
            {
                BinaryFormatter format = new BinaryFormatter();
                FileStream myStream = new FileStream("Test.bin", FileMode.Open);

                temp = (clsSerial)format.Deserialize(myStream);
                myStream.Close();
            }
            catch (Exception ex)
            {
                string buff = ex.Message;
                return null;
            }
            return temp;
        }
    }

}
