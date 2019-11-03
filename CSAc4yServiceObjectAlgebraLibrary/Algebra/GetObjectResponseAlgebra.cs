using CSAc4yAlmostEmpty.Class;
using CSAc4yService.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSAc4yObjectService.Class
{
	public class GetObjectResponseAlgebra : GetObjectResponsePreProcessed
	{

		public Object getObject() {
        		return Object;
        }

		public Ac4yProcessResult getResult() {
        		return Result;
        }

		public String getThreadId() {
        		return ThreadId;
        }

		public Ac4yIdentification getAc4yIdentification() {
        		return Ac4yIdentification;
        }

		public Int32 getId() {
        		return id;
        }

		public String getGUID() {
        		return GUID;
        }



    		public void setObject(Object newValue) {
        		Object = newValue;
        }

    		public void setResult(Ac4yProcessResult newValue) {
        		Result = newValue;
        }

    		public void setThreadId(String newValue) {
        		ThreadId = newValue;
        }

    		public void setAc4yIdentification(Ac4yIdentification newValue) {
        		Ac4yIdentification = newValue;
        }

    		public void setId(Int32 newValue) {
        		id = newValue;
        }

    		public void setGUID(String newValue) {
        		GUID = newValue;
        }

	
		public Boolean hasObject(){
			if(this.getObject() != null){

				return true;
			}
			else
			{
				return false;
			}
		}

		public Boolean hasResult(){
			if(this.getResult() != null){

				return true;
			}
			else
			{
				return false;
			}
		}

		public Boolean hasThreadId(){
			if(this.getThreadId() != null){

				return true;
			}
			else
			{
				return false;
			}
		}

		public Boolean hasAc4yIdentification(){
			if(this.getAc4yIdentification() != null){

				return true;
			}
			else
			{
				return false;
			}
		}

		public Boolean hasId(){
			if(this.getId() != null){

				return true;
			}
			else
			{
				return false;
			}
		}

		public Boolean hasGUID(){
			if(this.getGUID() != null){

				return true;
			}
			else
			{
				return false;
			}
		}


    


	}
}
