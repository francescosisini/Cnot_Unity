using UnityEngine;

public class OpenExternalLink : MonoBehaviour
{
    [SerializeField] private string url = "https://www.youtube.com/watch?v=dQw4w9WgXcQ";

    public void OpenLink()
    {
        Application.OpenURL(url);
    }
}
