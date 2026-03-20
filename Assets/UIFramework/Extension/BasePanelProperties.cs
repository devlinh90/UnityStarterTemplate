using UnityEngine;
using deVoid.UIFramework;


[System.Serializable]	
public abstract class BasePanelProperties : IPanelProperties
{
	[SerializeField] PanelPriority priority = PanelPriority.None;
	public PanelPriority Priority { get => priority; set => priority = value; }

}
