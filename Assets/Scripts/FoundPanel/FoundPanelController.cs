using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FoundPanelController : MonoBehaviour
{

    [SerializeField]
    private float cooldownTimer;

    [SerializeField]
    private Image image;
    [SerializeField]
    private TextMeshProUGUI itemNameText;
    [SerializeField]
    private TextMeshProUGUI itemDescriptionText;

    void Update()
    {
        cooldownTimer -= Time.deltaTime;

        if(cooldownTimer <= 0 && Input.GetKeyDown(KeyCode.Space)){
            transform.gameObject.SetActive(false);
        }
    }

    public void Activate(EasterEggData data)
    {
        cooldownTimer = 0.25f;
        image.sprite = data.sprite;
        itemNameText.text = data.itemName;
        itemDescriptionText.text = data.description;
        transform.gameObject.SetActive(true);
    }
}
