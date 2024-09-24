using UnityEngine;
using TMPro; 

public class Cronometro : MonoBehaviour
{
    public TextMeshProUGUI cronometroText;
    private float tempoDecorrido = 0f;
    private bool cronometroAtivo = true;

    void Update()
    {

        if (cronometroAtivo)
        {
            tempoDecorrido += Time.deltaTime;

            int minutos = Mathf.FloorToInt(tempoDecorrido / 60F);
            int segundos = Mathf.FloorToInt(tempoDecorrido % 60F);
            cronometroText.text = string.Format("{0:00}:{1:00}", minutos, segundos);
        }


    }

    public void PararCronometro()
    {
        cronometroAtivo = false;
    }
}
