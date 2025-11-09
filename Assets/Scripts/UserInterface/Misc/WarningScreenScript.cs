using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WarningScreenScript : MonoBehaviour
{
    private void Start()
    {
        if (warnings.Length > 0)
        {
            warnings[0].SetActive(true);
        }
    }

    private void Update()
    {
        if (Input.anyKeyDown)
        {
            Advance();
        }
    }

    private void Advance()
    {
        warnings[current].SetActive(false);
        current++;
        if (current < warnings.Length)
        {
            warnings[current].SetActive(true);
        }
        else
        {
            SceneManager.LoadScene(BootUp);
        }
    }

	[Header("Scene Settings")]
    [SerializeField] private string BootUp;

    [Header("UI References")]
    [SerializeField] private GameObject[] warnings;

    private int current = 0;
}
