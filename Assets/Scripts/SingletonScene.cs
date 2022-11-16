using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity; // manually imported from HoloToolkitCompatibilityPack
using UnityEngine.SceneManagement;

public class SingletonScene : Singleton<SingletonScene>
{
    public GameObject demoscene;

    public GameObject castlescene;

    public GameObject holoscene;

    public GameObject mountainscene;

    public GameObject labscene;

    public bool holoSocket = true;

    public bool demo = false;

    public bool castle = false;

    public bool mountain = false;

    public bool lab = false;

    // Start is called before the first frame update
    void Start()
    {
        holoSocket = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (holoSocket == true)
        {
            holoscene.SetActive(true);
            demoscene.SetActive(false);
            castlescene.SetActive(false);
            mountainscene.SetActive(false);
            labscene.SetActive(false);
            return;
        }
        if (demoscene == true)
        {
            holoscene.SetActive(false);
            demoscene.SetActive(true);
            castlescene.SetActive(false);
            mountainscene.SetActive(false);
            labscene.SetActive(false);
            //return; WHY???
        }
        if (castle == true)
        {
            holoscene.SetActive(false);
            demoscene.SetActive(false);
            mountainscene.SetActive(false);
            castlescene.SetActive(true);
            labscene.SetActive(false);
            return;
        }

        if (mountain == true)
        {
            holoscene.SetActive(false);
            demoscene.SetActive(false);
            castlescene.SetActive(false);
            mountainscene.SetActive(true);
            labscene.SetActive(false);
            return;
        }
        if (lab == true)
        {
            holoscene.SetActive(false);
            demoscene.SetActive(false);
            castlescene.SetActive(false);
            mountainscene.SetActive(false);
            labscene.SetActive(true);
            return;
        }
    }

}
