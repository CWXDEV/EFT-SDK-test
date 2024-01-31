using System;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002A6F RID: 10863
	public sealed class LocationInfoPanel : UIElement
	{
		// Token: 0x0600D7BD RID: 55229 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Set([CanBeNull] LocationSettingsClass.Location location, ESideType chosenSideType, int selfLevel, int minPlayerLevel, int maxPlayerLevel)
		{
			throw null;
		}

		// Token: 0x0600D7BE RID: 55230 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private string method_0(LocationSettingsClass.Location location, bool unavailableByLevel, ESideType side)
		{
			throw null;
		}

		// Token: 0x0600D7BF RID: 55231 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Sprite method_1(LocationSettingsClass.Location location)
		{
			throw null;
		}

		// Token: 0x0400DA74 RID: 55924
		[SerializeField]
		private CustomTextMeshProUGUI _name;

		// Token: 0x0400DA75 RID: 55925
		[SerializeField]
		private GameObject _lockedPanel;

		// Token: 0x0400DA76 RID: 55926
		[SerializeField]
		private CustomTextMeshProUGUI _availableOnLevelLabel;

		// Token: 0x0400DA77 RID: 55927
		[SerializeField]
		private GameObject _watchIntro;

		// Token: 0x0400DA78 RID: 55928
		[SerializeField]
		private Sprite _defaultImage;

		// Token: 0x0400DA79 RID: 55929
		[SerializeField]
		private Image _banner;

		// Token: 0x0400DA7A RID: 55930
		[SerializeField]
		private CustomTextMeshProUGUI _description;

		// Token: 0x0400DA7B RID: 55931
		[SerializeField]
		private CustomTextMeshProUGUI _area;

		// Token: 0x0400DA7C RID: 55932
		[SerializeField]
		private CustomTextMeshProUGUI _playTime;

		// Token: 0x0400DA7D RID: 55933
		[SerializeField]
		private CustomTextMeshProUGUI _difficulty;

		// Token: 0x0400DA7E RID: 55934
		[SerializeField]
		private CustomTextMeshProUGUI _players;

		// Token: 0x0400DA7F RID: 55935
		[SerializeField]
		private LocationWarningPanel _warningPanel;

		// Token: 0x0400DA80 RID: 55936
		[SerializeField]
		private LocationWarningPanel _levelWarningPanel;

		// Token: 0x0400DA81 RID: 55937
		[SerializeField]
		private GameObject _bottomPanel;
	}
}
