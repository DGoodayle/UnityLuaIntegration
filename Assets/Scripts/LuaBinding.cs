using UnityEngine;
using System.Collections;
using LuaInterface; //Reference the LuaInterface DLL

public class LuaBinding  {
	//Reference to bound Lua function set within Lua
	public LuaFunction boundMessageFunction;
	public void BindMessageFunction(LuaFunction func){
		//Binding
		boundMessageFunction = func;	
	}
	public void MessageFromLua(string message){
		//Output message into the debug log
		Debug.Log(message);	
	}
	public void MessageToLua(){
		//Call the bound function with a string as its first param
		boundMessageFunction.Call("Hello");
	}
}
