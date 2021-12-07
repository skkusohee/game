using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class play : MonoBehaviour
{
 
    // Update is called once per frame
    public void play_btn()
    {
        SceneManager.LoadScene("menu");
    }
    public void story_btn()
    {
        SceneManager.LoadScene("story");
    }
    public void story2()
    {
        SceneManager.LoadScene("story2");
    }
    public void story3()
    {
        SceneManager.LoadScene("story3");
    }
    public void back_start()
    {
        SceneManager.LoadScene("start");
    }
    public void stage()
    {
        SceneManager.LoadScene("play");
    }
    public void stage2()
    {
        SceneManager.LoadScene("play2");
    }
    public void stage3()
    {
        SceneManager.LoadScene("play3");
    }
}
