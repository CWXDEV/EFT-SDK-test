using System;
using System.IO;
using System.Runtime.CompilerServices;
using EFT;

// Token: 0x02001033 RID: 4147
public class GClass1124 : GClass1121, IStateBehaviour, IPlayerStateContainerBehaviour
{
	// Token: 0x17000DA8 RID: 3496
	// (get) Token: 0x06005692 RID: 22162 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06005693 RID: 22163 RVA: 0x00002050 File Offset: 0x00000250
	public bool DefaultState
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

	// Token: 0x17000DA9 RID: 3497
	// (get) Token: 0x06005694 RID: 22164 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06005695 RID: 22165 RVA: 0x00002050 File Offset: 0x00000250
	public EPlayerState PlayerStateName
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

	// Token: 0x17000DAA RID: 3498
	// (get) Token: 0x06005696 RID: 22166 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06005697 RID: 22167 RVA: 0x00002050 File Offset: 0x00000250
	public BaseMovementState EncapsulatedState
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

	// Token: 0x17000DAB RID: 3499
	// (get) Token: 0x06005698 RID: 22168 RVA: 0x00002050 File Offset: 0x00000250
	public int FullNameHash
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06005699 RID: 22169 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(Func<EPlayerState, int, bool, BaseMovementState> newStateFunc)
	{
		throw null;
	}

	// Token: 0x0600569A RID: 22170 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Deinit()
	{
		throw null;
	}

	// Token: 0x0600569B RID: 22171 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override GClass1121 Clone()
	{
		throw null;
	}

	// Token: 0x0600569C RID: 22172 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Serialize(BinaryWriter writer)
	{
		throw null;
	}

	// Token: 0x0600569D RID: 22173 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Deserialize(BinaryReader reader)
	{
		throw null;
	}

	// Token: 0x0600569E RID: 22174 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnStateEnter(GClass1134 fastAnimatorProcessor, in AnimatorStateInfoWrapper layerInfo, int layerIndex)
	{
		throw null;
	}

	// Token: 0x0600569F RID: 22175 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnStateUpdate(GClass1134 fastAnimatorProcessor, in AnimatorStateInfoWrapper layerInfo, int layerIndex)
	{
		throw null;
	}

	// Token: 0x060056A0 RID: 22176 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnStateExit(GClass1134 fastAnimatorProcessor, in AnimatorStateInfoWrapper layerInfo, int layerIndex)
	{
		throw null;
	}

	// Token: 0x060056A1 RID: 22177 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnStateMove(GClass1134 fastAnimatorProcessor, in AnimatorStateInfoWrapper layerInfo, int layerIndex)
	{
		throw null;
	}

	// Token: 0x060056A2 RID: 22178 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool Equals(object obj)
	{
		throw null;
	}

	// Token: 0x060056A3 RID: 22179 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int GetHashCode()
	{
		throw null;
	}

	// Token: 0x060056A4 RID: 22180 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected bool method_0(GClass1124 other)
	{
		throw null;
	}

	// Token: 0x040062AD RID: 25261
	public bool IsDefaultState;

	// Token: 0x040062AE RID: 25262
	public EPlayerState Name;

	// Token: 0x040062AF RID: 25263
	public EStateType Type;

	// Token: 0x040062B0 RID: 25264
	public float RotationSpeedClamp;

	// Token: 0x040062B1 RID: 25265
	public float StateSensitivity;

	// Token: 0x040062B2 RID: 25266
	public bool CanInteract;

	// Token: 0x040062B3 RID: 25267
	public bool DisableRootMotion;

	// Token: 0x040062B4 RID: 25268
	public bool CreateUniqueMovementStateObject;

	// Token: 0x040062B5 RID: 25269
	public float AnimationAuthority;

	// Token: 0x040062B6 RID: 25270
	public float AuthoritySpeed;

	// Token: 0x040062B7 RID: 25271
	public string StateFullName;

	// Token: 0x040062B8 RID: 25272
	public float StateLength;

	// Token: 0x040062B9 RID: 25273
	public int StateFullNameHash;

	// Token: 0x040062BA RID: 25274
	[CompilerGenerated]
	private BaseMovementState baseMovementState_0;
}
