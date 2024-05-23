using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DatePlayer : MonoBehaviour
{
    public int VidaPlayer;
    public Slider BarraVida;

    private void Update()
    {
        BarraVida.GetComponent<Slider>().value = VidaPlayer;
        if(VidaPlayer <=0)
        {
            //Debug.Log("Game Over");
            Time.timeScale = 0f;
            GameOverManager.gameOverManager.CallGameOver();
        }
    }
}
