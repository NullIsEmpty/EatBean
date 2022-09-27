using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public  GameObject startCountDownPrefab;
    public GameObject startPanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OnStartButton()
    {
        StartCoroutine(PlayStartCountDown());
       // AudioSource.PlayClipAtPoint(startClip, new Vector3(0, 0, -5));
        startPanel.SetActive(false);
    }

    IEnumerator PlayStartCountDown()
    {
        GameObject go = Instantiate(startCountDownPrefab);
        go.transform.localPosition = new Vector3(24f, 10f, 0f);
        yield return new WaitForSeconds(4f);
        SceneManager.LoadScene(1);
        Destroy(go);
    }
    public void OnExitButton()
    {
        Application.Quit();
    }
}
