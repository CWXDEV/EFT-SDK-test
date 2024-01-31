using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Networking;

// Token: 0x020015BD RID: 5565
public class GClass1735
{
	// Token: 0x17001316 RID: 4886
	// (get) Token: 0x0600793C RID: 31036 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600793D RID: 31037 RVA: 0x00002050 File Offset: 0x00000250
	public float Speed
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected set
		{
			throw null;
		}
	}

	// Token: 0x1400015D RID: 349
	// (add) Token: 0x0600793E RID: 31038 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600793F RID: 31039 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<float> OnSpeedChanged
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

	// Token: 0x06007940 RID: 31040 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private GClass1735.PlayerStateLimits method_0(EPlayerState state)
	{
		throw null;
	}

	// Token: 0x06007941 RID: 31041 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected float method_1(EPlayerState state, int strengthLevel, float walkSpeedLimit)
	{
		throw null;
	}

	// Token: 0x06007942 RID: 31042 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update(EPlayerState state, int strengthLevel, float walkSpeedLimit)
	{
		throw null;
	}

	// Token: 0x06007943 RID: 31043 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update(float deltaTime)
	{
		throw null;
	}

	// Token: 0x06007944 RID: 31044 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static float CalculateDistance(Vector3 from, Vector3 to, bool skipY = false)
	{
		throw null;
	}

	// Token: 0x06007945 RID: 31045 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static float CalculateSqrDistance(Vector3 from, Vector3 to, bool skipY = false)
	{
		throw null;
	}

	// Token: 0x06007946 RID: 31046 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static float CalculateSpeed(float distance, float time)
	{
		throw null;
	}

	// Token: 0x04007E13 RID: 32275
	private static readonly GClass1735.PlayerStateLimits playerStateLimits_0;

	// Token: 0x04007E14 RID: 32276
	private static readonly GClass1735.PlayerStateLimits playerStateLimits_1;

	// Token: 0x04007E15 RID: 32277
	private static readonly GClass1735.PlayerStateLimits playerStateLimits_2;

	// Token: 0x04007E16 RID: 32278
	public static readonly GClass1735.Config DefaultSpeedLimits;

	// Token: 0x04007E17 RID: 32279
	private GClass1735.Config config_0;

	// Token: 0x04007E18 RID: 32280
	private int int_0;

	// Token: 0x04007E19 RID: 32281
	private float float_0;

	// Token: 0x04007E1A RID: 32282
	[CompilerGenerated]
	private Action<float> action_0;

	// Token: 0x020015BE RID: 5566
	[Serializable]
	public struct PlayerStateLimits
	{
		// Token: 0x06007947 RID: 31047 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Serialize(NetworkWriter writer)
		{
			throw null;
		}

		// Token: 0x06007948 RID: 31048 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Deserialize(NetworkReader reader)
		{
			throw null;
		}

		// Token: 0x04007E1B RID: 32283
		public float MinSpeed;

		// Token: 0x04007E1C RID: 32284
		public float MaxSpeed;
	}

	// Token: 0x020015BF RID: 5567
	[Serializable]
	public class Config
	{
		// Token: 0x06007949 RID: 31049 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Serialize(NetworkWriter writer)
		{
			throw null;
		}

		// Token: 0x0600794A RID: 31050 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Deserialize(NetworkReader reader)
		{
			throw null;
		}

		// Token: 0x04007E1D RID: 32285
		public GClass1735.PlayerStateLimits DefaultPlayerStateLimits;

		// Token: 0x04007E1E RID: 32286
		public Dictionary<EPlayerState, GClass1735.PlayerStateLimits> PlayerStateLimits;
	}
}
