using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryMenu : MonoBehaviour
{
    void Update()
    {
        Cursor.visible = true;
  
                //Appuyer sur n'importe quel touche pour unlock le curseur apres le changement de scene
                if (Input.anyKey)
                Cursor.lockState = CursorLockMode.None;
        }


    public void Retry()
    {
        SceneManager.LoadScene("PrototypeScene");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
