using GameAnalyticsSDK;
using UnityEngine;

public class AnalyticsAutoInitialization
{
    [RuntimeInitializeOnLoadMethod]
    private static void Initialize()
    {
        GameAnalytics.Initialize();
    }
}
