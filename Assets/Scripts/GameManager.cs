using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public TMP_Text display;
    public Button[] buttons;
    private int location;
    public bool hasStick;
    public bool hasTalked;

    // Start is called before the first frame update
    void Start()
    {
        GoToLocation(0); // Start Screen
    }

    private void GoToLocation(int newLocation)
    {
        location = newLocation;

        display.text = GameData.descriptions[location];
        int numOptions = GameData.options[location].Length;
        //Debug.Log("Number of Options " +  numOptions);
        for(int i = 0; i < numOptions; i++)
        {
            buttons[i].GetComponentInChildren<TMP_Text>().text = GameData.options[location][i];
        }
        for (int i = 0; i < buttons.Length; i++)
            {
            if(i < numOptions)
            {
                buttons[i].gameObject.SetActive(true);
            }
            else
            {
                buttons[i].gameObject.SetActive(false);
            }
        }
    }

    public void optionSelected(int optionSelected)
    {
        
        if(optionSelected == 0)
        {
            if(location == 0)
            {
                GoToLocation(1);
            }
            else if(location == 1)
            {
                GoToLocation(16);
            }
            else if (location == 2)
            {
                GoToLocation(17);
            }
            else if (location == 3)
            {
                GoToLocation(4);
            }
            else if (location == 4)
            {
                GoToLocation(5);
            }
            else if (location == 5)
            {
                GoToLocation(6);
            }
            else if (location == 6)
            {
                if (hasStick)
                {
                    GoToLocation(7);
                }
                else
                {
                    GoToLocation(8);
                }
            }
            else if (location == 7)
            {
                Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.name);

                Debug.Log("Retry");
            }
            else if (location == 8)
            {
                Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.name);

                Debug.Log("Retry");
            }
            else if (location == 9)
            {
                GoToLocation(18);
            }
            else if (location == 10)
            {
                Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.name);

                Debug.Log("Retry");
            }
            else if (location == 11)
            {
                if (hasTalked)
                {
                    GoToLocation(14);
                }
                else
                {
                    GoToLocation(13);
                }
            }
            else if (location == 12)
            {
                Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.name);

                Debug.Log("Retry");
            }
            else if (location == 13)
            {
                if (hasStick)
                {
                    GoToLocation(7);
                }
                else
                {
                    GoToLocation(8);
                }
            }
            else if (location == 14)
            {
                Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.name);

                Debug.Log("Retry");
            }
            else if (location == 15)
            {
                Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.name);

                Debug.Log("Retry");
            }
            else if (location == 16)
            {
                Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.name);

                Debug.Log("Retry");
            }
            else if (location == 17)
            {
                hasStick = true;
                GoToLocation(5);
            }
            else if (location == 18)
            {
                GoToLocation(6);
            }
            else if (location == 19)
            {
                GoToLocation(6);
                hasTalked = true;
            }
            else
            {
                GoToLocation(6);
            }

        }
        else if (optionSelected == 1)
        {
            if (location == 0)
            {
                GoToLocation(2);
            }
            else if (location == 1)
            {
                GoToLocation(2);
            }
            else if (location == 2)
            {
                GoToLocation(4);
            }
            else if (location == 3)
            {
                GoToLocation(5);
            }
            else if (location == 6)
            {
                GoToLocation(9);
            }
            else if (location == 7)
            {
                Application.Quit();
                Debug.Log("Quit");
            }
            else if (location == 8)
            {
                Application.Quit();
                Debug.Log("Quit");
            }
            else if (location == 9)
            {
                GoToLocation(19);
            }
            else if (location == 10)
            {
                Application.Quit();
                Debug.Log("Quit");
            }
            else if (location == 11)
            {
                GoToLocation(12);
            }
            else if (location == 12)
            {
                Application.Quit();
                Debug.Log("Quit");
            }
            else if (location == 13)
            {
                GoToLocation(9);
            }
            else if (location == 14)
            {
                Application.Quit();
                Debug.Log("Quit");
            }
            else if (location == 15)
            {
                Application.Quit();
                Debug.Log("Quit");
            }
            else
            {
                Application.Quit();
                Debug.Log("Quit");
            }
        }
        else if (optionSelected == 2)
        {
            if (location == 0)
            {
                GoToLocation(1);
            }
            else if (location == 2)
            {
                GoToLocation(3);
            }
            else if (location == 3)
            {
                GoToLocation(4);
            }
            else if (location == 6)
            {
                GoToLocation(10);
            }
            else if (location == 9)
            {
                GoToLocation(15);
            }
            else
            {
                GoToLocation(10);
            }
        }
        else
        {
            if (location == 2)
            {
                GoToLocation(4);
            }
            else if (location == 6)
            {
                GoToLocation(11);
            }
            else if (location == 9){
                GoToLocation(20);
            }
            else
            {
                GoToLocation(11);
            }
        }
        }
/*
        display.text = GameData.descriptions[1];
        buttons[0].GetComponentInChildren<TMP_Text>().text = GameData.options[1][0];
        buttons[1].GetComponentInChildren<TMP_Text>().text = GameData.options[1][1];
        buttons[2].GetComponentInChildren<TMP_Text>().text = GameData.options[1][2];
        buttons[3].GetComponentInChildren<TMP_Text>().text = GameData.options[1][3];
*/
}
