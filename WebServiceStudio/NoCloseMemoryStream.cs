
	//For licensing details please see the following link
	//http://webservicestudio.codeplex.com/license

	//8-20-2012 Web service Studio has been modified to understand more complex input types
	//such as Irdeto's Customer Care input type of Base Query Request. 
	

using System.IO;

namespace IBS.Utilities.ASMWSTester
{
    internal class NoCloseMemoryStream : MemoryStream
    {
        public override void Close()
        {
        }
    }
}
