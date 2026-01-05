using System.Collections;
using TMPro;
using UnityEngine;

public class FinishTrigger : MonoBehaviour
{
    [SerializeField] private TMP_Text finishText;
    [SerializeField] private float hideAfterSeconds = 0f;

    private void Awake()
    {
        if (finishText != null)
            finishText.gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;

        if (finishText != null)
        {
            finishText.gameObject.SetActive(true);

            if (hideAfterSeconds > 0f)
                StartCoroutine(HideLater());
        }
    }

    private IEnumerator HideLater()
    {
        yield return new WaitForSeconds(hideAfterSeconds);
        finishText.gameObject.SetActive(false);
    }
}
