
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CSAc4yAlmostEmpty.Class;
using CSAc4yService.Class;
using GuidLibrary;

namespace CSAc4yObjectService.Class 
{
	            [GUID("c0dce9a0-b4c8-4d2b-9a2b-6906e1a5f434")]
	public class GetObjectResponsePreProcessed : Ac4yServiceResponsePreProcessed

	{
    		public Object Object { get; set; }
    		public Ac4yProcessResult Result { get; set; }
    		public String ThreadId { get; set; }
    		public Ac4yIdentification Ac4yIdentification { get; set; }
    		public Int32 id { get; set; }
    		public String GUID { get; set; }
		
		public GetObjectResponsePreProcessed()
		{
			GUID = "c0dce9a0-b4c8-4d2b-9a2b-6906e1a5f434";
		}
	}
}