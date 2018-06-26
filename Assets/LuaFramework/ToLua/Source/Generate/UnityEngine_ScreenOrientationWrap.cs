﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_ScreenOrientationWrap
{
	public static void Register(LuaState L)
	{
		L.BeginEnum(typeof(UnityEngine.ScreenOrientation));
		L.RegVar("Unknown", get_Unknown, null);
		L.RegVar("Portrait", get_Portrait, null);
		L.RegVar("PortraitUpsideDown", get_PortraitUpsideDown, null);
		L.RegVar("LandscapeLeft", get_LandscapeLeft, null);
		L.RegVar("LandscapeRight", get_LandscapeRight, null);
		L.RegVar("AutoRotation", get_AutoRotation, null);
		L.RegVar("Landscape", get_Landscape, null);
		L.RegFunction("IntToEnum", IntToEnum);
		L.EndEnum();
		TypeTraits<UnityEngine.ScreenOrientation>.Check = CheckType;
		StackTraits<UnityEngine.ScreenOrientation>.Push = Push;
	}

	static void Push(IntPtr L, UnityEngine.ScreenOrientation arg)
	{
		ToLua.Push(L, arg);
	}

	static bool CheckType(IntPtr L, int pos)
	{
		return TypeChecker.CheckEnumType(typeof(UnityEngine.ScreenOrientation), L, pos);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Unknown(IntPtr L)
	{
		ToLua.Push(L, UnityEngine.ScreenOrientation.Unknown);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Portrait(IntPtr L)
	{
		ToLua.Push(L, UnityEngine.ScreenOrientation.Portrait);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_PortraitUpsideDown(IntPtr L)
	{
		ToLua.Push(L, UnityEngine.ScreenOrientation.PortraitUpsideDown);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_LandscapeLeft(IntPtr L)
	{
		ToLua.Push(L, UnityEngine.ScreenOrientation.LandscapeLeft);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_LandscapeRight(IntPtr L)
	{
		ToLua.Push(L, UnityEngine.ScreenOrientation.LandscapeRight);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_AutoRotation(IntPtr L)
	{
		ToLua.Push(L, UnityEngine.ScreenOrientation.AutoRotation);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Landscape(IntPtr L)
	{
		ToLua.Push(L, UnityEngine.ScreenOrientation.Landscape);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		UnityEngine.ScreenOrientation o = (UnityEngine.ScreenOrientation)arg0;
		ToLua.Push(L, o);
		return 1;
	}
}
