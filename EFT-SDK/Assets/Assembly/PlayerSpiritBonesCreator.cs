using System;
using EFT;
using UnityEngine;

// Token: 0x02000750 RID: 1872
[ExecuteInEditMode]
public class PlayerSpiritBonesCreator : MonoBehaviour
{
	// Token: 0x04002AB1 RID: 10929
	public GameObject PlayerSuperior;

	// Token: 0x04002AB2 RID: 10930
	public PlayerSpirit PlayerSpirit;

	// Token: 0x04002AB3 RID: 10931
	public string PlayerSpiritPath;

	// Token: 0x04002AB4 RID: 10932
	[SerializeField]
	private Animator _playerAnimator;

	// Token: 0x04002AB5 RID: 10933
	public PlayerSpiritBonesCreator.PoseConfig[] PoseConfigs;

	// Token: 0x02000751 RID: 1873
	[Serializable]
	public class PoseConfig
	{
		// Token: 0x04002AB6 RID: 10934
		public bool Collect;

		// Token: 0x04002AB7 RID: 10935
		public PlayerSpiritBones.PoseType PoseType;

		// Token: 0x04002AB8 RID: 10936
		public string AnimatorStateName;

		// Token: 0x04002AB9 RID: 10937
		public bool ProneFlag;

		// Token: 0x04002ABA RID: 10938
		[Range(0f, 1f)]
		public float LevelParam;

		// Token: 0x04002ABB RID: 10939
		[Range(-5f, 5f)]
		public float TiltParam;

		// Token: 0x04002ABC RID: 10940
		[Range(-1f, 1f)]
		public int StepParam;
	}
}
