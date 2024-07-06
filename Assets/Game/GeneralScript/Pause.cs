using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour
    {
        private bool isPauseGame;

        public void ButtonPausedGame()
        {
            if (isPauseGame)
            {
                Time.timeScale = 1;
            }
            else
            {
                Time.timeScale = 0;
            }

            isPauseGame = !isPauseGame;
        }
    }

