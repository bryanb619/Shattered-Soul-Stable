using UnityEngine;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour
{
    [SerializeField] private GameObject _interactionPanel;
    [SerializeField] private Text _interactionText;
    [SerializeField] private Image[] _inventoryIcons;

    public static bool Inventory_Active = false;
    public GameObject Inventory_Canvas;

    void Start()
    {
        HideInteractionPanel();
    }
    private void Update()
    {

        LookForTAB_KeyCode();

    


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
        _inventoryIcons[i].sprite = icon;
        _inventoryIcons[i].color = Color.white;
    }

    public void ClearInventoryIcons()
    {
        // if(numbers!= null)
        for (int i = 0; i < _inventoryIcons.Length; ++i)
        {
            _inventoryIcons[i].sprite = null;
            _inventoryIcons[i].color = Color.clear;
        }
    }
    private void LookForTAB_KeyCode()
    {

        if (Input.GetKeyDown(KeyCode.Tab))
        {

            if (Inventory_Active)
            {
                Hide_Inventory();
            }
            else
            {
                Show_Inventory();
            }
        }
    }



    public void Hide_Inventory()
    {

        Inventory_Canvas.SetActive(false);
        Inventory_Active = false;
        //Cursor.lockState = CursorLockMode.Locked;

    }

    public void Show_Inventory()
    {

        Inventory_Canvas.SetActive(true);
        Inventory_Active = true;
        //Cursor.lockState = CursorLockMode.None;

    }



}
