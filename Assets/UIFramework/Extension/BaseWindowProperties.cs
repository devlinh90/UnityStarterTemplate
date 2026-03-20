using UnityEngine;
using deVoid.UIFramework;

[System.Serializable]
public abstract class BaseWindowProperties : IWindowProperties
{
	[SerializeField] WindowPriority windowQueuePriority = WindowPriority.Enqueue;
	[SerializeField] bool hideOnForegroundLost = false;
	[SerializeField] bool isPopup = true;
	[SerializeField] bool suppressPrefabProperties = false;
	public WindowPriority WindowQueuePriority { get => windowQueuePriority; set => windowQueuePriority = value; }
	public bool HideOnForegroundLost { get => hideOnForegroundLost; set => hideOnForegroundLost = value; }
	public bool IsPopup { get => isPopup; set => isPopup = value; }
	public bool SuppressPrefabProperties { get => suppressPrefabProperties; set => suppressPrefabProperties = value; }
}