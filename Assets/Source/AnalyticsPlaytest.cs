using UnityEngine;
using GameAnalyticsSDK;
using System.Collections;

public class AnalyticsPlaytest : MonoBehaviour
{
    private IEnumerator Start()
    {
        GameAnalytics.NewProgressionEvent(GAProgressionStatus.Start, "level1");
        yield return new WaitForSecondsRealtime(1f);
        GameAnalytics.NewProgressionEvent(GAProgressionStatus.Complete, "level1");
    }
}
