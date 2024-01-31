using System;
using System.Runtime.CompilerServices;
using Comfort.Common;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002B26 RID: 11046
	public class NotesTaskDescription : UIElement
	{
		// Token: 0x0600DB01 RID: 56065 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void Show(GClass1246 quest, ISession session)
		{
			throw null;
		}

		// Token: 0x0400DE58 RID: 56920
		[SerializeField]
		private CustomTextMeshProUGUI _title;

		// Token: 0x0400DE59 RID: 56921
		[SerializeField]
		private CustomTextMeshProUGUI _location;

		// Token: 0x0400DE5A RID: 56922
		[SerializeField]
		private CustomTextMeshProUGUI _scavIdentification;

		// Token: 0x0400DE5B RID: 56923
		[SerializeField]
		private CustomTextMeshProUGUI _description;

		// Token: 0x0400DE5C RID: 56924
		[SerializeField]
		private Image _titleBack;

		// Token: 0x0400DE5D RID: 56925
		[SerializeField]
		private CustomTextMeshProUGUI _status;

		// Token: 0x0400DE5E RID: 56926
		[SerializeField]
		private GameObject _loader;

		// Token: 0x0400DE5F RID: 56927
		[SerializeField]
		private Image _questImage;

		// Token: 0x0400DE60 RID: 56928
		[SerializeField]
		private Image _typeIcon;

		// Token: 0x0400DE61 RID: 56929
		[SerializeField]
		private CustomTextMeshProUGUI _type;

		// Token: 0x0400DE62 RID: 56930
		[SerializeField]
		private GameObject _lockedIcon;

		// Token: 0x0400DE63 RID: 56931
		[SerializeField]
		private GameObject _timeIcon;

		// Token: 0x0400DE64 RID: 56932
		[SerializeField]
		private CustomTextMeshProUGUI _timeLimitedText;

		// Token: 0x0400DE65 RID: 56933
		[SerializeField]
		private GameObject _dailyBackground;

		// Token: 0x0400DE66 RID: 56934
		[SerializeField]
		private ColorMap _titleBackColors;

		// Token: 0x0400DE67 RID: 56935
		[SerializeField]
		private ColorMap _textColors;

		// Token: 0x02002B27 RID: 11047
		[CompilerGenerated]
		private sealed class Class2597
		{
			// Token: 0x0600DB02 RID: 56066 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(Result<Texture2D> result)
			{
				throw null;
			}

			// Token: 0x0400DE68 RID: 56936
			public NotesTaskDescription notesTaskDescription_0;

			// Token: 0x0400DE69 RID: 56937
			public GClass1246 quest;
		}
	}
}
