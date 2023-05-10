using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeDifficulty : MonoBehaviour
{
     [SerializeField] private TMPro.TextMeshProUGUI difficulty;
     [SerializeField] private Button easy;
     [SerializeField] private Button medium;
     [SerializeField] private Button hard;

     // Start is called before the first frame update
     void Start()
     {        
        Globals.level = PlayerPrefs.GetInt("currlevel");
        changeText(Globals.level);

         easy.onClick.AddListener(delegate { buttonClick(1); });
         medium.onClick.AddListener(delegate { buttonClick(2); });
         hard.onClick.AddListener(delegate { buttonClick(3); });
     }


     private void buttonClick(int level)
     {
        if (PlayerPrefs.GetInt("currlevel") != level){
            GameObject[] allObjects = GameObject.FindGameObjectsWithTag("target");
            foreach(GameObject obj in allObjects) {
                Destroy(obj);
            }
        }
            
        PlayerPrefs.SetInt("currlevel", level);
        PlayerPrefs.Save();
        Globals.level = PlayerPrefs.GetInt("currlevel");

        changeText(level);
         
     }

    private void changeText(int level)
    {
        switch (level)
        {
            case 1:
                difficulty.text = "Easy";
                difficulty.color = new Color(0, 255, 0);
                break;
            case 2:
                difficulty.text = "Medium";
                difficulty.color = new Color(255, 255, 0);
                break;
            case 3:
                difficulty.text = "Hard";
                difficulty.color = new Color(255, 0, 0);
                break;
        }
    }
 }
