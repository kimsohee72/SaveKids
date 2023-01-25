using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class click : MonoBehaviour
{
    public void Scene()
    {
        SceneManager.LoadScene("main");
    }
    public void SceneChange()
    {
        SceneManager.LoadScene("main1");
    }
    public void SceneChange1()
    {
        SceneManager.LoadScene("Mini1");
    }
    public void SceneChange2()
    {
        SceneManager.LoadScene("Slice_game_mini2");
    }
    public void SceneChange3()
    {
        SceneManager.LoadScene("no.3");
    }
    public void SceneChange4()
    {
        SceneManager.LoadScene("minigame4");
    }
    public void SceneChange5()
    {
        SceneManager.LoadScene("Minigame_eunhyang5");
    }
    public void SceneChange6()
    {
        SceneManager.LoadScene("no.6");
    }
    public void SceneChange7()
    {
        SceneManager.LoadScene("Minigame_eunhyang7");
    }
}
