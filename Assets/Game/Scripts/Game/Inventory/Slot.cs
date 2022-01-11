using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{ 
	public Image icon;          // Reference to the Icon image
	public Button DropButton; // Reference to the remove button

	Item item;

	public void AddItem(Item newItem)
	{
		item = newItem;

		icon.sprite = item.icon;
		icon.enabled = true;
		DropButton.interactable = true;
	}

	// Clear the slot
	public void ClearSlot()
	{
		item = null;

		icon.sprite = null;
		icon.enabled = false;
		DropButton.interactable = false;
	}

	// Called when the remove button is pressed
	public void OnRemoveButton()
	{
		Inventory.instance.Remove(item);
	}

	// Called when the item is pressed
	public void UseItem()
	{
		if (item != null)
		{
			item.Use();
		}
	}
}