using UnityEngine;
using TMPro;
using Unity.FPS.Game;

namespace Unity.FPS.UI
{
    public class FramerateCounter : MonoBehaviour
    {
        [Tooltip("Delay between updates of the displayed framerate value")]
        public float PollingTime = 0.5f;

        [Tooltip("The text field displaying the framerate")]
        public TextMeshProUGUI UIText;

        float m_AccumulatedDeltaTime = 0f;

        void Update()
        {
            m_AccumulatedDeltaTime += Time.deltaTime;

            if (m_AccumulatedDeltaTime >= PollingTime)
            {
                int framerate = Mathf.RoundToInt((float) 1 / m_AccumulatedDeltaTime);
                GameObject gameManager = GameObject.Find("GameManager");
                TimeManager timerManager = gameManager.GetComponent<TimeManager>();
                int timeRemaining = (int)timerManager.timeValue;

                // int timer = 0;
                UIText.text = timeRemaining.ToString();
                if(timeRemaining < 4)
                {
                    UIText.color = Color.red;
                    UIText.fontSize = 30;

                    // make text bold
                    UIText.fontStyle = TMPro.FontStyles.Bold;
                }

                m_AccumulatedDeltaTime = 0f;
            }
        }
    }
}