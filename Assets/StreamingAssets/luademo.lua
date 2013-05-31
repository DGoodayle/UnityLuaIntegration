function WriteFromLua(text)  -- Simple function to call the function inside LuaBinding.cs to out a message
	luabinding:MessageFromLua(text)
end

luabinding:BindMessageFunction(WriteFromLua) -- Tell LuaBinding.cs to bind the WriteFromLua function to its LuaFunction variable