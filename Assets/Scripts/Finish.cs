using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using GoogleMobileAds.Api;

public class Finish : MonoBehaviour
{

    private InterstitialAd interstitial;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
          //  SceneManager.LoadScene("Finish");
            string adUnitId = "ca-app-pub-6669663630759332/2850233894";
            // Initialize an InterstitialAd.
            this.interstitial = new InterstitialAd(adUnitId);
            AdRequest request = new AdRequest.Builder().Build();
            // Load the interstitial with the request.
            this.interstitial.LoadAd(request);
        
            if (this.interstitial.IsLoaded())
            {
                this.interstitial.Show();
            }


        }
    }

}
