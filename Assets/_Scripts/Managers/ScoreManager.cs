using System;
using System.Collections;
using System.Collections.Generic;
using FallingBalls.Signals;
using TMPro;
using UnityEngine;

namespace FallingBalls.Managers
{
    public class ScoreManager : MonoBehaviour
    {
        [SerializeField] private float score;
        [SerializeField] private TextMeshProUGUI scoreText;

        private void OnEnable()
        {
            SubscribeEvent();
        }

        private void OnDisable()
        {
            UnSubscribeEvent();
        }

        private void SubscribeEvent()
        {
            UISignals.RefreshScoreText += RefreshText;
        }

        private void UnSubscribeEvent()
        {
            UISignals.RefreshScoreText -= RefreshText;
        }

        private void RefreshText(float addScore)
        {
            score += addScore;
            scoreText.text = "Score:" + score;

            if (addScore <= -1)
            {
                score -= score;
                scoreText.text = "Score:" + score;
            }
        }
    }
}
