using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.UI
{
	// Token: 0x02002A6D RID: 10861
	public class LocationButton : UIElement
	{
		// Token: 0x0600D7BA RID: 55226 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(LocationSettingsClass.Location location, ESideType chosenSideType, bool onAtStart, int playerLevel, bool isOverloaded, bool isNew, Action<LocationSettingsClass.Location> onSelected)
		{
			throw null;
		}

		// Token: 0x0600D7BB RID: 55227 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Select(bool value)
		{
			throw null;
		}

		// Token: 0x0400DA69 RID: 55913
		[SerializeField]
		private GameObject _infoPanel;

		// Token: 0x0400DA6A RID: 55914
		[SerializeField]
		private CustomTextMeshProUGUI _infoText;

		// Token: 0x0400DA6B RID: 55915
		[SerializeField]
		private RectTransform _secretBorder;

		// Token: 0x0400DA6C RID: 55916
		[SerializeField]
		private GameObject _lockedIcon;

		// Token: 0x0400DA6D RID: 55917
		[SerializeField]
		private GameObject _overloadedIcon;

		// Token: 0x0400DA6E RID: 55918
		[SerializeField]
		private GameObject _availableIcon;

		// Token: 0x0400DA6F RID: 55919
		[SerializeField]
		private GameObject _newIcon;

		// Token: 0x0400DA70 RID: 55920
		[SerializeField]
		private UISpawnableToggle _spawnableToggle;

		// Token: 0x0400DA71 RID: 55921
		private Action<LocationSettingsClass.Location> action_0;

		// Token: 0x02002A6E RID: 10862
		[CompilerGenerated]
		private sealed class Class2524
		{
			// Token: 0x0600D7BC RID: 55228 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(bool isOn)
			{
				throw null;
			}

			// Token: 0x0400DA72 RID: 55922
			public LocationButton locationButton_0;

			// Token: 0x0400DA73 RID: 55923
			public LocationSettingsClass.Location location;
		}
	}
}
