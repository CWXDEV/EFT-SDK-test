using System;
using System.Runtime.CompilerServices;
using EFT;
using UnityEngine;
using UnityEngine.Timeline;

namespace Cutscene
{
	// Token: 0x02000CA6 RID: 3238
	public class BaseCutsceneTrigger : MonoBehaviour
	{
		// Token: 0x140000DF RID: 223
		// (add) Token: 0x060045A7 RID: 17831 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060045A8 RID: 17832 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<BaseCutsceneTrigger, Player> OnPlayerCausesCutscene
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

		// Token: 0x140000E0 RID: 224
		// (add) Token: 0x060045A9 RID: 17833 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060045AA RID: 17834 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<Player> OnCutsceneEnded
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

		// Token: 0x17000B12 RID: 2834
		// (get) Token: 0x060045AB RID: 17835 RVA: 0x00002050 File Offset: 0x00000250
		public int CutsceneID
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000B13 RID: 2835
		// (get) Token: 0x060045AC RID: 17836 RVA: 0x00002050 File Offset: 0x00000250
		public Vector3 StartPosition
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000B14 RID: 2836
		// (get) Token: 0x060045AD RID: 17837 RVA: 0x00002050 File Offset: 0x00000250
		public Vector3 StartViewDirection
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000B15 RID: 2837
		// (get) Token: 0x060045AE RID: 17838 RVA: 0x00002050 File Offset: 0x00000250
		public float StartPlayerPosLevel
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000B16 RID: 2838
		// (get) Token: 0x060045AF RID: 17839 RVA: 0x00002050 File Offset: 0x00000250
		public bool NeedToProneAtStart
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000B17 RID: 2839
		// (get) Token: 0x060045B0 RID: 17840 RVA: 0x00002050 File Offset: 0x00000250
		public Vector3 CutsceneEndPlayerPosition
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000B18 RID: 2840
		// (get) Token: 0x060045B1 RID: 17841 RVA: 0x00002050 File Offset: 0x00000250
		public TimelineAsset TimeLineAsset
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060045B2 RID: 17842 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void Awake()
		{
			throw null;
		}

		// Token: 0x060045B3 RID: 17843 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void CallStartCutscene(IPlayer player)
		{
			throw null;
		}

		// Token: 0x060045B4 RID: 17844 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CallEndCutscene()
		{
			throw null;
		}

		// Token: 0x04005067 RID: 20583
		[CompilerGenerated]
		private Action<BaseCutsceneTrigger, Player> action_0;

		// Token: 0x04005068 RID: 20584
		[CompilerGenerated]
		private Action<Player> action_1;

		// Token: 0x04005069 RID: 20585
		private int _cutsceneID;

		// Token: 0x0400506A RID: 20586
		private Vector3 _startPosition;

		// Token: 0x0400506B RID: 20587
		private Vector3 _startViewDirection;

		// Token: 0x0400506C RID: 20588
		private float _startPlayerPosLevel;

		// Token: 0x0400506D RID: 20589
		private bool _needToProneAtStart;

		// Token: 0x0400506E RID: 20590
		private Vector3 _cutsceneEndPlayerPosition;

		// Token: 0x0400506F RID: 20591
		public CutsceneFakePlayerSteps fakePlayerSteps;

		// Token: 0x04005070 RID: 20592
		[SerializeField]
		private TimelineAsset _timelineAsset;

		// Token: 0x04005071 RID: 20593
		[SerializeField]
		private bool _callServerTeleportOnEnd;

		// Token: 0x04005072 RID: 20594
		private Player player_0;
	}
}
