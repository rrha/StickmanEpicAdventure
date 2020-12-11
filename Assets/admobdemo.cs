using UnityEngine;
using System.Collections;
using admob;
public class admobdemo : MonoBehaviour {
	 Admob ad;
	 string appID="";
	 string bannerID="";
	 string interstitialID="";
	 string videoID="";
	 string nativeBannerID = "";

	void Awake () {
		initAdmob();
	}

	void initAdmob()
	{
		#if UNITY_IOS
		appID=" ";
		bannerID= "";
		interstitialID="";
		videoID="";
		nativeBannerID = "";
		#elif UNITY_ANDROID
		appID="";
		bannerID= "";
		interstitialID="";
		videoID="";
		nativeBannerID = "";
		#endif

		ad = Admob.Instance();
		ad.bannerEventHandler += onBannerEvent;
		ad.interstitialEventHandler += onInterstitialEvent;
		ad.rewardedVideoEventHandler += onRewardedVideoEvent;
		ad.nativeBannerEventHandler += onNativeBannerEvent;
		ad.initSDK(appID);//optional
		ad.initAdmob(appID,interstitialID );//all id are admob test id,change those to your
		//ad.setTesting(true);//show test ad
		//ad.setNonPersonalized(true);//if want load NonPersonalized only,set true
		// ad.setIsDesignedForFamilies(true);//if is Is Designed For Families set true
		// ad.setGender(AdmobGender.MALE);
		//  string[] keywords = { "game","crash","male game"};
		//  ad.setKeywords(keywords);//set keywords for ad

	}
	/*void OnGUI(){
        if (GUI.Button(new Rect(120, 0, 100, 60), "showInterstitial"))
        {
           Debug.Log("touch inst button -------------");
            if (ad.isInterstitialReady())
            {
                ad.showInterstitial();
            }
            else
            {
                ad.loadInterstitial();
            }
        }
        if (GUI.Button(new Rect(240, 0, 100, 60), "showRewardVideo"))
        {
            Debug.Log("touch video button -------------");
            if (ad.isRewardedVideoReady())
            {
                ad.showRewardedVideo();
            }
            else
            {
            	ad.loadRewardedVideo(videoID);
            }
        }
        if (GUI.Button(new Rect(0, 100, 100, 60), "showbanner"))
        {
            Admob.Instance().showBannerRelative(AdSize.SmartBanner, AdPosition.BOTTOM_CENTER, 0);
        }
        if (GUI.Button(new Rect(120, 100, 100, 60), "showbannerABS"))
        {
            Admob.Instance().showBannerAbsolute(AdSize.Banner, 20, 300);
        }
        if (GUI.Button(new Rect(240, 100, 100, 60), "removebanner"))
        {
            Admob.Instance().removeBanner();
        }
        
        if (GUI.Button(new Rect(0, 200, 100, 60), "showNative"))
        {
            Admob.Instance().showNativeBannerRelative(new AdSize(320,100), AdPosition.BOTTOM_CENTER, 0,nativeBannerID);
        }
        if (GUI.Button(new Rect(120, 200, 100, 60), "showNativeABS"))
        {
            Admob.Instance().showNativeBannerAbsolute(new AdSize(-1,132), 20, 300, nativeBannerID);
        }
        if (GUI.Button(new Rect(240, 200, 100, 60), "removeNative"))
        {
            Admob.Instance().removeNativeBanner();
        }
	}*/
	public void ShowRewardedVideo (){
		if (ad.isRewardedVideoReady())
		{
			ad.showRewardedVideo();
		}
		else
		{
			ad.loadRewardedVideo(videoID);
		}

	}

	public void ShowInterstitial (){
		if (ad.isInterstitialReady())
		{
			ad.showInterstitial();
		}
		else
		{
			ad.loadInterstitial();
		}
	}

	void onInterstitialEvent(string eventName, string msg)
	{
		Debug.Log("handler onAdmobEvent---" + eventName + "   " + msg);
		if (eventName == AdmobEvent.onAdLoaded)
		{
			Admob.Instance().showInterstitial();
		}
	}
	void onBannerEvent(string eventName, string msg)
	{
		Debug.Log("handler onAdmobBannerEvent---" + eventName + "   " + msg);
	}
	void onRewardedVideoEvent(string eventName, string msg)
	{
		Debug.Log("handler onRewardedVideoEvent---" + eventName + "  rewarded: " + msg);
	}
	void onNativeBannerEvent(string eventName, string msg)
	{
		Debug.Log("handler onAdmobNativeBannerEvent---" + eventName + "   " + msg);
	}
}
