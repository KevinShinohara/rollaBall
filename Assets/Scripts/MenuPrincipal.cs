using UnityEngine;
using UnityEngine.SceneManagement; // Para carregar a cena do jogo

public class MenuPrincipal : MonoBehaviour
{
    // Função chamada ao clicar no botão "Iniciar Jogo"
    public void IniciarJogo()
    {
        // Carrega a cena do jogo, substitua "NomeDaCenaDoJogo" pelo nome correto da sua cena de jogo
        SceneManager.LoadScene("menu_img");
    }
}