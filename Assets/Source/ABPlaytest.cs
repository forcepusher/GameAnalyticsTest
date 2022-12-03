using GameAnalyticsSDK;
using System.Collections;
using UnityEngine;

public class ABPlaytest : MonoBehaviour
{
    private IEnumerator Start()
    {
        yield return new WaitForSecondsRealtime(5f);

        while (!GameAnalytics.IsRemoteConfigsReady())
        {
            Debug.Log("Waiting for Remote Config initialization.");
            yield return new WaitForSecondsRealtime(1f);
        }

        string textColor = GameAnalytics.GetRemoteConfigsContentAsString();
        Debug.Log($"CONFIG CONTENT = {textColor}");
    }
}
