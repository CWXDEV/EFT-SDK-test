using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000BBA RID: 3002
public class CullingObject : MonoBehaviour, IBotController, GInterface42
{
	// Token: 0x17000A8D RID: 2701
	// (get) Token: 0x06004133 RID: 16691 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06004134 RID: 16692 RVA: 0x00002050 File Offset: 0x00000250
	public int Index
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

	// Token: 0x17000A8E RID: 2702
	// (get) Token: 0x06004135 RID: 16693 RVA: 0x00002050 File Offset: 0x00000250
	public float CullDistanceSqr
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000A8F RID: 2703
	// (get) Token: 0x06004136 RID: 16694 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06004137 RID: 16695 RVA: 0x00002050 File Offset: 0x00000250
	public bool CullByDistanceOnly
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

	// Token: 0x17000A90 RID: 2704
	// (get) Token: 0x06004138 RID: 16696 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06004139 RID: 16697 RVA: 0x00002050 File Offset: 0x00000250
	public float Radius
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

	// Token: 0x17000A91 RID: 2705
	// (get) Token: 0x0600413A RID: 16698 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600413B RID: 16699 RVA: 0x00002050 File Offset: 0x00000250
	public Vector3 Shift
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

	// Token: 0x17000A92 RID: 2706
	// (get) Token: 0x0600413C RID: 16700 RVA: 0x00002050 File Offset: 0x00000250
	public Vector3 Position
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000A93 RID: 2707
	// (get) Token: 0x0600413D RID: 16701 RVA: 0x00002050 File Offset: 0x00000250
	public Vector3 SafeMultithreadedPosition
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000A94 RID: 2708
	// (get) Token: 0x0600413E RID: 16702 RVA: 0x00002050 File Offset: 0x00000250
	public Vector3 ClearTransformPosition
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000A95 RID: 2709
	// (get) Token: 0x0600413F RID: 16703 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06004140 RID: 16704 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsVisible
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x17000A96 RID: 2710
	// (get) Token: 0x06004141 RID: 16705 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06004142 RID: 16706 RVA: 0x00002050 File Offset: 0x00000250
	public float SqrCameraDistance
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

	// Token: 0x17000A97 RID: 2711
	// (get) Token: 0x06004143 RID: 16707 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06004144 RID: 16708 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsVisibleByCamera
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

	// Token: 0x06004145 RID: 16709 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void Awake()
	{
		throw null;
	}

	// Token: 0x06004146 RID: 16710 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnValidate()
	{
		throw null;
	}

	// Token: 0x06004147 RID: 16711 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnPreProcess()
	{
		throw null;
	}

	// Token: 0x06004148 RID: 16712 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Start()
	{
		throw null;
	}

	// Token: 0x06004149 RID: 16713 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CustomUpdate()
	{
		throw null;
	}

	// Token: 0x0600414A RID: 16714 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetAutocullVisibility(bool flag)
	{
		throw null;
	}

	// Token: 0x17000A98 RID: 2712
	// (get) Token: 0x0600414B RID: 16715 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600414C RID: 16716 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsAutocullVisible
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

	// Token: 0x0600414D RID: 16717 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SetVisibility(bool isVisible)
	{
		throw null;
	}

	// Token: 0x0600414E RID: 16718 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Register()
	{
		throw null;
	}

	// Token: 0x0600414F RID: 16719 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(bool isVisible)
	{
		throw null;
	}

	// Token: 0x06004150 RID: 16720 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnDestroy()
	{
		throw null;
	}

	// Token: 0x06004151 RID: 16721 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDrawGizmosSelected()
	{
		throw null;
	}

	// Token: 0x06004152 RID: 16722 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual Transform GetTransform()
	{
		throw null;
	}

	// Token: 0x06004153 RID: 16723 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SortComponentsToTurnOff()
	{
		throw null;
	}

	// Token: 0x04004A5F RID: 19039
	[SerializeField]
	protected float CullDistance;

	// Token: 0x04004A60 RID: 19040
	[SerializeField]
	protected float _radius;

	// Token: 0x04004A61 RID: 19041
	[SerializeField]
	protected Vector3 _shift;

	// Token: 0x04004A62 RID: 19042
	[SerializeField]
	private bool _drawSphere;

	// Token: 0x04004A63 RID: 19043
	[SerializeField]
	private bool _cullByDistanceOnly;

	// Token: 0x04004A64 RID: 19044
	[SerializeField]
	protected List<Component> _componentsToTurnOff;

	// Token: 0x04004A65 RID: 19045
	[SerializeField]
	[HideInInspector]
	private List<DisablerCullingObject.ComponentState> _componentsToTurnOffDefaultState;

	// Token: 0x04004A66 RID: 19046
	[SerializeField]
	private List<GameObject> _gameObjectsToTurnOff;

	// Token: 0x04004A67 RID: 19047
	[SerializeField]
	private Transform _transform;

	// Token: 0x04004A68 RID: 19048
	[CompilerGenerated]
	private int int_0;

	// Token: 0x04004A69 RID: 19049
	private Vector3 vector3_0;

	// Token: 0x04004A6A RID: 19050
	protected bool _isVisible;

	// Token: 0x04004A6B RID: 19051
	[CompilerGenerated]
	private float float_0;

	// Token: 0x04004A6C RID: 19052
	[CompilerGenerated]
	private bool bool_0;

	// Token: 0x04004A6D RID: 19053
	[CompilerGenerated]
	private bool bool_1;

	// Token: 0x04004A6E RID: 19054
	[SerializeField]
	private int _componentsSwitchPerFrameOnEnable;

	// Token: 0x04004A6F RID: 19055
	[SerializeField]
	private int _objectsSwitchPerFrameOnEnable;

	// Token: 0x04004A70 RID: 19056
	[SerializeField]
	private int _componentsSwitchPerFrameOnDisable;

	// Token: 0x04004A71 RID: 19057
	[SerializeField]
	private int _objectsSwitchPerFrameOnDisable;

	// Token: 0x04004A72 RID: 19058
	private Stopwatch stopwatch_0;

	// Token: 0x04004A73 RID: 19059
	private IEnumerator ienumerator_0;
}
