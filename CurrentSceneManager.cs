using UnityEngine;

public class CurrentSceneManager : MonoBehaviour
{
    public bool isPlayerPresentByDefault = false;
    public int coinsPickUpInThisSceneCount;
    public static CurrentSceneManager instance;

    private void Awake()
    {

        if (instance != null)
        {
            Debug.LogWarning("Il y a plus d'une instance de CurrentSceneManager dans la sc�ne!");
            CurrentSceneManager.instance.coinsPickUpInThisSceneCount++;
            return;
        }
        instance = this;
    }
}
