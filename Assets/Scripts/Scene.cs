using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Scene : MonoBehaviour
{
    Main main;
    public void OnePlayer()
    {
        SceneManager.LoadScene("Main");
        main.Deger(1);        
    }

    public void TwoPlayer()
    {
        SceneManager.LoadScene("Main");
        main.Deger(2);
    }

    public void Network()
    {
        SceneManager.LoadScene("Main");
        main.Deger(3);
    }


}
