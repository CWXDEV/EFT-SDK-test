using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;

// Token: 0x020006D2 RID: 1746
public class TriggerColliderSearcher : MonoBehaviour
{
	// Token: 0x14000073 RID: 115
	// (add) Token: 0x06002792 RID: 10130 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06002793 RID: 10131 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<IPhysicsTrigger> OnEnter
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
			throw null;
		}
	}

	// Token: 0x14000074 RID: 116
	// (add) Token: 0x06002794 RID: 10132 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06002795 RID: 10133 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<IPhysicsTrigger> OnExit
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
			throw null;
		}
	}

	// Token: 0x17000720 RID: 1824
	// (get) Token: 0x06002796 RID: 10134 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06002797 RID: 10135 RVA: 0x00002050 File Offset: 0x00000250
	public Transform OverrideTransformPosition
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

	// Token: 0x17000721 RID: 1825
	// (get) Token: 0x06002798 RID: 10136 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06002799 RID: 10137 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsInited
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

	// Token: 0x0600279A RID: 10138 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(Collider collider, LayerMask castLayerMask)
	{
		throw null;
	}

	// Token: 0x0600279B RID: 10139 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ConnectToCharacterController(ICharacterController characterController)
	{
		throw null;
	}

	// Token: 0x0600279C RID: 10140 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ManualUpdate(float deltaTime, bool isCloseToCamera = true)
	{
		throw null;
	}

	// Token: 0x0600279D RID: 10141 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Bounds method_0()
	{
		throw null;
	}

	// Token: 0x040026A0 RID: 9888
	public const int MAX_COLLIDERS = 512;

	// Token: 0x040026A1 RID: 9889
	public const int MAX_WORLDS_COLLIDERS = 8;

	// Token: 0x040026A2 RID: 9890
	[SerializeField]
	private Collider _collider;

	// Token: 0x040026A3 RID: 9891
	[SerializeField]
	private LayerMask _castLayerMask;

	// Token: 0x040026A4 RID: 9892
	private ICharacterController icharacterController_0;

	// Token: 0x040026A5 RID: 9893
	private Transform transform_0;

	// Token: 0x040026A6 RID: 9894
	private TriggerColliderSearcher.Class367 class367_0;

	// Token: 0x040026A7 RID: 9895
	[CanBeNull]
	private TriggerColliderSearcher.Class367 class367_1;

	// Token: 0x040026A8 RID: 9896
	private List<TriggerColliderSearcher.Class367> list_0;

	// Token: 0x040026A9 RID: 9897
	public bool IsEnabled;

	// Token: 0x040026AA RID: 9898
	[CompilerGenerated]
	private bool bool_0;

	// Token: 0x020006D3 RID: 1747
	private class Class367
	{
		// Token: 0x14000075 RID: 117
		// (add) Token: 0x0600279E RID: 10142 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600279F RID: 10143 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<IPhysicsTrigger> OnEnter
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

		// Token: 0x14000076 RID: 118
		// (add) Token: 0x060027A0 RID: 10144 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060027A1 RID: 10145 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<IPhysicsTrigger> OnExit
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

		// Token: 0x060027A2 RID: 10146 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Connect(Func<Bounds> boundsGetter)
		{
			throw null;
		}

		// Token: 0x060027A3 RID: 10147 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ManualUpdate(GClass646.GClass650.EWorldType physicsWorldTypeMask, LayerMask castLayerMask)
		{
			throw null;
		}

		// Token: 0x060027A4 RID: 10148 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator method_0()
		{
			throw null;
		}

		// Token: 0x060027A5 RID: 10149 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(Collider collider)
		{
			throw null;
		}

		// Token: 0x060027A6 RID: 10150 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(Collider collider, int index)
		{
			throw null;
		}

		// Token: 0x060027A7 RID: 10151 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(Collider collider)
		{
			throw null;
		}

		// Token: 0x040026AB RID: 9899
		private string string_0;

		// Token: 0x040026AC RID: 9900
		private Collider collider_0;

		// Token: 0x040026AD RID: 9901
		private LayerMask layerMask_0;

		// Token: 0x040026AE RID: 9902
		private Func<Bounds> func_0;

		// Token: 0x040026AF RID: 9903
		public Transform OverrideTransformPosition;

		// Token: 0x040026B0 RID: 9904
		private GClass646.GClass650.EWorldType eworldType_0;

		// Token: 0x040026B1 RID: 9905
		private Collider[] collider_1;

		// Token: 0x040026B2 RID: 9906
		private Collider[][] collider_2;

		// Token: 0x040026B3 RID: 9907
		private List<Collider> list_0;

		// Token: 0x040026B4 RID: 9908
		private List<Collider> list_1;

		// Token: 0x040026B5 RID: 9909
		private Dictionary<Collider, List<IPhysicsTrigger>> dictionary_0;

		// Token: 0x040026B6 RID: 9910
		private GClass736<IPhysicsTrigger> gclass736_0;

		// Token: 0x040026B7 RID: 9911
		private List<Component> list_2;

		// Token: 0x040026B8 RID: 9912
		[CompilerGenerated]
		private Action<IPhysicsTrigger> action_0;

		// Token: 0x040026B9 RID: 9913
		[CompilerGenerated]
		private Action<IPhysicsTrigger> action_1;

		// Token: 0x040026BA RID: 9914
		private IEnumerator ienumerator_0;

		// Token: 0x040026BB RID: 9915
		private long long_0;

		// Token: 0x040026BC RID: 9916
		private Stopwatch stopwatch_0;
	}
}
