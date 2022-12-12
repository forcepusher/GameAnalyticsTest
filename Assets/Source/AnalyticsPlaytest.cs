using UnityEngine;
using GameAnalyticsSDK;
using System.Collections;

public class AnalyticsPlaytest : MonoBehaviour
{
    private IEnumerator Start()
    {
        GameAnalytics.NewProgressionEvent(GAProgressionStatus.Start, "level1");
        yield return new WaitForSecondsRealtime(1f);
        GameAnalytics.NewProgressionEvent(GAProgressionStatus.Fail, "level1");

        //GameAnalytics.NewResourceEvent(GAResourceFlowType.Source, "gold", 123, "loot", "chest");
        //GameAnalytics.NewResourceEvent(GAResourceFlowType.Sink, "gold", 42, "shop", "shotgun");

        GameAnalytics.NewAdEvent(GAAdAction.Clicked, GAAdType.Video, "yandex", "");
        //GameAnalytics.NewAdEvent(GAAdAction.Show, GAAdType.Video, "yandex", "");
        //GameAnalytics.NewAdEvent(GAAdAction.FailedShow, GAAdType.Video, "yandex", "");
        //GameAnalytics.NewAdEvent(GAAdAction.RewardReceived, GAAdType.Video, "yandex", "");

        //GameAnalytics.NewAdEvent(GAAdAction.Show, GAAdType.Interstitial, "yandex", "");
        //GameAnalytics.NewAdEvent(GAAdAction.FailedShow, GAAdType.Interstitial, "yandex", "");

        //GameAnalytics.NewDesignEvent("reviveAdOffer");
        //GameAnalytics.NewDesignEvent("reviveAdClick");
    }
}
