using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

// Token: 0x020006CE RID: 1742
[ExecuteInEditMode]
public class SimpleCharacterController : MonoBehaviour, ICharacterController
{
	// Token: 0x1700070B RID: 1803
	// (get) Token: 0x0600273F RID: 10047 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06002740 RID: 10048 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsSpeedLimitWasEnabledAtTheFrame
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

	// Token: 0x1700070C RID: 1804
	// (get) Token: 0x06002741 RID: 10049 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06002742 RID: 10050 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsMoveIgnored
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

	// Token: 0x1700070D RID: 1805
	// (get) Token: 0x06002743 RID: 10051 RVA: 0x00002050 File Offset: 0x00000250
	public bool SupportDepenetration
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06002744 RID: 10052 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetSteerDirection(Vector3 steerDirection)
	{
		throw null;
	}

	// Token: 0x1700070E RID: 1806
	// (get) Token: 0x06002745 RID: 10053 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06002746 RID: 10054 RVA: 0x00002050 File Offset: 0x00000250
	public float SpeedLimit
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

	// Token: 0x14000072 RID: 114
	// (add) Token: 0x06002747 RID: 10055 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06002748 RID: 10056 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<float> OnHeightChanged
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

	// Token: 0x1700070F RID: 1807
	// (get) Token: 0x06002749 RID: 10057 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600274A RID: 10058 RVA: 0x00002050 File Offset: 0x00000250
	public bool isEnabled
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

	// Token: 0x17000710 RID: 1808
	// (get) Token: 0x0600274B RID: 10059 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600274C RID: 10060 RVA: 0x00002050 File Offset: 0x00000250
	public Vector3 center
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

	// Token: 0x17000711 RID: 1809
	// (get) Token: 0x0600274D RID: 10061 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600274E RID: 10062 RVA: 0x00002050 File Offset: 0x00000250
	public CollisionFlags collisionFlags
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

	// Token: 0x17000712 RID: 1810
	// (get) Token: 0x0600274F RID: 10063 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06002750 RID: 10064 RVA: 0x00002050 File Offset: 0x00000250
	public bool detectCollisions
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

	// Token: 0x17000713 RID: 1811
	// (get) Token: 0x06002751 RID: 10065 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06002752 RID: 10066 RVA: 0x00002050 File Offset: 0x00000250
	public float height
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

	// Token: 0x17000714 RID: 1812
	// (get) Token: 0x06002753 RID: 10067 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06002754 RID: 10068 RVA: 0x00002050 File Offset: 0x00000250
	public bool isGrounded
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

	// Token: 0x17000715 RID: 1813
	// (get) Token: 0x06002755 RID: 10069 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06002756 RID: 10070 RVA: 0x00002050 File Offset: 0x00000250
	public float skinWidth
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

	// Token: 0x17000716 RID: 1814
	// (get) Token: 0x06002757 RID: 10071 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06002758 RID: 10072 RVA: 0x00002050 File Offset: 0x00000250
	public float radius
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

	// Token: 0x17000717 RID: 1815
	// (get) Token: 0x06002759 RID: 10073 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600275A RID: 10074 RVA: 0x00002050 File Offset: 0x00000250
	public float slopeLimit
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

	// Token: 0x17000718 RID: 1816
	// (get) Token: 0x0600275B RID: 10075 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600275C RID: 10076 RVA: 0x00002050 File Offset: 0x00000250
	public float stepOffset
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

	// Token: 0x17000719 RID: 1817
	// (get) Token: 0x0600275D RID: 10077 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600275E RID: 10078 RVA: 0x00002050 File Offset: 0x00000250
	public Vector3 velocity
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

	// Token: 0x1700071A RID: 1818
	// (get) Token: 0x0600275F RID: 10079 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06002760 RID: 10080 RVA: 0x00002050 File Offset: 0x00000250
	public Rigidbody attachedRigidbody
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

	// Token: 0x1700071B RID: 1819
	// (get) Token: 0x06002761 RID: 10081 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06002762 RID: 10082 RVA: 0x00002050 File Offset: 0x00000250
	public Bounds bounds
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

	// Token: 0x1700071C RID: 1820
	// (get) Token: 0x06002763 RID: 10083 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06002764 RID: 10084 RVA: 0x00002050 File Offset: 0x00000250
	public float contactOffset
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

	// Token: 0x1700071D RID: 1821
	// (get) Token: 0x06002765 RID: 10085 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06002766 RID: 10086 RVA: 0x00002050 File Offset: 0x00000250
	public Vector3 surfaceNormalAccordingToCapsule
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

	// Token: 0x1700071E RID: 1822
	// (get) Token: 0x06002767 RID: 10087 RVA: 0x00002050 File Offset: 0x00000250
	private bool Boolean_0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06002768 RID: 10088 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(Transform movementTransform, Collider[] colliders, CapsuleCollider mainCollider, float fixedDeltaDistance, LayerMask collisionMask, float stepOffset, float slopeLimit)
	{
		throw null;
	}

	// Token: 0x06002769 RID: 10089 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RegisterCanSeepThroughDelegate(Func<Collider, int> canSeepThroughDelegate)
	{
		throw null;
	}

	// Token: 0x0600276A RID: 10090 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddNoSpeedLimitCollisionColliders(IEnumerable<Collider> colliders)
	{
		throw null;
	}

	// Token: 0x0600276B RID: 10091 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveNoSpeedLimitCollisionColliders(IEnumerable<Collider> colliders)
	{
		throw null;
	}

	// Token: 0x0600276C RID: 10092 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(Collider[] colliders)
	{
		throw null;
	}

	// Token: 0x0600276D RID: 10093 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public CollisionFlags Move(Vector3 motion, float deltaTime)
	{
		throw null;
	}

	// Token: 0x0600276E RID: 10094 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(Vector3 startPosition, float deltaTime)
	{
		throw null;
	}

	// Token: 0x0600276F RID: 10095 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_2()
	{
		throw null;
	}

	// Token: 0x06002770 RID: 10096 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_3(LayerMask layerMask)
	{
		throw null;
	}

	// Token: 0x06002771 RID: 10097 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_4(Vector3 motion)
	{
		throw null;
	}

	// Token: 0x06002772 RID: 10098 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private int method_5(Vector3 desiredPoint, bool updateNeighbours, bool doSnapToGround, out Vector3 resolvedPoint, out bool feelingTightMain)
	{
		throw null;
	}

	// Token: 0x06002773 RID: 10099 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private int method_6(Collider collider, SimpleCharacterController.GClass658 neighboursColliders, Vector3 desiredPoint, float snapGroundDenepentrationToUp, bool updateNeighbours, out Vector3 resolvedPoint, out Vector3 surfaceNormal, out bool feelingTight)
	{
		throw null;
	}

	// Token: 0x06002774 RID: 10100 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_7(Collider collider, SimpleCharacterController.GClass658 neighboursColliders, Vector3 desiredPoint)
	{
		throw null;
	}

	// Token: 0x06002775 RID: 10101 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_8(Collider collider)
	{
		throw null;
	}

	// Token: 0x06002776 RID: 10102 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_9(SimpleCharacterController.GClass658 neighboursColliders)
	{
		throw null;
	}

	// Token: 0x06002777 RID: 10103 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_10()
	{
		throw null;
	}

	// Token: 0x06002778 RID: 10104 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_11(SimpleCharacterController.GClass658 collidersArray)
	{
		throw null;
	}

	// Token: 0x06002779 RID: 10105 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private int method_12(Collider collider)
	{
		throw null;
	}

	// Token: 0x0600277A RID: 10106 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_13(Vector3 currentPoint, Vector3 destinationPoint, float deltaTime)
	{
		throw null;
	}

	// Token: 0x0600277B RID: 10107 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Vector3 method_14(Vector3 startPoint, Vector3 motion, Vector3 desiredPoint)
	{
		throw null;
	}

	// Token: 0x0600277C RID: 10108 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_15(Vector3 startPoint, Vector3 forwardDirection, float forwardDistance, out RaycastHit bestHit)
	{
		throw null;
	}

	// Token: 0x0600277D RID: 10109 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_16(Ray ray, RaycastHit[] results, float maxDistance, int layerMask, out RaycastHit bestHit)
	{
		throw null;
	}

	// Token: 0x0600277E RID: 10110 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_17(Vector3 point)
	{
		throw null;
	}

	// Token: 0x0600277F RID: 10111 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Vector3 method_18(Vector3 point)
	{
		throw null;
	}

	// Token: 0x06002780 RID: 10112 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_19(int count, RaycastHit[] colliders)
	{
		throw null;
	}

	// Token: 0x06002781 RID: 10113 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_20(int count, Collider[] colliders)
	{
		throw null;
	}

	// Token: 0x06002782 RID: 10114 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetEnableVerticalDepenetration(bool enable)
	{
		throw null;
	}

	// Token: 0x06002783 RID: 10115 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool SimpleMove(Vector3 motion)
	{
		throw null;
	}

	// Token: 0x06002784 RID: 10116 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CopyFields(ICharacterController characterController)
	{
		throw null;
	}

	// Token: 0x06002785 RID: 10117 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CopyFields(GStruct201 footprint)
	{
		throw null;
	}

	// Token: 0x06002786 RID: 10118 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GStruct201 GetFootprint()
	{
		throw null;
	}

	// Token: 0x06002787 RID: 10119 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Collider GetCollider()
	{
		throw null;
	}

	// Token: 0x1700071F RID: 1823
	// (get) Token: 0x06002788 RID: 10120 RVA: 0x00002050 File Offset: 0x00000250
	public bool ShouldStickToGround
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06002789 RID: 10121 RVA: 0x00002050 File Offset: 0x00000250
	[Conditional("UNITY_EDITOR")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_21(string message, params object[] args)
	{
		throw null;
	}

	// Token: 0x0600278A RID: 10122 RVA: 0x00002050 File Offset: 0x00000250
	[Conditional("UNITY_EDITOR")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_22<T>(string name, T msg)
	{
		throw null;
	}

	// Token: 0x0600278B RID: 10123 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SeTightDotThreshold(float degrees)
	{
		throw null;
	}

	// Token: 0x0600278C RID: 10124 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetSnapGroundDenepentrationToUpInDegrees(float degrees)
	{
		throw null;
	}

	// Token: 0x0600278D RID: 10125 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SeGroundDotThreshold(float degrees)
	{
		throw null;
	}

	// Token: 0x0600278E RID: 10126 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SeSlotLimitDot(float degrees)
	{
		throw null;
	}

	// Token: 0x0600278F RID: 10127 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDrawGizmos()
	{
		throw null;
	}

	// Token: 0x04002668 RID: 9832
	[SerializeField]
	private Transform _movementTransform;

	// Token: 0x04002669 RID: 9833
	[SerializeField]
	private CapsuleCollider _mainCollider;

	// Token: 0x0400266A RID: 9834
	[SerializeField]
	private Collider[] _colliders;

	// Token: 0x0400266B RID: 9835
	[SerializeField]
	private LayerMask _collisionMask;

	// Token: 0x0400266C RID: 9836
	private const int int_0 = 64;

	// Token: 0x0400266D RID: 9837
	[Header("Settings")]
	[SerializeField]
	private float _castHalo;

	// Token: 0x0400266E RID: 9838
	[SerializeField]
	private float _groundDotThreshold;

	// Token: 0x0400266F RID: 9839
	[SerializeField]
	private float _maxDepenetrationDistance;

	// Token: 0x04002670 RID: 9840
	[SerializeField]
	private float _maxDepenetrationDistanceResolve;

	// Token: 0x04002671 RID: 9841
	[SerializeField]
	private float _snapGroundDenepentrationToUp;

	// Token: 0x04002672 RID: 9842
	[SerializeField]
	private float _fixedDeltaDistance;

	// Token: 0x04002673 RID: 9843
	[SerializeField]
	[Header("Speed Limit")]
	private float _speedLimit;

	// Token: 0x04002674 RID: 9844
	[SerializeField]
	private float _sqrSpeedLimit;

	// Token: 0x04002675 RID: 9845
	[Header("Resolve Tightness")]
	[SerializeField]
	private float _tightDotThreshold;

	// Token: 0x04002676 RID: 9846
	[SerializeField]
	private int _maxIterationsToResolveTightness;

	// Token: 0x04002677 RID: 9847
	[SerializeField]
	private float _feelingTightMaxMotion;

	// Token: 0x04002678 RID: 9848
	[SerializeField]
	private int _finePositionsToRemember;

	// Token: 0x04002679 RID: 9849
	[SerializeField]
	private bool _isSeepingActive;

	// Token: 0x0400267A RID: 9850
	[Header("Stepping")]
	[SerializeField]
	private float _canStandUpRising;

	// Token: 0x0400267B RID: 9851
	[SerializeField]
	private float _canStepUpExpanse;

	// Token: 0x0400267C RID: 9852
	[SerializeField]
	private float _stepUpDumpPercent;

	// Token: 0x0400267D RID: 9853
	[SerializeField]
	private float _canStandUpObstacleHeight;

	// Token: 0x0400267E RID: 9854
	private const float float_0 = 0.17f;

	// Token: 0x0400267F RID: 9855
	[SerializeField]
	[Header("Huunity Depenetration Bug")]
	private bool _resolveHuunityDepenetrationBug;

	// Token: 0x04002680 RID: 9856
	[SerializeField]
	private float _depenetrationBugRayAddition;

	// Token: 0x04002681 RID: 9857
	[SerializeField]
	[Header("Alerts")]
	private int _maxCycleCountToHalt;

	// Token: 0x04002682 RID: 9858
	private Vector3 vector3_0;

	// Token: 0x04002683 RID: 9859
	private int int_1;

	// Token: 0x04002684 RID: 9860
	private bool bool_0;

	// Token: 0x04002685 RID: 9861
	private bool bool_1;

	// Token: 0x04002686 RID: 9862
	private HashSet<Collider> hashSet_0;

	// Token: 0x04002687 RID: 9863
	[CompilerGenerated]
	private bool bool_2;

	// Token: 0x04002688 RID: 9864
	[CompilerGenerated]
	private bool bool_3;

	// Token: 0x04002689 RID: 9865
	private SimpleCharacterController.GClass658[] gclass658_0;

	// Token: 0x0400268A RID: 9866
	private RaycastHit[] raycastHit_0;

	// Token: 0x0400268B RID: 9867
	private Vector3 vector3_1;

	// Token: 0x0400268C RID: 9868
	[CompilerGenerated]
	private Action<float> action_0;

	// Token: 0x0400268D RID: 9869
	private bool bool_4;

	// Token: 0x0400268E RID: 9870
	private bool bool_5;

	// Token: 0x0400268F RID: 9871
	private float float_1;

	// Token: 0x04002690 RID: 9872
	private float float_2;

	// Token: 0x04002691 RID: 9873
	[Header("Other")]
	[SerializeField]
	private float _slopLimitDot;

	// Token: 0x04002692 RID: 9874
	private float float_3;

	// Token: 0x04002693 RID: 9875
	[SerializeField]
	private float _stepOffsetInternal;

	// Token: 0x04002694 RID: 9876
	private Vector3 vector3_2;

	// Token: 0x04002695 RID: 9877
	private Vector3 vector3_3;

	// Token: 0x04002696 RID: 9878
	private Func<Collider, int> func_0;

	// Token: 0x020006CF RID: 1743
	public class GClass658
	{
		// Token: 0x04002697 RID: 9879
		public Collider[] colliders;

		// Token: 0x04002698 RID: 9880
		public SimpleCharacterController.GClass658.GStruct30[] collisionInfos;

		// Token: 0x04002699 RID: 9881
		public int count;

		// Token: 0x0400269A RID: 9882
		public List<Collider> seepColliders;

		// Token: 0x020006D0 RID: 1744
		[StructLayout(LayoutKind.Auto)]
		public struct GStruct30
		{
			// Token: 0x0400269B RID: 9883
			public bool IsOverlapped;
		}
	}
}
