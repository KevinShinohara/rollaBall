using UnityEngine;
using UnityEngine.SceneManagement; // Para carregar a cena do jogo

public class MenuPrincipal : MonoBehaviour
{
    // Fun��o chamada ao clicar no bot�o "Iniciar Jogo"
    public void IniciarJogo()
    {
        // Carrega a cena do jogo, substitua "NomeDaCenaDoJogo" pelo nome correto da sua cena de jogo
        SceneManager.LoadScene("menu_img");
    }
}