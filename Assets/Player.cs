using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class Player : MonoBehaviour
{
	public InventoryObject inventory;

	public void OnTriggerEnter(Collider other)
	{
		var item = other.GetComponent<Item>();
		if (item)
		{
			inventory.AddItem(item.item, 1);
			Destroy(other.gameObject);
		}
	}
	private void OnApplicationQuit()
	{
		inventory.Container.Clear();
	}
}
