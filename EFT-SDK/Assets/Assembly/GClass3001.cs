using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using EFT;
using EFT.AssetsManager;
using UnityEngine;

// Token: 0x02002870 RID: 10352
public abstract class GClass3001<T> : IDisposable, GInterface357 where T : AssetPoolObject
{
	// Token: 0x170024FB RID: 9467
	// (get) Token: 0x0600CEC5 RID: 52933 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600CEC6 RID: 52934 RVA: 0x00002050 File Offset: 0x00000250
	public ResourceKey ResourceKey
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

	// Token: 0x170024FC RID: 9468
	// (get) Token: 0x0600CEC7 RID: 52935 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600CEC8 RID: 52936 RVA: 0x00002050 File Offset: 0x00000250
	public GStruct105 ResourceType
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

	// Token: 0x170024FD RID: 9469
	// (get) Token: 0x0600CEC9 RID: 52937 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600CECA RID: 52938 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsWillBeDestroyedByParent
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

	// Token: 0x170024FE RID: 9470
	// (get) Token: 0x0600CECB RID: 52939 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600CECC RID: 52940 RVA: 0x00002050 File Offset: 0x00000250
	public bool DontDestroy
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

	// Token: 0x170024FF RID: 9471
	// (get) Token: 0x0600CECD RID: 52941 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600CECE RID: 52942 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsDisposed
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

	// Token: 0x17002500 RID: 9472
	// (get) Token: 0x0600CECF RID: 52943 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600CED0 RID: 52944 RVA: 0x00002050 File Offset: 0x00000250
	public int TotalCreatedObjectsCount
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

	// Token: 0x17002501 RID: 9473
	// (get) Token: 0x0600CED1 RID: 52945 RVA: 0x00002050 File Offset: 0x00000250
	public int CurrentPoolSize
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17002502 RID: 9474
	// (get) Token: 0x0600CED2 RID: 52946 RVA: 0x00002050 File Offset: 0x00000250
	public int FuturePoolSize
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17002503 RID: 9475
	// (get) Token: 0x0600CED3 RID: 52947
	protected abstract string PoolFullName { get; }

	// Token: 0x17002504 RID: 9476
	// (get) Token: 0x0600CED4 RID: 52948
	public abstract string PoolShortName { get; }

	// Token: 0x0600CED5 RID: 52949
	protected abstract GameObject GetOriginalGameObject(Transform parent);

	// Token: 0x17002505 RID: 9477
	// (get) Token: 0x0600CED6 RID: 52950 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600CED7 RID: 52951 RVA: 0x00002050 File Offset: 0x00000250
	public PoolContainerObject ParentObject
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

	// Token: 0x17002506 RID: 9478
	// (get) Token: 0x0600CED8 RID: 52952 RVA: 0x00002050 File Offset: 0x00000250
	private GameObject GameObject_0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17002507 RID: 9479
	// (get) Token: 0x0600CED9 RID: 52953 RVA: 0x00002050 File Offset: 0x00000250
	private bool Boolean_0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600CEDA RID: 52954 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_0(GClass3349 jobYield)
	{
		throw null;
	}

	// Token: 0x0600CEDB RID: 52955 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_1(GClass3349 jobYield)
	{
		throw null;
	}

	// Token: 0x0600CEDC RID: 52956 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_2(GameObject gameObject, GClass3349 yield)
	{
		throw null;
	}

	// Token: 0x0600CEDD RID: 52957 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3()
	{
		throw null;
	}

	// Token: 0x17002508 RID: 9480
	// (get) Token: 0x0600CEDE RID: 52958 RVA: 0x00002050 File Offset: 0x00000250
	protected virtual string ContainerObjectName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600CEDF RID: 52959 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task ExpandPool(int objectsCount, GDelegate77 yield, CancellationToken cancellationToken = default(CancellationToken), string reason = "")
	{
		throw null;
	}

	// Token: 0x0600CEE0 RID: 52960 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected Task method_4(int objectsCount, Transform parentTransform, GDelegate77 yield, CancellationToken cancellationToken)
	{
		throw null;
	}

	// Token: 0x0600CEE1 RID: 52961 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_5(GClass3349 jobYield)
	{
		throw null;
	}

	// Token: 0x0600CEE2 RID: 52962 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_6(GClass3349 jobYield)
	{
		throw null;
	}

	// Token: 0x0600CEE3 RID: 52963 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_7(T poolObject)
	{
		throw null;
	}

	// Token: 0x0600CEE4 RID: 52964 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GameObject PopOrCreate(bool poolShouldNotBeEmpty = false)
	{
		throw null;
	}

	// Token: 0x0600CEE5 RID: 52965 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ReturnPoolObjects()
	{
		throw null;
	}

	// Token: 0x0600CEE6 RID: 52966 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x0600CEE7 RID: 52967 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void QuickDispose()
	{
		throw null;
	}

	// Token: 0x0600CEE8 RID: 52968 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_8()
	{
		throw null;
	}

	// Token: 0x0600CEE9 RID: 52969 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		throw null;
	}

	// Token: 0x0600CEEA RID: 52970 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	void GInterface357.Push(AssetPoolObject poolObject)
	{
		throw null;
	}

	// Token: 0x0400CF72 RID: 53106
	protected Transform transform_0;

	// Token: 0x0400CF73 RID: 53107
	[CompilerGenerated]
	private ResourceKey resourceKey_0;

	// Token: 0x0400CF74 RID: 53108
	[CompilerGenerated]
	private GStruct105 gstruct105_0;

	// Token: 0x0400CF75 RID: 53109
	protected PoolManager.AssemblyType assemblyType_0;

	// Token: 0x0400CF76 RID: 53110
	protected Stack<T> stack_0;

	// Token: 0x0400CF77 RID: 53111
	protected GameObject gameObject_0;

	// Token: 0x0400CF78 RID: 53112
	protected T gparam_0;

	// Token: 0x0400CF79 RID: 53113
	[CompilerGenerated]
	private bool bool_0;

	// Token: 0x0400CF7A RID: 53114
	[CompilerGenerated]
	private bool bool_1;

	// Token: 0x0400CF7B RID: 53115
	[CompilerGenerated]
	private bool bool_2;

	// Token: 0x0400CF7C RID: 53116
	protected int int_0;

	// Token: 0x0400CF7D RID: 53117
	[CompilerGenerated]
	private int int_1;

	// Token: 0x0400CF7E RID: 53118
	[CompilerGenerated]
	private PoolContainerObject poolContainerObject_0;

	// Token: 0x0400CF7F RID: 53119
	private bool bool_3;

	// Token: 0x0400CF80 RID: 53120
	protected GClass3349 gclass3349_0;

	// Token: 0x0400CF81 RID: 53121
	protected GClass3349 gclass3349_1;

	// Token: 0x0400CF82 RID: 53122
	protected GClass3349 gclass3349_2;

	// Token: 0x0400CF83 RID: 53123
	private bool bool_4;

	// Token: 0x0400CF84 RID: 53124
	private int int_2;

	// Token: 0x0400CF85 RID: 53125
	private GameObject gameObject_1;

	// Token: 0x0400CF86 RID: 53126
	private static readonly Vector3 vector3_0;
}
