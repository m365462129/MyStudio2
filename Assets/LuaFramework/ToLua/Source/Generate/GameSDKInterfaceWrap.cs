﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class GameSDKInterfaceWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(GameSDKInterface), typeof(System.Object));
		L.RegFunction("PauseEditorApplication", PauseEditorApplication);
		L.RegFunction("BuglySetUserId", BuglySetUserId);
		L.RegFunction("BuglyPrintLog", BuglyPrintLog);
		L.RegFunction("ReportException", ReportException);
		L.RegFunction("DebugLogError", DebugLogError);
		L.RegFunction("GetChannelName", GetChannelName);
		L.RegFunction("GetPlatformName", GetPlatformName);
		L.RegFunction("ReadFileFromeAssets", ReadFileFromeAssets);
		L.RegFunction("AssetsFileExistInInternalAssets", AssetsFileExistInInternalAssets);
		L.RegFunction("Init", Init);
		L.RegFunction("Login", Login);
		L.RegFunction("Logout", Logout);
		L.RegFunction("RestartApplication", RestartApplication);
		L.RegFunction("GetIDFA", GetIDFA);
		L.RegFunction("GetNativeAvatar", GetNativeAvatar);
		L.RegFunction("GetDataFromIosKeychain", GetDataFromIosKeychain);
		L.RegFunction("SaveDataToIosKeychain", SaveDataToIosKeychain);
		L.RegFunction("ProcessIpAndAddressFamily", ProcessIpAndAddressFamily);
		L.RegFunction("GetCurSignalStrenth", GetCurSignalStrenth);
		L.RegFunction("GetCurSignalType", GetCurSignalType);
		L.RegFunction("GetCurBatteryLevel", GetCurBatteryLevel);
		L.RegFunction("ShakePhone", ShakePhone);
		L.RegFunction("GetCurChargeState", GetCurChargeState);
		L.RegFunction("InitWechat", InitWechat);
		L.RegFunction("InitApp", InitApp);
		L.RegFunction("LoginApp", LoginApp);
		L.RegFunction("SetAlarm", SetAlarm);
		L.RegFunction("LoginWechat", LoginWechat);
		L.RegFunction("ShareUrlToWechat", ShareUrlToWechat);
		L.RegFunction("ShareImageToWechat", ShareImageToWechat);
		L.RegFunction("ShareUrl", ShareUrl);
		L.RegFunction("ShareText", ShareText);
		L.RegFunction("ShareImage", ShareImage);
		L.RegFunction("ShareMiniProgramToWechat", ShareMiniProgramToWechat);
		L.RegFunction("WechatRecharge", WechatRecharge);
		L.RegFunction("CommonRecharge", CommonRecharge);
		L.RegFunction("GetIpsByHttpDNS", GetIpsByHttpDNS);
		L.RegFunction("BeginLocation", BeginLocation);
		L.RegFunction("StopLocation", StopLocation);
		L.RegFunction("IsGpsOpen", IsGpsOpen);
		L.RegFunction("AndroidIsRoot", AndroidIsRoot);
		L.RegFunction("AndroidIsSimulator", AndroidIsSimulator);
		L.RegFunction("StartActivity", StartActivity);
		L.RegFunction("CaculateDistance", CaculateDistance);
		L.RegFunction("BuyAppStoreProduct", BuyAppStoreProduct);
		L.RegFunction("IsUserCloseNetWork", IsUserCloseNetWork);
		L.RegFunction("GetCurSdCardSize", GetCurSdCardSize);
		L.RegFunction("CopyToClipboard", CopyToClipboard);
		L.RegFunction("GetTextFromClipboard", GetTextFromClipboard);
		L.RegFunction("CopyTextToClipboard", CopyTextToClipboard);
		L.RegFunction("StartApp", StartApp);
		L.RegFunction("IsAppExist", IsAppExist);
		L.RegFunction("JPushInit", JPushInit);
		L.RegFunction("JPushStopPush", JPushStopPush);
		L.RegFunction("JPushResumePush", JPushResumePush);
		L.RegFunction("JPushIsPushStopped", JPushIsPushStopped);
		L.RegFunction("JPushQuit", JPushQuit);
		L.RegFunction("JPushSetDebug", JPushSetDebug);
		L.RegFunction("JPushGetRegistrationId", JPushGetRegistrationId);
		L.RegFunction("JPushSetTags", JPushSetTags);
		L.RegFunction("JPushSetAlias", JPushSetAlias);
		L.RegFunction("JPushSetPushTime", JPushSetPushTime);
		L.RegFunction("JPushSetSilenceTime", JPushSetSilenceTime);
		L.RegFunction("JPushSetLatestNotificationNumber", JPushSetLatestNotificationNumber);
		L.RegFunction("JPushInitCrashHandler", JPushInitCrashHandler);
		L.RegFunction("JPushStopCrashHandler", JPushStopCrashHandler);
		L.RegFunction("SetImageSize", SetImageSize);
		L.RegFunction("OpenPick", OpenPick);
		L.RegFunction("OpenCamera", OpenCamera);
		L.RegFunction("SendRequestToPhone", SendRequestToPhone);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("onLoginSuc", get_onLoginSuc, set_onLoginSuc);
		L.RegVar("onLogout", get_onLogout, set_onLogout);
		L.RegVar("instance", get_instance, null);
		L.RegFunction("LogoutHandler", GameSDKInterface_LogoutHandler);
		L.RegFunction("LoginSucHandler", GameSDKInterface_LoginSucHandler);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int PauseEditorApplication(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			GameSDKInterface obj = (GameSDKInterface)ToLua.CheckObject<GameSDKInterface>(L, 1);
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.PauseEditorApplication(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int BuglySetUserId(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			GameSDKInterface obj = (GameSDKInterface)ToLua.CheckObject<GameSDKInterface>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			obj.BuglySetUserId(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int BuglyPrintLog(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			GameSDKInterface obj = (GameSDKInterface)ToLua.CheckObject<GameSDKInterface>(L, 1);
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			string arg1 = ToLua.CheckString(L, 3);
			obj.BuglyPrintLog(arg0, arg1);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ReportException(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 4);
			GameSDKInterface obj = (GameSDKInterface)ToLua.CheckObject<GameSDKInterface>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			string arg1 = ToLua.CheckString(L, 3);
			string arg2 = ToLua.CheckString(L, 4);
			obj.ReportException(arg0, arg1, arg2);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DebugLogError(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			GameSDKInterface obj = (GameSDKInterface)ToLua.CheckObject<GameSDKInterface>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			obj.DebugLogError(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetChannelName(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			GameSDKInterface obj = (GameSDKInterface)ToLua.CheckObject<GameSDKInterface>(L, 1);
			string o = obj.GetChannelName();
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetPlatformName(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			GameSDKInterface obj = (GameSDKInterface)ToLua.CheckObject<GameSDKInterface>(L, 1);
			string o = obj.GetPlatformName();
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ReadFileFromeAssets(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			GameSDKInterface obj = (GameSDKInterface)ToLua.CheckObject<GameSDKInterface>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			string o = obj.ReadFileFromeAssets(arg0);
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AssetsFileExistInInternalAssets(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			GameSDKInterface obj = (GameSDKInterface)ToLua.CheckObject<GameSDKInterface>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			bool o = obj.AssetsFileExistInInternalAssets(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Init(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			GameSDKInterface obj = (GameSDKInterface)ToLua.CheckObject<GameSDKInterface>(L, 1);
			obj.Init();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Login(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			GameSDKInterface obj = (GameSDKInterface)ToLua.CheckObject<GameSDKInterface>(L, 1);
			obj.Login();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Logout(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			GameSDKInterface obj = (GameSDKInterface)ToLua.CheckObject<GameSDKInterface>(L, 1);
			bool o = obj.Logout();
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RestartApplication(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			GameSDKInterface obj = (GameSDKInterface)ToLua.CheckObject<GameSDKInterface>(L, 1);
			bool o = obj.RestartApplication();
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetIDFA(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			GameSDKInterface obj = (GameSDKInterface)ToLua.CheckObject<GameSDKInterface>(L, 1);
			string o = obj.GetIDFA();
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetNativeAvatar(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			GameSDKInterface obj = (GameSDKInterface)ToLua.CheckObject<GameSDKInterface>(L, 1);
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.GetNativeAvatar(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetDataFromIosKeychain(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			GameSDKInterface obj = (GameSDKInterface)ToLua.CheckObject<GameSDKInterface>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			string o = obj.GetDataFromIosKeychain(arg0);
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SaveDataToIosKeychain(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			GameSDKInterface obj = (GameSDKInterface)ToLua.CheckObject<GameSDKInterface>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			string arg1 = ToLua.CheckString(L, 3);
			bool o = obj.SaveDataToIosKeychain(arg0, arg1);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ProcessIpAndAddressFamily(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 4);
			GameSDKInterface obj = (GameSDKInterface)ToLua.CheckObject<GameSDKInterface>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			string arg1 = null;
			System.Net.Sockets.AddressFamily arg2;
			bool o = obj.ProcessIpAndAddressFamily(arg0, out arg1, out arg2);
			LuaDLL.lua_pushboolean(L, o);
			LuaDLL.lua_pushstring(L, arg1);
			ToLua.Push(L, arg2);
			return 3;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetCurSignalStrenth(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			GameSDKInterface obj = (GameSDKInterface)ToLua.CheckObject<GameSDKInterface>(L, 1);
			int o = obj.GetCurSignalStrenth();
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetCurSignalType(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			GameSDKInterface obj = (GameSDKInterface)ToLua.CheckObject<GameSDKInterface>(L, 1);
			string o = obj.GetCurSignalType();
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetCurBatteryLevel(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			GameSDKInterface obj = (GameSDKInterface)ToLua.CheckObject<GameSDKInterface>(L, 1);
			int o = obj.GetCurBatteryLevel();
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ShakePhone(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			GameSDKInterface obj = (GameSDKInterface)ToLua.CheckObject<GameSDKInterface>(L, 1);
			long arg0 = LuaDLL.tolua_checkint64(L, 2);
			obj.ShakePhone(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetCurChargeState(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			GameSDKInterface obj = (GameSDKInterface)ToLua.CheckObject<GameSDKInterface>(L, 1);
			bool o = obj.GetCurChargeState();
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int InitWechat(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			GameSDKInterface obj = (GameSDKInterface)ToLua.CheckObject<GameSDKInterface>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			obj.InitWechat(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int InitApp(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			GameSDKInterface obj = (GameSDKInterface)ToLua.CheckObject<GameSDKInterface>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			obj.InitApp(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LoginApp(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			GameSDKInterface obj = (GameSDKInterface)ToLua.CheckObject<GameSDKInterface>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			obj.LoginApp(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetAlarm(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			GameSDKInterface obj = (GameSDKInterface)ToLua.CheckObject<GameSDKInterface>(L, 1);
			long arg0 = LuaDLL.tolua_checkint64(L, 2);
			string arg1 = ToLua.CheckString(L, 3);
			obj.SetAlarm(arg0, arg1);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LoginWechat(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			GameSDKInterface obj = (GameSDKInterface)ToLua.CheckObject<GameSDKInterface>(L, 1);
			obj.LoginWechat();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ShareUrlToWechat(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			GameSDKInterface obj = (GameSDKInterface)ToLua.CheckObject<GameSDKInterface>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			obj.ShareUrlToWechat(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ShareImageToWechat(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			GameSDKInterface obj = (GameSDKInterface)ToLua.CheckObject<GameSDKInterface>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			obj.ShareImageToWechat(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ShareUrl(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			GameSDKInterface obj = (GameSDKInterface)ToLua.CheckObject<GameSDKInterface>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			obj.ShareUrl(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ShareText(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			GameSDKInterface obj = (GameSDKInterface)ToLua.CheckObject<GameSDKInterface>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			obj.ShareText(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ShareImage(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			GameSDKInterface obj = (GameSDKInterface)ToLua.CheckObject<GameSDKInterface>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			obj.ShareImage(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ShareMiniProgramToWechat(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			GameSDKInterface obj = (GameSDKInterface)ToLua.CheckObject<GameSDKInterface>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			obj.ShareMiniProgramToWechat(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int WechatRecharge(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			GameSDKInterface obj = (GameSDKInterface)ToLua.CheckObject<GameSDKInterface>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			obj.WechatRecharge(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CommonRecharge(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			GameSDKInterface obj = (GameSDKInterface)ToLua.CheckObject<GameSDKInterface>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			obj.CommonRecharge(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetIpsByHttpDNS(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			GameSDKInterface obj = (GameSDKInterface)ToLua.CheckObject<GameSDKInterface>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			string o = obj.GetIpsByHttpDNS(arg0);
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int BeginLocation(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				GameSDKInterface obj = (GameSDKInterface)ToLua.CheckObject<GameSDKInterface>(L, 1);
				bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
				obj.BeginLocation(arg0);
				return 0;
			}
			else if (count == 4)
			{
				GameSDKInterface obj = (GameSDKInterface)ToLua.CheckObject<GameSDKInterface>(L, 1);
				bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
				bool arg1 = LuaDLL.luaL_checkboolean(L, 3);
				int arg2 = (int)LuaDLL.luaL_checknumber(L, 4);
				obj.BeginLocation(arg0, arg1, arg2);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: GameSDKInterface.BeginLocation");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int StopLocation(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			GameSDKInterface obj = (GameSDKInterface)ToLua.CheckObject<GameSDKInterface>(L, 1);
			obj.StopLocation();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IsGpsOpen(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			GameSDKInterface obj = (GameSDKInterface)ToLua.CheckObject<GameSDKInterface>(L, 1);
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			bool o = obj.IsGpsOpen(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AndroidIsRoot(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			GameSDKInterface obj = (GameSDKInterface)ToLua.CheckObject<GameSDKInterface>(L, 1);
			bool o = obj.AndroidIsRoot();
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AndroidIsSimulator(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			GameSDKInterface obj = (GameSDKInterface)ToLua.CheckObject<GameSDKInterface>(L, 1);
			bool o = obj.AndroidIsSimulator();
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int StartActivity(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			GameSDKInterface obj = (GameSDKInterface)ToLua.CheckObject<GameSDKInterface>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			obj.StartActivity(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CaculateDistance(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 5);
			GameSDKInterface obj = (GameSDKInterface)ToLua.CheckObject<GameSDKInterface>(L, 1);
			double arg0 = (double)LuaDLL.luaL_checknumber(L, 2);
			double arg1 = (double)LuaDLL.luaL_checknumber(L, 3);
			double arg2 = (double)LuaDLL.luaL_checknumber(L, 4);
			double arg3 = (double)LuaDLL.luaL_checknumber(L, 5);
			double o = obj.CaculateDistance(arg0, arg1, arg2, arg3);
			LuaDLL.lua_pushnumber(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int BuyAppStoreProduct(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			GameSDKInterface obj = (GameSDKInterface)ToLua.CheckObject<GameSDKInterface>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			obj.BuyAppStoreProduct(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IsUserCloseNetWork(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			GameSDKInterface obj = (GameSDKInterface)ToLua.CheckObject<GameSDKInterface>(L, 1);
			obj.IsUserCloseNetWork();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetCurSdCardSize(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			GameSDKInterface obj = (GameSDKInterface)ToLua.CheckObject<GameSDKInterface>(L, 1);
			float o = obj.GetCurSdCardSize();
			LuaDLL.lua_pushnumber(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CopyToClipboard(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			GameSDKInterface obj = (GameSDKInterface)ToLua.CheckObject<GameSDKInterface>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			obj.CopyToClipboard(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetTextFromClipboard(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			GameSDKInterface obj = (GameSDKInterface)ToLua.CheckObject<GameSDKInterface>(L, 1);
			string o = obj.GetTextFromClipboard();
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CopyTextToClipboard(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			GameSDKInterface obj = (GameSDKInterface)ToLua.CheckObject<GameSDKInterface>(L, 1);
			string o = obj.CopyTextToClipboard();
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int StartApp(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			GameSDKInterface obj = (GameSDKInterface)ToLua.CheckObject<GameSDKInterface>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			obj.StartApp(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IsAppExist(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			GameSDKInterface obj = (GameSDKInterface)ToLua.CheckObject<GameSDKInterface>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			bool o = obj.IsAppExist(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int JPushInit(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			GameSDKInterface obj = (GameSDKInterface)ToLua.CheckObject<GameSDKInterface>(L, 1);
			obj.JPushInit();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int JPushStopPush(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			GameSDKInterface obj = (GameSDKInterface)ToLua.CheckObject<GameSDKInterface>(L, 1);
			obj.JPushStopPush();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int JPushResumePush(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			GameSDKInterface obj = (GameSDKInterface)ToLua.CheckObject<GameSDKInterface>(L, 1);
			obj.JPushResumePush();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int JPushIsPushStopped(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			GameSDKInterface obj = (GameSDKInterface)ToLua.CheckObject<GameSDKInterface>(L, 1);
			bool o = obj.JPushIsPushStopped();
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int JPushQuit(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			GameSDKInterface obj = (GameSDKInterface)ToLua.CheckObject<GameSDKInterface>(L, 1);
			obj.JPushQuit();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int JPushSetDebug(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			GameSDKInterface obj = (GameSDKInterface)ToLua.CheckObject<GameSDKInterface>(L, 1);
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.JPushSetDebug(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int JPushGetRegistrationId(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			GameSDKInterface obj = (GameSDKInterface)ToLua.CheckObject<GameSDKInterface>(L, 1);
			string o = obj.JPushGetRegistrationId();
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int JPushSetTags(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			GameSDKInterface obj = (GameSDKInterface)ToLua.CheckObject<GameSDKInterface>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			bool o = obj.JPushSetTags(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int JPushSetAlias(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			GameSDKInterface obj = (GameSDKInterface)ToLua.CheckObject<GameSDKInterface>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			bool o = obj.JPushSetAlias(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int JPushSetPushTime(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 4);
			GameSDKInterface obj = (GameSDKInterface)ToLua.CheckObject<GameSDKInterface>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			int arg1 = (int)LuaDLL.luaL_checknumber(L, 3);
			int arg2 = (int)LuaDLL.luaL_checknumber(L, 4);
			bool o = obj.JPushSetPushTime(arg0, arg1, arg2);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int JPushSetSilenceTime(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 5);
			GameSDKInterface obj = (GameSDKInterface)ToLua.CheckObject<GameSDKInterface>(L, 1);
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			int arg1 = (int)LuaDLL.luaL_checknumber(L, 3);
			int arg2 = (int)LuaDLL.luaL_checknumber(L, 4);
			int arg3 = (int)LuaDLL.luaL_checknumber(L, 5);
			bool o = obj.JPushSetSilenceTime(arg0, arg1, arg2, arg3);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int JPushSetLatestNotificationNumber(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			GameSDKInterface obj = (GameSDKInterface)ToLua.CheckObject<GameSDKInterface>(L, 1);
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			bool o = obj.JPushSetLatestNotificationNumber(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int JPushInitCrashHandler(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			GameSDKInterface obj = (GameSDKInterface)ToLua.CheckObject<GameSDKInterface>(L, 1);
			obj.JPushInitCrashHandler();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int JPushStopCrashHandler(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			GameSDKInterface obj = (GameSDKInterface)ToLua.CheckObject<GameSDKInterface>(L, 1);
			obj.JPushStopCrashHandler();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetImageSize(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			GameSDKInterface obj = (GameSDKInterface)ToLua.CheckObject<GameSDKInterface>(L, 1);
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			int arg1 = (int)LuaDLL.luaL_checknumber(L, 3);
			obj.SetImageSize(arg0, arg1);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OpenPick(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			GameSDKInterface obj = (GameSDKInterface)ToLua.CheckObject<GameSDKInterface>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			obj.OpenPick(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OpenCamera(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			GameSDKInterface obj = (GameSDKInterface)ToLua.CheckObject<GameSDKInterface>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			obj.OpenCamera(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SendRequestToPhone(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			GameSDKInterface obj = (GameSDKInterface)ToLua.CheckObject<GameSDKInterface>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			obj.SendRequestToPhone(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onLoginSuc(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			GameSDKInterface obj = (GameSDKInterface)o;
			GameSDKInterface.LoginSucHandler ret = obj.onLoginSuc;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onLoginSuc on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onLogout(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			GameSDKInterface obj = (GameSDKInterface)o;
			GameSDKInterface.LogoutHandler ret = obj.onLogout;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onLogout on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_instance(IntPtr L)
	{
		try
		{
			ToLua.PushObject(L, GameSDKInterface.instance);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onLoginSuc(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			GameSDKInterface obj = (GameSDKInterface)o;
			GameSDKInterface.LoginSucHandler arg0 = (GameSDKInterface.LoginSucHandler)ToLua.CheckDelegate<GameSDKInterface.LoginSucHandler>(L, 2);
			obj.onLoginSuc = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onLoginSuc on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onLogout(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			GameSDKInterface obj = (GameSDKInterface)o;
			GameSDKInterface.LogoutHandler arg0 = (GameSDKInterface.LogoutHandler)ToLua.CheckDelegate<GameSDKInterface.LogoutHandler>(L, 2);
			obj.onLogout = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onLogout on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GameSDKInterface_LogoutHandler(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);

			if (count == 1)
			{
				Delegate arg1 = DelegateTraits<GameSDKInterface.LogoutHandler>.Create(func);
				ToLua.Push(L, arg1);
			}
			else
			{
				LuaTable self = ToLua.CheckLuaTable(L, 2);
				Delegate arg1 = DelegateTraits<GameSDKInterface.LogoutHandler>.Create(func, self);
				ToLua.Push(L, arg1);
			}
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GameSDKInterface_LoginSucHandler(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);

			if (count == 1)
			{
				Delegate arg1 = DelegateTraits<GameSDKInterface.LoginSucHandler>.Create(func);
				ToLua.Push(L, arg1);
			}
			else
			{
				LuaTable self = ToLua.CheckLuaTable(L, 2);
				Delegate arg1 = DelegateTraits<GameSDKInterface.LoginSucHandler>.Create(func, self);
				ToLua.Push(L, arg1);
			}
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}
