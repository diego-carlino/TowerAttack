using UnityEngine;
using UnityEngine.SceneManagement; // Obligatoire pour changer de scène

public class MainMenu : MonoBehaviour
{
    public void Jouer()
    {
        // Charge la scène suivante dans la liste (Build Settings)
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Quitter()
    {
        Debug.Log("Le jeu se ferme..."); // S'affiche uniquement dans la console Unity
        Application.Quit(); // Ferme l'application
    }
}