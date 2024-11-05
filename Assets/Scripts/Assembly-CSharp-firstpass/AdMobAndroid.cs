using System;
using UnityEngine;

public class AdMobAndroid
{
	private static AndroidJavaObject _admobPlugin;

	static AdMobAndroid()
	{
	}

	public static void init(string publisherId)
	{
	}

	public static void setTestDevices(string[] testDevices)
	{
	}

	public static void createBanner(AdMobAndroidAd type, AdMobAdPlacement placement)
	{
	}

	public static void destroyBanner()
	{
	}

	public static void hideBanner(bool shouldHide)
	{
	}

	public static void refreshAd()
	{
	}

	public static void requestInterstital(string interstitialUnitId)
	{
	}

	public static bool isInterstitalReady()
	{
		return false;
	}

	public static void displayInterstital()
	{
	}
}
