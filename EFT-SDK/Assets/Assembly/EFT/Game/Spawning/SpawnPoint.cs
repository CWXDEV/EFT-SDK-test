using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.Game.Spawning
{
	// Token: 0x0200269B RID: 9883
	[Serializable]
	public class SpawnPoint : IPositionPoint, ISpawnPoint
	{
		// Token: 0x170022EF RID: 8943
		// (get) Token: 0x0600C3E4 RID: 50148 RVA: 0x00002050 File Offset: 0x00000250
		public string BotZoneName
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170022F0 RID: 8944
		// (get) Token: 0x0600C3E5 RID: 50149 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600C3E6 RID: 50150 RVA: 0x00002050 File Offset: 0x00000250
		public ISpawnPointCollider Collider
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170022F1 RID: 8945
		// (get) Token: 0x0600C3E7 RID: 50151 RVA: 0x00002050 File Offset: 0x00000250
		string ISpawnPoint.Id
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170022F2 RID: 8946
		// (get) Token: 0x0600C3E8 RID: 50152 RVA: 0x00002050 File Offset: 0x00000250
		string ISpawnPoint.Name
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170022F3 RID: 8947
		// (get) Token: 0x0600C3E9 RID: 50153 RVA: 0x00002050 File Offset: 0x00000250
		Vector3 ISpawnPoint.Position
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170022F4 RID: 8948
		// (get) Token: 0x0600C3EA RID: 50154 RVA: 0x00002050 File Offset: 0x00000250
		Vector3 IPositionPoint.Position
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170022F5 RID: 8949
		// (get) Token: 0x0600C3EB RID: 50155 RVA: 0x00002050 File Offset: 0x00000250
		Quaternion ISpawnPoint.Rotation
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170022F6 RID: 8950
		// (get) Token: 0x0600C3EC RID: 50156 RVA: 0x00002050 File Offset: 0x00000250
		EPlayerSideMask ISpawnPoint.Sides
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170022F7 RID: 8951
		// (get) Token: 0x0600C3ED RID: 50157 RVA: 0x00002050 File Offset: 0x00000250
		ESpawnCategoryMask ISpawnPoint.Categories
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170022F8 RID: 8952
		// (get) Token: 0x0600C3EE RID: 50158 RVA: 0x00002050 File Offset: 0x00000250
		string ISpawnPoint.Infiltration
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170022F9 RID: 8953
		// (get) Token: 0x0600C3EF RID: 50159 RVA: 0x00002050 File Offset: 0x00000250
		string ISpawnPoint.BotZoneName
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170022FA RID: 8954
		// (get) Token: 0x0600C3F0 RID: 50160 RVA: 0x00002050 File Offset: 0x00000250
		bool ISpawnPoint.IsSnipeZone
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170022FB RID: 8955
		// (get) Token: 0x0600C3F1 RID: 50161 RVA: 0x00002050 File Offset: 0x00000250
		float ISpawnPoint.DelayToCanSpawnSec
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170022FC RID: 8956
		// (get) Token: 0x0600C3F2 RID: 50162 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600C3F3 RID: 50163 RVA: 0x00002050 File Offset: 0x00000250
		public float NextBornTime
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170022FD RID: 8957
		// (get) Token: 0x0600C3F4 RID: 50164 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600C3F5 RID: 50165 RVA: 0x00002050 File Offset: 0x00000250
		int ISpawnPoint.CorePointId
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

		// Token: 0x0600C3F6 RID: 50166 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Dispose()
		{
			throw null;
		}

		// Token: 0x0400C5C6 RID: 50630
		public string Id;

		// Token: 0x0400C5C7 RID: 50631
		public string Name;

		// Token: 0x0400C5C8 RID: 50632
		public Vector3 Position;

		// Token: 0x0400C5C9 RID: 50633
		public Quaternion Rotation;

		// Token: 0x0400C5CA RID: 50634
		public EPlayerSideMask Sides;

		// Token: 0x0400C5CB RID: 50635
		public ESpawnCategoryMask Categories;

		// Token: 0x0400C5CC RID: 50636
		public string Infiltration;

		// Token: 0x0400C5CD RID: 50637
		public BotZone BotZone;

		// Token: 0x0400C5CE RID: 50638
		public float DelayToCanSpawnSec;

		// Token: 0x0400C5CF RID: 50639
		public int CorePointId;
	}
}
