using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayScore : MonoBehaviour
{
    [SerializeField] private TMPro.TextMeshProUGUI bullets;
    [SerializeField] private TMPro.TextMeshProUGUI target;

    // Start is called before the first frame update
    void Start()
    {
        bullets.text = Globals.bulletsFired.ToString();
        target.text = Globals.targetsDestroyed.ToString();
    }
}
