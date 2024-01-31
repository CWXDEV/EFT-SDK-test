using System;
using System.Collections;
using System.Runtime.CompilerServices;
using EFT.Interactive;
using EFT.UI;
using UnityEngine;

namespace EFT
{
	// Token: 0x020012C9 RID: 4809
	public abstract class AbstractGame : MonoBehaviour, IDisposable, GInterface100
	{
		// Token: 0x060063B5 RID: 25525 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected static TGame Create<TGame>(EUpdateQueue updateQueue, TimeSpan? sessionTime = null, string goName = "GAME") where TGame : AbstractGame
		{
			throw null;
		}

		// Token: 0x060063B6 RID: 25526 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Dispose()
		{
			throw null;
		}

		// Token: 0x060063B7 RID: 25527 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator method_0()
		{
			throw null;
		}

		// Token: 0x060063B8 RID: 25528 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void FixedUpdate()
		{
			throw null;
		}

		// Token: 0x060063B9 RID: 25529 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void LateFixedUpdate()
		{
			throw null;
		}

		// Token: 0x060063BA RID: 25530 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void LateUpdate()
		{
			throw null;
		}

		// Token: 0x1700100C RID: 4108
		// (get) Token: 0x060063BB RID: 25531 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060063BC RID: 25532 RVA: 0x00002050 File Offset: 0x00000250
		public GameStatus Status
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected set
			{
				throw null;
			}
		}

		// Token: 0x1700100D RID: 4109
		// (get) Token: 0x060063BD RID: 25533 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060063BE RID: 25534 RVA: 0x00002050 File Offset: 0x00000250
		public GameTimerClass GameTimer
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x1700100E RID: 4110
		// (get) Token: 0x060063BF RID: 25535 RVA: 0x00002050 File Offset: 0x00000250
		public float PastTime
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700100F RID: 4111
		// (get) Token: 0x060063C0 RID: 25536 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060063C1 RID: 25537 RVA: 0x00002050 File Offset: 0x00000250
		public EUpdateQueue UpdateQueue
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x17001010 RID: 4112
		// (get) Token: 0x060063C2 RID: 25538 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060063C3 RID: 25539 RVA: 0x00002050 File Offset: 0x00000250
		public float FixedDeltaTime
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17001011 RID: 4113
		// (get) Token: 0x060063C4 RID: 25540 RVA: 0x00002050 File Offset: 0x00000250
		public virtual float LastServerTimeStamp
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001012 RID: 4114
		// (get) Token: 0x060063C5 RID: 25541 RVA: 0x00002050 File Offset: 0x00000250
		public virtual int LastServerFrameId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001013 RID: 4115
		// (get) Token: 0x060063C6 RID: 25542
		public abstract string LocationObjectId { get; }

		// Token: 0x17001014 RID: 4116
		// (get) Token: 0x060063C7 RID: 25543 RVA: 0x00002050 File Offset: 0x00000250
		public bool InRaid
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001015 RID: 4117
		// (get) Token: 0x060063C8 RID: 25544
		protected abstract GameUI GameUi { get; }

		// Token: 0x17001016 RID: 4118
		// (get) Token: 0x060063C9 RID: 25545
		protected abstract string ProfileId { get; }

		// Token: 0x060063CA RID: 25546 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void UpdateExfiltrationUi(ExfiltrationPoint point, bool contains, bool initial = false)
		{
			throw null;
		}

		// Token: 0x060063CB RID: 25547 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void OnEpInteraction(ExfiltrationPoint point, bool entered)
		{
			throw null;
		}

		// Token: 0x060063CC RID: 25548 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void SetMatchmakerStatus(string status, float? progress = null)
		{
			throw null;
		}

		// Token: 0x17001017 RID: 4119
		// (get) Token: 0x060063CD RID: 25549 RVA: 0x00002050 File Offset: 0x00000250
		GameObject GInterface100.gameObject
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060063CE RID: 25550 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_1(Player x)
		{
			throw null;
		}

		// Token: 0x060063CF RID: 25551 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_2(Player x)
		{
			throw null;
		}

		// Token: 0x04007032 RID: 28722
		protected const string HALLOWEEN_PREFAB_PATH = "Prefabs/HALLOWEEN_CONTROLLER";

		// Token: 0x04007033 RID: 28723
		private bool bool_0;

		// Token: 0x04007034 RID: 28724
		private readonly WaitForFixedUpdate waitForFixedUpdate_0;

		// Token: 0x04007035 RID: 28725
		protected readonly GClass763 CompositeDisposable;

		// Token: 0x04007036 RID: 28726
		[CompilerGenerated]
		private GameStatus gameStatus_0;

		// Token: 0x04007037 RID: 28727
		[CompilerGenerated]
		private GameTimerClass gclass1472_0;

		// Token: 0x04007038 RID: 28728
		private float float_0;

		// Token: 0x04007039 RID: 28729
		private bool bool_1;

		// Token: 0x0400703A RID: 28730
		[CompilerGenerated]
		private EUpdateQueue eupdateQueue_0;

		// Token: 0x0400703B RID: 28731
		public const float MAX_FIXED_DELTA_TIME = 0.05f;
	}
}
