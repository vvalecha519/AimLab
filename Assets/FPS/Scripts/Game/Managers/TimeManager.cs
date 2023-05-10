using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Unity.FPS.Game
{
    public class TimeManager : MonoBehaviour
    {
        bool m_ObjectivesCompleted = false;
        public float timeValue = 60;

        void Awake()
        {
        }


        void Update()
        {
            if(timeValue > 0)
            {
                timeValue -= Time.deltaTime;
            }

            else if ( timeValue <= 0 && m_ObjectivesCompleted == false)
            {
                m_ObjectivesCompleted = true;
                EventManager.Broadcast(Events.AllObjectivesCompletedEvent);
            }
        }

        void OnDestroy()
        {
           
        }
    }
}
