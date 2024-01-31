using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI.Matchmaker
{
	// Token: 0x02002D7D RID: 11645
	public sealed class BannerPageToggle : Toggle, IDisposable
	{
		// Token: 0x1400032F RID: 815
		// (add) Token: 0x0600E4F9 RID: 58617 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600E4FA RID: 58618 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<bool> OnSelected
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x0600E4FB RID: 58619 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(ToggleGroup toggleGroup, MatchmakerBanner banner)
		{
			throw null;
		}

		// Token: 0x0600E4FC RID: 58620 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(bool value)
		{
			throw null;
		}

		// Token: 0x0600E4FD RID: 58621 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSprite(bool active)
		{
			throw null;
		}

		// Token: 0x0600E4FE RID: 58622 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Dispose()
		{
			throw null;
		}

		// Token: 0x0400EA32 RID: 59954
		[CompilerGenerated]
		private Action<bool> action_0;

		// Token: 0x0400EA33 RID: 59955
		[SerializeField]
		private Image _image;

		// Token: 0x0400EA34 RID: 59956
		[SerializeField]
		private Sprite _onSprite;

		// Token: 0x0400EA35 RID: 59957
		[SerializeField]
		private Sprite _offSprite;
	}
}
