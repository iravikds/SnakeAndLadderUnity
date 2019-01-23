using UnityEngine;
using System.Collections;
using GoogleMobileAds.Api;

public class AdmobScript : MonoBehaviour
{
	public static AdmobScript instance = null;
	InterstitialAd interstitial;
	public string BannerId;
	public string InterstitialId;

	// Use this for initialization
	void Start ()
	{
		if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy (gameObject);
		
		//Request Ads
		RequestBanner ();
		RequestInterstitial ();
	}

	public void showInterstitialAd ()
	{
		//Show Ad
		if (interstitial.IsLoaded ()) {
			interstitial.Show ();
		}else{
			RequestInterstitial();
		}

	}

	private void RequestBanner ()
	{
		#if UNITY_EDITOR
		string adUnitId = "unused";
		#elif UNITY_ANDROID
		string adUnitId = BannerId;
		#elif UNITY_IPHONE
			string adUnitId = "INSERT_IOS_BANNER_AD_UNIT_ID_HERE";
		#else
			string adUnitId = "unexpected_platform";
		#endif

		// Create a 320x50 banner at the bottom of the screen.
		BannerView bannerView = new BannerView (adUnitId, AdSize.Banner, AdPosition.Bottom);
		// Create an empty ad request.
		AdRequest request = new AdRequest.Builder ().Build ();
		// Load the banner with the request.
		bannerView.LoadAd (request);

	}

	private void RequestInterstitial ()
	{
		#if UNITY_ANDROID
		string adUnitId = InterstitialId;
		#elif UNITY_IPHONE
			string adUnitId = "INSERT_IOS_INTERSTITIAL_AD_UNIT_ID_HERE";
		#else
			string adUnitId = "unexpected_platform";
		#endif

		// Initialize an InterstitialAd.
		interstitial = new InterstitialAd (adUnitId);
		// Create an empty ad request.
		AdRequest request = new AdRequest.Builder ().Build ();
		// Load the interstitial with the request.
		interstitial.LoadAd (request);
	}

}