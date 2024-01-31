using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002AA1 RID: 10913
	public sealed class AchievementNotificationView : BaseNotificationView, GInterface364<GClass2032>
	{
		// Token: 0x17002656 RID: 9814
		// (get) Token: 0x0600D8F8 RID: 55544 RVA: 0x00002050 File Offset: 0x00000250
		public override bool ReturnToPool
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600D8F9 RID: 55545 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(GClass2032 notification)
		{
			throw null;
		}

		// Token: 0x0400DBBD RID: 56253
		[SerializeField]
		[Space]
		private CustomTextMeshProUGUI _title;

		// Token: 0x0400DBBE RID: 56254
		[SerializeField]
		[Space]
		private Image _achievementIcon;

		// Token: 0x0400DBBF RID: 56255
		[SerializeField]
		private Image _iconBorder;

		// Token: 0x0400DBC0 RID: 56256
		[SerializeField]
		private Image _iconBackground;

		// Token: 0x0400DBC1 RID: 56257
		[SerializeField]
		private Image _backgroundGlow;

		// Token: 0x0400DBC2 RID: 56258
		[Space]
		[SerializeField]
		private Sprite _commonIconBorder;

		// Token: 0x0400DBC3 RID: 56259
		[SerializeField]
		private Sprite _rareIconBorder;

		// Token: 0x0400DBC4 RID: 56260
		[SerializeField]
		private Sprite _legendaryIconBorder;

		// Token: 0x0400DBC5 RID: 56261
		[Space]
		[SerializeField]
		private Sprite _commonIconBackground;

		// Token: 0x0400DBC6 RID: 56262
		[SerializeField]
		private Sprite _rareIconBackground;

		// Token: 0x0400DBC7 RID: 56263
		[SerializeField]
		private Sprite _legendaryIconBackground;

		// Token: 0x0400DBC8 RID: 56264
		[Space]
		[SerializeField]
		private Sprite _commonBackgroundGlow;

		// Token: 0x0400DBC9 RID: 56265
		[SerializeField]
		private Sprite _rareBackgroundGlow;

		// Token: 0x0400DBCA RID: 56266
		[SerializeField]
		private Sprite _legendaryBackgroundGlow;
	}
}
