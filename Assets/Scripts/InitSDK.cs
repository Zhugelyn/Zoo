using Agava.YandexGames;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InitSDK : MonoBehaviour
{
    private IEnumerator Start()
    {
#if !UNITY_WEBGL || UNITY_EDITOR
        yield break;
#endif
        YandexGamesSdk.CallbackLogging = true;
        Debug.Log("начало загрузки sdk");
        yield return YandexGamesSdk.WaitForInitialization();
        Debug.Log("окончание загрузки sdk");
        SceneManager.LoadScene(1);
        Debug.Log("окончание загрузки уровня");
    }
}
