using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity; // manually imported from HoloToolkitCompatibilityPack
using UnityEngine.SceneManagement;

public class SingletonScene : Singleton<SingletonScene>
{
    public string switchScene = "";

    public GameObject demo;

    public bool youCanChangeScene = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (youCanChangeScene == true)
        {
            if (switchScene != "")
            {
                Scene s = SceneManager.GetActiveScene();
                if (s.name.Contains("demo"))
                {
                    //SceneManager.LoadScene("holoSocket");
                    demo.SetActive(false);
                }
                    
                else if (s.name.Contains("Socket"))
                {
                    //SceneManager.LoadScene("demoScene_free");
                    demo.SetActive(true);
                }
                    
                //switchScene = "";
                //youCanChangeScene = false;
            }
                
        }
    }

    //private void Awake() 
    //{
    //    if (Instance != null && Instance != this)
    //    {
    //        Destroy(gameObject);
    //        return;
    //    }

    //    Instance = this;
    //    DontDestroyOnLoad(gameObject);
    //}
}
