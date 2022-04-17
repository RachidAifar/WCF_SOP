using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService_Test
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract (Name = "IService1")]
    public interface IService1
    {

        [OperationContract]
        string login(string name,string codemasar, string password);
        [OperationContract]
        string AddGrade(int id,string codemasar, string first_name, string last_name, string major, int grade);
        [OperationContract]
        List<Students> List();
        [OperationContract]
        Students GetStudent(int id);
        [OperationContract]
        void Addrade(Students student);
        // TODO: Add your service operations here
    }


     // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class Students
    {
        string first_name, last_name, major,codemasar = null;
        int id,grade ;
        [DataMember]
        public string First_name
        {
            get { return first_name; }
            set { first_name = value; }
        }

        [DataMember]
        public string Last_name
        {
            get { return last_name; }
            set { last_name = value; }
        }
        [DataMember]
        public string Major
        {
            get { return major; }
            set { major = value; }
        }
        [DataMember]
        public string Codemasar
        {
            get { return codemasar; }
            set { codemasar = value; }
        }
        [DataMember]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        [DataMember]
        public int Grade
        {
            get { return grade ; }
            set { grade = value; }
        }
        public Students()
        {

        }
        public Students(int id,string codemasar,string first_name, string last_name, string major,int grade)
        {
            this.first_name = first_name; this.last_name = last_name; this.major = major;this.codemasar = codemasar;
            this.id = id;this.grade = grade;
        }
    }
}
