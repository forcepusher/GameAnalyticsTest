using GameAnalyticsSDK;
using System.Collections;
using UnityEngine;

public class ABPlaytest : MonoBehaviour
{
    private IEnumerator Start()
    {
        while (!GameAnalytics.IsRemoteConfigsReady())
        {
            Debug.Log("Waiting for Remote Config initialization.");
            yield return new WaitForSecondsRealtime(1f);
        }

        string textColor = GameAnalytics.GetRemoteConfigsValueAsString("text_color");
        Debug.Log($"text_color = {textColor}");

        Debug.Log($"CONFIG CONTENT = {GameAnalytics.GetRemoteConfigsContentAsString()}");
    }
}
