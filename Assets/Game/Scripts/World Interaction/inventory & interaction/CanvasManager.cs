using UnityEngine;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour
{
    [SerializeField] private GameObject _interactionPanel;
    [SerializeField] private Text       _interactionText;
    [SerializeField] private Image[]    _inventoryIcons;

    void Start()
    {
        HideInteractionPanel();
    }

    public void HideInteractionPanel()
    {
        _interactionPanel.SetActive(false);
    }

    public void ShowInteractionPanel(string message)
    {
        _interactionText.text = message;
        _interactionPanel.SetActive(true);
    }

    public void SetInventoryIcon(int i, Sprite icon)
    {
        _inventoryIcons[i].sprite   = icon;
        _inventoryIcons[i].color    = Color.white;
    }

    public void ClearInventoryIcons()
    {
        // if(numbers!= null)
        for (int i = 0; i < _inventoryIcons.Length; ++i)
        {
            _inventoryIcons[i].sprite   = null;
            _inventoryIcons[i].color    = Color.clear;
        }
    }
    
}
