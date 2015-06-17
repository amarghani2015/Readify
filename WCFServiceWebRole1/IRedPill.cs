using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Net.Security;

namespace WCFServiceWebRole1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IRedPill" in both code and config file together.
    [ServiceContract(Namespace = "http://KnockKnock.readify.net")]
    public interface IRedPill
    {
        [OperationContract]
        [FaultContract(typeof(ArgumentOutOfRangeException))]
        //[WebGet(UriTemplate = "FibonacciNumber/{n}", ResponseFormat = WebMessageFormat.Xml)]
        long FibonacciNumber(long n);

        [OperationContract]
        //[WebGet(UriTemplate = "WhatIsYourToken", ResponseFormat = WebMessageFormat.Xml)]
        Guid WhatIsYourToken();

        [OperationContract]
        //[WebGet(UriTemplate = "WhatIsYourToken", ResponseFormat = WebMessageFormat.Xml)]
        TriangleType WhatShapeIsThis(int a, int b, int c);

        [OperationContract]
        [FaultContract(typeof(ArgumentNullException))]
        //[WebGet(UriTemplate = "WhatIsYourToken", ResponseFormat = WebMessageFormat.Xml)]
        string ReverseWords(string s);
    }

    [DataContract(Namespace = "http://KnockKnock.readify.net")]
    [Flags]
    public enum TriangleType { 
        [EnumMember]
        Equilateral = 1,
        [EnumMember]
        Error = 2, 
        [EnumMember]
        Isosceles = 3, 
        [EnumMember]
        Scalene = 4 
    }

    //[DataContract(Namespace = "http://KnockKnock.readify.net")]
    //public class ArgumentNullException
    //{
    //    [DataMember]
    //    public string Message { get; set; }
    //}
    //[DataContract(Namespace = "http://KnockKnock.readify.net")]
    //public class ArgumentOutOfRangeException
    //{
    //    [DataMember]
    //    public string Message { get; set; }
    //}
}
