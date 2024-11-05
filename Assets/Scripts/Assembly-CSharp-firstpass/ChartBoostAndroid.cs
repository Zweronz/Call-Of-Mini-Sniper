using System.Collections.Generic;
using Prime31;
using UnityEngine;

public class ChartBoostAndroid
{
	private static AndroidJavaObject _plugin;

	static ChartBoostAndroid()
	{
	}

	public static void onStart()
	{
	}

	public static void onDestroy()
	{
	}

	public static void onStop()
	{
	}

	public static void onBackPressed()
	{
	}

	public static void init(string appId, string appSignature, bool shouldRequestInterstitialsInFirstSession = true)
	{
	}

	public static void cacheInterstitial(string location)
	{
	}

	public static bool hasCachedInterstitial(string location)
	{
		return false;
	}

	public static void showInterstitial(string location)
	{
	}

	public static void cacheMoreApps()
	{
	}

	public static bool hasCachedMoreApps()
	{
		return false;
	}

	public static void showMoreApps()
	{
	}

	public static void trackEvent(string eventIdentifier, double value, Dictionary<string, object> metaData)
	{
	}
}
