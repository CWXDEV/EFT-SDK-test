using System;
using System.Runtime.CompilerServices;
using EFT;
using UnityEngine;

// Token: 0x02000749 RID: 1865
public class CharacterControllerSpawner : MonoBehaviour
{
	// Token: 0x170007C1 RID: 1985
	// (get) Token: 0x06002BE2 RID: 11234 RVA: 0x00002050 File Offset: 0x00000250
	public float slopeLimit
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170007C2 RID: 1986
	// (get) Token: 0x06002BE3 RID: 11235 RVA: 0x00002050 File Offset: 0x00000250
	public float stepOffset
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170007C3 RID: 1987
	// (get) Token: 0x06002BE4 RID: 11236 RVA: 0x00002050 File Offset: 0x00000250
	public float skinWidth
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170007C4 RID: 1988
	// (get) Token: 0x06002BE5 RID: 11237 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06002BE6 RID: 11238 RVA: 0x00002050 File Offset: 0x00000250
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

	// Token: 0x170007C5 RID: 1989
	// (get) Token: 0x06002BE7 RID: 11239 RVA: 0x00002050 File Offset: 0x00000250
	public float radius
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170007C6 RID: 1990
	// (get) Token: 0x06002BE8 RID: 11240 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06002BE9 RID: 11241 RVA: 0x00002050 File Offset: 0x00000250
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

	// Token: 0x170007C7 RID: 1991
	// (get) Token: 0x06002BEA RID: 11242 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06002BEB RID: 11243 RVA: 0x00002050 File Offset: 0x00000250
	public float tilt
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

	// Token: 0x170007C8 RID: 1992
	// (get) Token: 0x06002BEC RID: 11244 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06002BED RID: 11245 RVA: 0x00002050 File Offset: 0x00000250
	public float step
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

	// Token: 0x170007C9 RID: 1993
	// (get) Token: 0x06002BEE RID: 11246 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06002BEF RID: 11247 RVA: 0x00002050 File Offset: 0x00000250
	public PlayerSpiritBones.PoseType pose
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

	// Token: 0x170007CA RID: 1994
	// (get) Token: 0x06002BF0 RID: 11248 RVA: 0x00002050 File Offset: 0x00000250
	public CharacterController CharacterController
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170007CB RID: 1995
	// (get) Token: 0x06002BF1 RID: 11249 RVA: 0x00002050 File Offset: 0x00000250
	public CapsuleCollider CapsuleCollider
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170007CC RID: 1996
	// (get) Token: 0x06002BF2 RID: 11250 RVA: 0x00002050 File Offset: 0x00000250
	public Rigidbody Rigidbody
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170007CD RID: 1997
	// (get) Token: 0x06002BF3 RID: 11251 RVA: 0x00002050 File Offset: 0x00000250
	public TriggerColliderSearcher TriggerColliderSearcher
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06002BF4 RID: 11252 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ICharacterController Spawn(CharacterControllerSpawner.Mode settings, IPlayer player, GameObject gameObject, bool isSpirit, bool isThirdPerson)
	{
		throw null;
	}

	// Token: 0x06002BF5 RID: 11253 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ICharacterController ReplaceSpawn(CharacterControllerSpawner.Mode settings, Player player, GameObject gameObject, bool isSpirit, bool isThirdPerson)
	{
		throw null;
	}

	// Token: 0x06002BF6 RID: 11254 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(Collider collider, bool thirdPerson)
	{
		throw null;
	}

	// Token: 0x06002BF7 RID: 11255 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1()
	{
		throw null;
	}

	// Token: 0x06002BF8 RID: 11256 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CreateRigidbody()
	{
		throw null;
	}

	// Token: 0x04002A7F RID: 10879
	[SerializeField]
	private float _slopeLimit;

	// Token: 0x04002A80 RID: 10880
	[SerializeField]
	private float _stepOffset;

	// Token: 0x04002A81 RID: 10881
	[SerializeField]
	private float _skinWidth;

	// Token: 0x04002A82 RID: 10882
	[SerializeField]
	private float _minMoveDistance;

	// Token: 0x04002A83 RID: 10883
	[SerializeField]
	private Vector3 _center;

	// Token: 0x04002A84 RID: 10884
	[SerializeField]
	private float _radius;

	// Token: 0x04002A85 RID: 10885
	[SerializeField]
	private float _height;

	// Token: 0x04002A86 RID: 10886
	[Range(-5f, 5f)]
	[SerializeField]
	private float _tilt;

	// Token: 0x04002A87 RID: 10887
	[Range(-1f, 1f)]
	[SerializeField]
	private float _step;

	// Token: 0x04002A88 RID: 10888
	[SerializeField]
	private PlayerSpiritBones.PoseType _pose;

	// Token: 0x04002A89 RID: 10889
	private CharacterController characterController_0;

	// Token: 0x04002A8A RID: 10890
	private CapsuleCollider capsuleCollider_0;

	// Token: 0x04002A8B RID: 10891
	private Rigidbody rigidbody_0;

	// Token: 0x04002A8C RID: 10892
	private TriggerColliderSearcher triggerColliderSearcher_0;

	// Token: 0x04002A8D RID: 10893
	private CharacterControllerSpawner.Mode mode_0;

	// Token: 0x0200074A RID: 1866
	[Serializable]
	public class Mode
	{
		// Token: 0x04002A8E RID: 10894
		public CharacterControllerSpawner.ControllerType Type;

		// Token: 0x04002A8F RID: 10895
		public bool WithRigidbody;

		// Token: 0x04002A90 RID: 10896
		public bool WithMovementValidation;

		// Token: 0x04002A91 RID: 10897
		public bool WithTriggerCollider;

		// Token: 0x04002A92 RID: 10898
		public bool WithKinematicOption;
	}

	// Token: 0x0200074B RID: 1867
	public enum ControllerType
	{
		// Token: 0x04002A94 RID: 10900
		Unity,
		// Token: 0x04002A95 RID: 10901
		Impostor,
		// Token: 0x04002A96 RID: 10902
		Simple,
		// Token: 0x04002A97 RID: 10903
		SteeringImpostor,
		// Token: 0x04002A98 RID: 10904
		BotAISteeringImpostorWithDoors
	}

	// Token: 0x0200074C RID: 1868
	[CompilerGenerated]
	[Serializable]
	private sealed class Class385
	{
		// Token: 0x06002BF9 RID: 11257 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal int method_0(Collider x)
		{
			throw null;
		}

		// Token: 0x04002A99 RID: 10905
		public static readonly CharacterControllerSpawner.Class385 class385_0;

		// Token: 0x04002A9A RID: 10906
		public static Func<Collider, int> func_0;
	}
}
